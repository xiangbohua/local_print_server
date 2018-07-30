namespace LocalPrintServer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listboxLog = new System.Windows.Forms.ListBox();
            this.comboxPrinters = new System.Windows.Forms.ComboBox();
            this.btnSelectPrinter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurrentPrinter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtError = new System.Windows.Forms.Label();
            this.txtSucceed = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPrintManual = new System.Windows.Forms.RadioButton();
            this.rbPrintNow = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listboxLog
            // 
            this.listboxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listboxLog.FormattingEnabled = true;
            this.listboxLog.Location = new System.Drawing.Point(1, 0);
            this.listboxLog.Name = "listboxLog";
            this.listboxLog.Size = new System.Drawing.Size(685, 329);
            this.listboxLog.TabIndex = 0;
            // 
            // comboxPrinters
            // 
            this.comboxPrinters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxPrinters.FormattingEnabled = true;
            this.comboxPrinters.Location = new System.Drawing.Point(394, 341);
            this.comboxPrinters.Name = "comboxPrinters";
            this.comboxPrinters.Size = new System.Drawing.Size(201, 21);
            this.comboxPrinters.TabIndex = 1;
            // 
            // btnSelectPrinter
            // 
            this.btnSelectPrinter.Location = new System.Drawing.Point(597, 340);
            this.btnSelectPrinter.Name = "btnSelectPrinter";
            this.btnSelectPrinter.Size = new System.Drawing.Size(77, 23);
            this.btnSelectPrinter.TabIndex = 2;
            this.btnSelectPrinter.Text = "选择";
            this.btnSelectPrinter.UseVisualStyleBackColor = true;
            this.btnSelectPrinter.Click += new System.EventHandler(this.btnSelectPrinter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "当前打印机：";
            // 
            // txtCurrentPrinter
            // 
            this.txtCurrentPrinter.AutoSize = true;
            this.txtCurrentPrinter.Location = new System.Drawing.Point(93, 345);
            this.txtCurrentPrinter.Name = "txtCurrentPrinter";
            this.txtCurrentPrinter.Size = new System.Drawing.Size(0, 13);
            this.txtCurrentPrinter.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "统计信息";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "收到请求";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "打印成功";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "打印失败";
            // 
            // txtError
            // 
            this.txtError.AutoSize = true;
            this.txtError.Location = new System.Drawing.Point(259, 402);
            this.txtError.Name = "txtError";
            this.txtError.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtError.Size = new System.Drawing.Size(13, 13);
            this.txtError.TabIndex = 12;
            this.txtError.Text = "0";
            this.txtError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSucceed
            // 
            this.txtSucceed.AutoSize = true;
            this.txtSucceed.Location = new System.Drawing.Point(163, 402);
            this.txtSucceed.Name = "txtSucceed";
            this.txtSucceed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSucceed.Size = new System.Drawing.Size(13, 13);
            this.txtSucceed.TabIndex = 11;
            this.txtSucceed.Text = "0";
            this.txtSucceed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Location = new System.Drawing.Point(76, 402);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotal.Size = new System.Drawing.Size(13, 13);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "启动以来";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(597, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "清理文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "可用：";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(520, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "查看文件";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPrintManual);
            this.groupBox1.Controls.Add(this.rbPrintNow);
            this.groupBox1.Location = new System.Drawing.Point(359, 368);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 47);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "打印方式?";
            // 
            // rbPrintManual
            // 
            this.rbPrintManual.AutoSize = true;
            this.rbPrintManual.Location = new System.Drawing.Point(92, 19);
            this.rbPrintManual.Name = "rbPrintManual";
            this.rbPrintManual.Size = new System.Drawing.Size(49, 17);
            this.rbPrintManual.TabIndex = 1;
            this.rbPrintManual.Text = "手动";
            this.rbPrintManual.UseVisualStyleBackColor = true;
            this.rbPrintManual.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbPrintNow
            // 
            this.rbPrintNow.AutoSize = true;
            this.rbPrintNow.Checked = true;
            this.rbPrintNow.Location = new System.Drawing.Point(15, 19);
            this.rbPrintNow.Name = "rbPrintNow";
            this.rbPrintNow.Size = new System.Drawing.Size(49, 17);
            this.rbPrintNow.TabIndex = 0;
            this.rbPrintNow.TabStop = true;
            this.rbPrintNow.Text = "立即";
            this.rbPrintNow.UseVisualStyleBackColor = true;
            this.rbPrintNow.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 446);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboxPrinters);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.txtSucceed);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCurrentPrinter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectPrinter);
            this.Controls.Add(this.listboxLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(702, 485);
            this.Name = "Form1";
            this.Text = "本地打印服务器";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listboxLog;
        private System.Windows.Forms.ComboBox comboxPrinters;
        private System.Windows.Forms.Button btnSelectPrinter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtCurrentPrinter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtError;
        private System.Windows.Forms.Label txtSucceed;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPrintManual;
        private System.Windows.Forms.RadioButton rbPrintNow;
    }
}

