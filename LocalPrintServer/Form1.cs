using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HttpServer;
using ReportTemplates.Models;

namespace LocalPrintServer
{
    public delegate void UpdateLabelText(Label label, string text);

    public partial class Form1 : System.Windows.Forms.Form
    {
        private LocalPrintServer PrintServer = null;

        private NotifyIcon notifyIcon = null;

        private bool _finalExit = false;

        public Form1()
        {
            InitializeComponent();
            InitialTray();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            PrintServer = LocalPrintServer.Instance();
            PrintServer.OnPrinterLoaded = OnPrinterLoaded;
            PrintServer.OnPrintServerLogged = OnServerLoged;
            PrintServer.OnPrinterChanged = OnPrinterChaned;
            PrintServer.OnStatisticsStateChanged = StatisticsStateChange;

            PrintServer.StartProcess();
        }

        private void SetPrinterNames(List<string> p)
        {
            if (comboxPrinters.InvokeRequired)
            {
                comboxPrinters.Invoke(new PrinterLoaded(SetPrinterNames), p);
            }
            else
            {
                comboxPrinters.DataSource = null;
                comboxPrinters.DataSource = p;
                comboxPrinters.Text = "";
            }
        }

        private void LogToListBox(string log)
        {
            if (listboxLog.InvokeRequired)
            {
                listboxLog.Invoke(new PrintServerLogging(LogToListBox), log);
            }
            else
            {
                listboxLog.Items.Add(log);
            }
        }

        private void OnPrinterLoaded(List<string> printerNames)
        {
            this.SetPrinterNames(printerNames);
        }

        private void OnServerLoged(string log)
        {
            this.LogToListBox(log);
        }

        private void OnPrinterChaned(string newPrinter)
        {
            this.UpdateLabel(txtCurrentPrinter, newPrinter);
        }

        private void UpdateLabel(Label label, string text)
        {
            if (label.InvokeRequired)
            {
                label.Invoke(new UpdateLabelText(UpdateLabel), label, text);
            }
            else
            {
                label.Text = text;
            }
        }

        private void StatisticsStateChange(int total, int succeed, int error)
        {
            UpdateLabel(txtTotal, total.ToString());
            UpdateLabel(txtSucceed, succeed.ToString());
            UpdateLabel(txtError, error.ToString());
        }

        #region 隐藏主窗体
        private void InitialTray()
        {
            //隐藏主窗体  
            this.Hide();

            //实例化一个NotifyIcon对象  
            notifyIcon = new NotifyIcon();
            //托盘图标气泡显示的内容  
            notifyIcon.BalloonTipText = "单击打开窗口";
            //托盘图标显示的内容  
            notifyIcon.Text = "锐锢打印服务器正在后台运行";
            //注意：下面的路径可以是绝对路径、相对路径。但是需要注意的是：文件必须是一个.ico格式  
            notifyIcon.Icon = Properties.Resources.logo;
            //true表示在托盘区可见，false表示在托盘区不可见  
            notifyIcon.Visible = true;
            //气泡显示的时间（单位是毫秒）  
            notifyIcon.ShowBalloonTip(2000);
            notifyIcon.MouseClick += notifyIcon_MouseClick;

            ////设置二级菜单  
            //MenuItem setting1 = new MenuItem("二级菜单1");  
            //MenuItem setting2 = new MenuItem("二级菜单2");  
            //MenuItem setting = new MenuItem("一级菜单", new MenuItem[]{setting1,setting2});  


//            MenuItem reciveNoti = new MenuItem("接收通知");
//            reciveNoti.Click += reciveNoti_Click;

            

            MenuItem exit = new MenuItem("退出");
            exit.Click += new EventHandler(exit_Click);

            ////关联托盘控件  
            //注释的这一行与下一行的区别就是参数不同，setting这个参数是为了实现二级菜单  
            //MenuItem[] childen = new MenuItem[] { setting, help, about, exit };  
            MenuItem[] childen = new MenuItem[] { exit };
            notifyIcon.ContextMenu = new ContextMenu(childen);

            //窗体关闭时触发  
            this.FormClosing += this.Form1_FormClosing;
        }

        

        /// <summary>  
        /// 窗体关闭的单击事件  
        /// </summary>  
        /// <param name="sender"></param>  
        /// <param name="e"></param>  
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_finalExit)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        /// <summary>  
        /// 鼠标单击  
        /// </summary>  
        /// <param name="sender"></param>  
        /// <param name="e"></param>  
        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            //鼠标左键单击  
            if (e.Button == MouseButtons.Left)
            {
                //如果窗体是可见的，那么鼠标左击托盘区图标后，窗体为不可见  
                if (this.Visible == true)
                {
                    this.Visible = false;
                }
                else
                {
                    this.Visible = true;
                    this.Activate();
                }
            }
        }

        /// <summary>  
        /// 退出选项  
        /// </summary>  
        /// <param name="sender"></param>  
        /// <param name="e"></param>  
        private void exit_Click(object sender, EventArgs e)
        {
            //退出程序
            PrintServer.StopServer();
            this._finalExit = true;
            this.Close();
        }
        #endregion

        private void btnSelectPrinter_Click(object sender, EventArgs e)
        {
            if (comboxPrinters.Items.Count > 0)
            {
                string printerName = comboxPrinters.SelectedItem.ToString();
                PrintServer.SelectPrinter(printerName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(PrintModel.FileSavePath))
                {
                    System.Diagnostics.Process.Start("Explorer.exe", PrintModel.FileSavePath);
                }
                else
                {
                    MessageBox.Show("暂无文件", "查看文件");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("打开文件夹失败");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(PrintModel.FileSavePath))
                {
                    Directory.Delete(PrintModel.FileSavePath, true);
                }
                else
                {
                    MessageBox.Show("暂无文件", "清理文件");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("清理文件失败", "清理文件");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            PrintServer.SetPrintNow(rbPrintNow.Checked);
            
        }
    }
}
