using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using HttpServer;
using HTTPServerLib;
using ReportTemplates;
using ReportTemplates.Models;

namespace LocalPrintServer
{
    public delegate void PrinterChanged(string newPrintName);

    public delegate void PrinterLoaded(List<string> printerNames);

    public delegate void PrintServerLogging(string logMaeesage);

    public delegate void StatisticsStateChange(int total, int succeed, int errpr);



    internal class LocalPrintServer
    {
        private List<string> availablePrinterNames = new List<string>();
        private string selectedPrinterName = "";
        public PrinterLoaded OnPrinterLoaded = null;
        public PrinterChanged OnPrinterChanged = null;
        public PrintServerLogging OnPrintServerLogged = null;
        public StatisticsStateChange OnStatisticsStateChanged = null;

        private bool PrintNow = true;

        private bool _requestStop = false;
        private int totalDocument = 0;
        private int succeedDocument = 0;
        private int errorDocument = 0;

        public int Port = 4050;

        public int Total => this.totalDocument;
        public int Error => this.errorDocument;

        public int Succeed => this.succeedDocument;

        private static LocalPrintServer Server = null;
        public static LocalPrintServer Instance()
        {
            return Server ?? (Server = new LocalPrintServer());
        }

        private LocalPrintServer()
        {
            string rootPath = Environment.CurrentDirectory;
            HttpServer = ExampleServer.GetSingleServer("0.0.0.0", this.Port);
            HttpServer.SetRoot(rootPath);
            HttpServer.OnPostRequestReceived = this.OnPrintRequestReceived;

            HttpServer.Logger = new ConsoleLogger();

            ServerThread = new Thread(new ThreadStart(HttpServerThread));
            this.OnPrintServerLogged = delegate (string maeesage) { Console.WriteLine(maeesage); };
        }

        private LocalPrintServer(int workingPort)
        {
            this.Port = workingPort;
        }

        private void LoadPrinters()
        {
            foreach (var printer in PrinterSettings.InstalledPrinters)
            {
                this.availablePrinterNames.Add(printer.ToString());
            }
            OnPrinterLoaded?.Invoke(availablePrinterNames);

            string defaultPrinter = ReadPrinterName();
            if (!string.IsNullOrEmpty(defaultPrinter))
            {
                if (this.availablePrinterNames.Contains(defaultPrinter))
                {
                    this.SelectPrinter(defaultPrinter);
                }
                else
                {
                    SafeFireLoging("上次使用的打印机器:" + defaultPrinter +" 已经无效，请重新选择打印机");
                }
            }

            if (this.availablePrinterNames.Count == 0)
            {
                this.SafeFireLoging("打印机加载失败,未找到可用打印机，您可以查看点击查看文件");
            }
            else
            {
                this.SafeFireLoging("打印机加载成功，当前可用打印机数量:" + availablePrinterNames.Count);
            }
        }

        private readonly ExampleServer HttpServer = null;
        private readonly Thread ServerThread = null;
        private void StartServer()
        {
            if (!ServerThread.IsAlive)
            {
                this._requestStop = false;
                ServerThread.Start();
                StartSerialPrintThread();
                SafeFireLoging("服务线程已启动，正在尝试打开服务..." );
            }
        }

        public void SetPrintNow(bool printNow)
        {
            this.PrintNow = printNow;
        }

        private void HttpServerThread()
        {
            try
            {
                SafeFireLoging("服务已启动,您现在可以打印...");
                HttpServer.Start();
            }
            catch (Exception ex)
            {
                SafeFireLoging("出现异常，服务已关闭："+ ex.Message);
            }
        }

        public void StopServer()
        {
            try
            {
                HttpServer.Stop();
                HttpServer?.Stop();
                _requestStop = true;
                this.printEvent.Set();
                SafeFireLoging("服务已停止");
            }
            catch (Exception ex)
            {
                SafeFireLoging("停止服务失败：" + ex.Message);
            }
        }

        private Thread serialPrinThread = null;
        private void StartSerialPrintThread()
        {
            try
            {
                serialPrinThread = new Thread(new ThreadStart(SerialPrintThread));
                serialPrinThread.Start();

                SafeFireLoging("同步打印线程开启成功，当接请求需要同步打印时系统将请求接受顺序打印！");
            }
            catch (Exception e)
            {
                SafeFireLoging("同步打印线程开启失败，当前不支持顺序打印！");
            }
        }

        private string OnPrintRequestReceived(HttpRequest request, string jsonBody)
        {
            try
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(PrintWithThread), request);
                SafeFireLoging("添加任务成功");
                return "打印服务器已接受请求";
            }
            catch (Exception)
            {

                return "添加任务失败！";
            }
        }

        private void PrintWithThread(object objectPara)
        {
            try
            {
                this.totalDocument++;
                HttpRequest httpRequest = objectPara as HttpRequest;
                if (httpRequest != null)
                {
                    PrintModel model = ModelMaper.GetPrintModel(httpRequest.Body);
                    if (model.print_interval <= 0)
                    {
                        //同步乱序打印
                        DoPrintJobWithModel(model);
                    }
                    else
                    {
                        DoPrintJonWithModelSerial(model);
                    }
                }
                else
                {
                    SafeFireLoging("当前传递的参数不正确,当前传入的参数类型为:" + typeof(object).Name);
                }
            }
            catch (Exception ex)
            {
                SafeFireLoging("打印文件失败:" + ex.Message);
            }
            SafeFirsStatistics();
        }

        ManualResetEvent printEvent = new ManualResetEvent(false);

        private void SerialPrintThread()
        {
            while (true && !this._requestStop)
            {
                PrintModel nextModl = ModelMaper.PopAJob();
                if (nextModl != null)
                {
                    DoPrintJobWithModel(nextModl);
                    Thread.Sleep(nextModl.print_interval * 1000);
                }
                else
                {
                    printEvent.WaitOne();
                }
            }
        }

        public void StopSerialPrint()
        {
            printEvent.Set();
        }

        private void DoPrintJobWithModel(PrintModel model)
        {
            string filePath = model.GenerateFile();

            string shortFile = Path.GetFileName(filePath);
            SafeFireLoging("文件生成成功：" + shortFile);

            if (this.PrintNow)
            {
                if (!string.IsNullOrEmpty(this.selectedPrinterName))
                {
                    PrintFile(filePath);
                    SafeFireLoging("已发送到打印机：" + shortFile);
                }
                else
                {
                    SafeFireLoging("当前尚未选择打印机, 请选择打印机或者点击查看文件");
                }
            }
            else
            {
                SafeFireLoging("文件未发送到打印机，您选择仅生成文件");
            }
        }

        private void DoPrintJonWithModelSerial(PrintModel model)
        {
            ModelMaper.AddJob(model);
            printEvent.Set();
        }

        /// <summary>
        /// 开启流程
        /// </summary>
        public void StartProcess()
        {
            this.LoadPrinters();
            this.StartServer();
        }

        private void SafeFireLoging(string message)
        {
            try
            {
                message = DateTime.Now.ToString() + ": "+ message;
                OnPrintServerLogged?.Invoke(message);
            }
            catch (Exception ex)
            {
            }
        }


        private void SafeFirsStatistics()
        {
            try
            {
                OnStatisticsStateChanged?.Invoke(this.Total, this.Succeed, this.Error);
            }
            catch (Exception ex)
            {
                SafeFireLoging("更新统计信息失败："+ ex.Message);
            }
        }

        public void SelectPrinter(string printerName)
        {
            if (this.availablePrinterNames.Contains(printerName) && !string.IsNullOrEmpty(printerName))
            {
                this.selectedPrinterName = printerName;
                OnPrinterChanged?.Invoke(this.selectedPrinterName);
                
                SafeFireLoging("打印机被选中" + printerName + " 已写入配置文件，下次启动将使用此打印机");
                WritPrinterName(printerName);
            }
            else
            {
                SafeFireLoging("无效打印机名称");
            }
        }

        private void PrintFile(string shortFile)
        {
            try
            {
                this.OpenFile(shortFile);
                this.succeedDocument ++;
            }
            catch (Exception ex)
            {
                this.SafeFireLoging("打印时出现未知错误，请联系管理员" + ex.Message);
                this.errorDocument ++;
            }

            this.SafeFirsStatistics();
        }

        public void PrintFile(List<string> files)
        {
            foreach (string file in files)
            {
                this.PrintFile(file);
            }
        }

        

        private string ReadPrinterName()
        {
            string file = System.Windows.Forms.Application.ExecutablePath;
            Configuration config = ConfigurationManager.OpenExeConfiguration(file);
            foreach (string key in config.AppSettings.Settings.AllKeys)
            {
                if (key == ConfKeyName)
                {
                    return config.AppSettings.Settings[key].Value.ToString();
                }
            }
            return null;
        }

        private string ConfKeyName = "SelectedPrinterName";

        private void WritPrinterName(string newPrinterName)
        {
            string file = System.Windows.Forms.Application.ExecutablePath;
            Configuration config = ConfigurationManager.OpenExeConfiguration(file);
            bool exist = false;
            foreach (string key in config.AppSettings.Settings.AllKeys)
            {
                if (key == ConfKeyName)
                {
                    exist = true;
                }
            }
            if (exist)
            {
                config.AppSettings.Settings.Remove(ConfKeyName);
            }
            config.AppSettings.Settings.Add(ConfKeyName, newPrinterName);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void OpenFile(string shortFile)
        {
            try
            {
                ProcessStartInfo info = new ProcessStartInfo();
                info.Verb = "print";
                Process p = new Process();
                info.FileName = shortFile;
                info.CreateNoWindow = true;

                //p.StartInfo.RedirectStandardInput = true;//重定向标准输入  
                //p.StartInfo.RedirectStandardOutput = true;//重定向标准输出  
                //p.StartInfo.RedirectStandardError = true;//重定向错误输出  

                p.StartInfo.Arguments = this.selectedPrinterName;
                info.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo = info;
                p.Start();
                p.WaitForInputIdle();
                //File.Delete(shortFile);
            }
            catch (Win32Exception win32Exception)
            {
                this.SafeFireLoging("打印失败,请安装PDF打开软件并设为默认"+ win32Exception.Message);
                throw;
            }
            
        }

    }
}
