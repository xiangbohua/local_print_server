using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpServer;
using HTTPServerLib;

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

        private void StartServer(string address = "0.0.0.0")
        {
            string rootPath = Environment.CurrentDirectory;
            ExampleServer server = new ExampleServer(address, this.Port);
            server.SetRoot(rootPath);
            server.OnPostRequestReceived = this.OnPrintRequestReceived;

            server.Logger = new ConsoleLogger();
            server.Start();

            SafeFireLoging("Printer server was running and waiting for print reqest. Using port is "+ this.Port.ToString());
        }


        private string OnPrintRequestReceived(HttpRequest request, string jsonBody)
        {


            return jsonBody;
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
