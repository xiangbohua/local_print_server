using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Printing;
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
            this.SafeFireLoging("Printers loaded using printers was :" + availablePrinterNames.Count);
        }

        private ExampleServer HttpServer = null;
        private void StartServer(string address = "0.0.0.0")
        {
            string rootPath = Environment.CurrentDirectory;
            HttpServer = ExampleServer.GetSingleServer(address, this.Port);
            HttpServer.SetRoot(rootPath);
            HttpServer.OnPostRequestReceived = this.OnPrintRequestReceived;

            HttpServer.Logger = new ConsoleLogger();
            HttpServer.Start();
            SafeFireLoging("Printer server was running and waiting for print reqest. Using port is "+ this.Port.ToString());
        }

        public void StopServer()
        {
            try
            {
                HttpServer?.Stop();
                SafeFireLoging("Http server was stopped");
            }
            catch (Exception ex)
            {
                SafeFireLoging("Http server was stopp failed" + ex.Message);
            }
        }

        private string OnPrintRequestReceived(HttpRequest request, string jsonBody)
        {
            try
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(PrintWithThread), request);
                SafeFireLoging("添加打印任务成功");
                return "添加打印任务成功";
            }
            catch (Exception)
            {

                return "添加打印任务失败！";
            }
        }

        private void PrintWithThread(object objectPara)
        {
            try
            {
                HttpRequest httpRequest = objectPara as HttpRequest;
                if (httpRequest != null)
                {
                    PrintModel model = ModelMaper.GetPrintModel(httpRequest.Body);
                    string filePath = model.PrintFile();

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
                SafeFireLoging("Update print statistis infomation error");
            }
        }

        public void SelectPrinter(string printerName)
        {
            if (this.availablePrinterNames.Contains(printerName))
            {
                this.selectedPrinterName = printerName;
                OnPrinterChanged?.Invoke(this.selectedPrinterName);
            }
        }

        private void PrintFile(string fileName)
        {
            this.totalDocument ++;

            try
            {
                this.OpenFile(fileName);
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

        private void OpenFile(string printerName)
        {
            try
            {
                Debug.Print(printerName);
                ProcessStartInfo info = new ProcessStartInfo();
                info.Verb = "print";
                Process p = new Process();
                info.FileName = this.selectedPrinterName;
                info.CreateNoWindow = true;

                //p.StartInfo.RedirectStandardInput = true;//重定向标准输入  
                //p.StartInfo.RedirectStandardOutput = true;//重定向标准输出  
                //p.StartInfo.RedirectStandardError = true;//重定向错误输出  

                p.StartInfo.Arguments = printerName;
                info.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo = info;
                p.Start();
                p.WaitForInputIdle();
            }
            catch (Win32Exception win32Exception)
            {
                this.SafeFireLoging("打印失败,请安装PDF打开软件并设为默认"+ win32Exception.Message);
                throw;
            }
            
        }

    }
}
