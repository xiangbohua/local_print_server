namespace RuiguCrmReports.ProductLabel
{
    partial class ProductPackLabe53Other
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
            this.txtProductName = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.txtQuantity = new Telerik.Reporting.TextBox();
            this.txtProductCode = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(3D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.barcode1,
            this.txtProductName,
            this.textBox6,
            this.txtQuantity,
            this.txtProductCode,
            this.textBox3,
            this.textBox2,
            this.textBox1});
            this.detail.Name = "detail";
            this.detail.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.detail.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.detail.Style.Font.Name = "Microsoft YaHei";
            this.detail.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            // 
            // barcode1
            // 
            this.barcode1.Encoder = qrCodeEncoder1;
            this.barcode1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.8000001907348633D), Telerik.Reporting.Drawing.Unit.Cm(0.099999949336051941D));
            this.barcode1.Name = "barcode1";
            this.barcode1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1995997428894043D), Telerik.Reporting.Drawing.Unit.Cm(2.1652660369873047D));
            this.barcode1.Stretch = true;
            this.barcode1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.barcode1.Style.Font.Strikeout = false;
            this.barcode1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.barcode1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top;
            this.barcode1.Value = "=QrCodeString";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.30000004172325134D), Telerik.Reporting.Drawing.Unit.Cm(0.2000001072883606D));
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4997999668121338D), Telerik.Reporting.Drawing.Unit.Cm(1.5999993085861206D));
            this.txtProductName.Style.Color = System.Drawing.Color.Red;
            this.txtProductName.Style.Font.Bold = true;
            this.txtProductName.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.txtProductName.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.10000000149011612D);
            this.txtProductName.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.10000000149011612D);
            this.txtProductName.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Cm(0D);
            this.txtProductName.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Justify;
            this.txtProductName.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top;
            this.txtProductName.Value = "=ProductName";
            // 
            // textBox6
            // 
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.30000004172325134D), Telerik.Reporting.Drawing.Unit.Cm(2.2999999523162842D));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.599999725818634D), Telerik.Reporting.Drawing.Unit.Cm(0.29999974370002747D));
            this.textBox6.Style.Font.Bold = false;
            this.textBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.textBox6.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.textBox6.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.textBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox6.Value = "数量:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.1000000238418579D), Telerik.Reporting.Drawing.Unit.Cm(2.2999999523162842D));
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.79999995231628418D), Telerik.Reporting.Drawing.Unit.Cm(0.29999962449073792D));
            this.txtQuantity.Style.Font.Bold = false;
            this.txtQuantity.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.txtQuantity.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.10000000149011612D);
            this.txtQuantity.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.10000000149011612D);
            this.txtQuantity.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.txtQuantity.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtQuantity.Value = "=Quantity";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.8000001907348633D), Telerik.Reporting.Drawing.Unit.Cm(2.2654659748077393D));
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1996002197265625D), Telerik.Reporting.Drawing.Unit.Cm(0.33453384041786194D));
            this.txtProductCode.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.txtProductCode.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.txtProductCode.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtProductCode.Value = "=ProductCode";
            // 
            // textBox3
            // 
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.0000002384185791D), Telerik.Reporting.Drawing.Unit.Cm(2.2999999523162842D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.69979941844940186D), Telerik.Reporting.Drawing.Unit.Cm(0.29999974370002747D));
            this.textBox3.Style.Font.Bold = false;
            this.textBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.textBox3.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.textBox3.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.textBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox3.Value = "=UnitName";
            // 
            // textBox2
            // 
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D), Telerik.Reporting.Drawing.Unit.Cm(1.900199294090271D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6997997760772705D), Telerik.Reporting.Drawing.Unit.Cm(0.29960057139396667D));
            this.textBox2.Style.Font.Bold = false;
            this.textBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.textBox2.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.10000000149011612D);
            this.textBox2.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.10000000149011612D);
            this.textBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox2.Value = "=ProductModel";
            // 
            // textBox1
            // 
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.30000004172325134D), Telerik.Reporting.Drawing.Unit.Cm(1.900199294090271D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.599999725818634D), Telerik.Reporting.Drawing.Unit.Cm(0.29960069060325623D));
            this.textBox1.Style.Font.Bold = false;
            this.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.textBox1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.textBox1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox1.Value = "型号:";
            // 
            // ProductPackLabe53Other
            // 
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.detail});
            this.Name = "RepairProductLabel";
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.PageSettings.PaperSize = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5D), Telerik.Reporting.Drawing.Unit.Cm(3D));
            this.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1});
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(4.9998998641967773D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.Barcode barcode1;
        private Telerik.Reporting.TextBox txtQuantity;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox txtProductName;
        private Telerik.Reporting.TextBox txtProductCode;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox textBox1;
    }
}