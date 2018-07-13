namespace RuiguCrmReports.ProductLabel
{
    partial class RepairProductLabel
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.Barcodes.QRCodeEncoder qrCodeEncoder1 = new Telerik.Reporting.Barcodes.QRCodeEncoder();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            this.detail = new Telerik.Reporting.DetailSection();
            this.barcode1 = new Telerik.Reporting.Barcode();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.textBox7 = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(3.8000001907348633D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.barcode1,
            this.textBox2,
            this.textBox4,
            this.textBox5,
            this.textBox6,
            this.textBox1,
            this.textBox3,
            this.textBox7});
            this.detail.Name = "detail";
            this.detail.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.detail.Style.Font.Name = "Microsoft YaHei";
            this.detail.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            // 
            // barcode1
            // 
            this.barcode1.Encoder = qrCodeEncoder1;
            this.barcode1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.6999998092651367D), Telerik.Reporting.Drawing.Unit.Cm(0.20000000298023224D));
            this.barcode1.Name = "barcode1";
            this.barcode1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.9000000953674316D), Telerik.Reporting.Drawing.Unit.Cm(2.8000001907348633D));
            this.barcode1.Stretch = true;
            this.barcode1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.barcode1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.barcode1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top;
            this.barcode1.Value = "=QrCodeString";
            // 
            // textBox2
            // 
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.19999989867210388D), Telerik.Reporting.Drawing.Unit.Cm(0.2000001072883606D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.2968664169311523D), Telerik.Reporting.Drawing.Unit.Cm(1.6338540315628052D));
            this.textBox2.Style.Color = System.Drawing.Color.Red;
            this.textBox2.Style.Font.Bold = true;
            this.textBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.textBox2.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.textBox2.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.textBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox2.Value = "=Product_Name";
            // 
            // textBox4
            // 
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633D), Telerik.Reporting.Drawing.Unit.Cm(3D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5999999046325684D), Telerik.Reporting.Drawing.Unit.Cm(0.39999979734420776D));
            this.textBox4.Style.Font.Bold = true;
            this.textBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.textBox4.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.10000000149011612D);
            this.textBox4.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.10000000149011612D);
            this.textBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox4.Value = "=Bianma";
            // 
            // textBox5
            // 
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.5997989177703857D), Telerik.Reporting.Drawing.Unit.Cm(2.6999998092651367D));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6002010107040405D), Telerik.Reporting.Drawing.Unit.Cm(0.39999979734420776D));
            this.textBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6D);
            this.textBox5.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.10000000149011612D);
            this.textBox5.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.10000000149011612D);
            this.textBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox5.Value = "x[装箱数：        ";
            // 
            // textBox6
            // 
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.19999989867210388D), Telerik.Reporting.Drawing.Unit.Cm(2.6999998092651367D));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.69833368062973022D), Telerik.Reporting.Drawing.Unit.Cm(0.39999991655349731D));
            this.textBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6D);
            this.textBox6.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.10000000149011612D);
            this.textBox6.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.textBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox6.Value = "数量:1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.89853364229202271D), Telerik.Reporting.Drawing.Unit.Cm(2.6999998092651367D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.69833368062973022D), Telerik.Reporting.Drawing.Unit.Cm(0.39999991655349731D));
            this.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6D);
            this.textBox1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.10000000149011612D);
            this.textBox1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox1.Value = "=MinUnitName";
            // 
            // textBox3
            // 
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.2002003192901611D), Telerik.Reporting.Drawing.Unit.Cm(2.6999998092651367D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.49980008602142334D), Telerik.Reporting.Drawing.Unit.Cm(0.39999991655349731D));
            this.textBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6D);
            this.textBox3.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.10000000149011612D);
            this.textBox3.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.textBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox3.Value = "=MinUnitName";
            // 
            // textBox7
            // 
            this.textBox7.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.7002003192901611D), Telerik.Reporting.Drawing.Unit.Cm(2.6999998092651367D));
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.39979973435401917D), Telerik.Reporting.Drawing.Unit.Cm(0.39999991655349731D));
            this.textBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6D);
            this.textBox7.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.10000000149011612D);
            this.textBox7.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.textBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox7.Value = "]";
            // 
            // RepairProductLabel
            // 
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.detail});
            this.Name = "RepairProductLabel";
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(1D), Telerik.Reporting.Drawing.Unit.Mm(1D), Telerik.Reporting.Drawing.Unit.Mm(1D), Telerik.Reporting.Drawing.Unit.Mm(1D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.PageSettings.PaperSize = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8D), Telerik.Reporting.Drawing.Unit.Cm(4D));
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1});
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(7.8000001907348633D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.Barcode barcode1;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox textBox7;
    }
}