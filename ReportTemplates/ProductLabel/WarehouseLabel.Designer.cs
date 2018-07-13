namespace RuiguCrmReports.ProductLabel
{
    partial class WarehouseLabel
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.Barcodes.QRCodeEncoder qrCodeEncoder1 = new Telerik.Reporting.Barcodes.QRCodeEncoder();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseLabel));
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            this.detail = new Telerik.Reporting.DetailSection();
            this.barcode1 = new Telerik.Reporting.Barcode();
            this.txtName = new Telerik.Reporting.TextBox();
            this.pictureBox3 = new Telerik.Reporting.PictureBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(16.299999237060547D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.barcode1,
            this.txtName,
            this.pictureBox3,
            this.textBox1,
            this.textBox2});
            this.detail.Name = "detail";
            this.detail.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.detail.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.detail.Style.Font.Name = "Microsoft YaHei";
            this.detail.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            // 
            // barcode1
            // 
            this.barcode1.Encoder = qrCodeEncoder1;
            this.barcode1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4D), Telerik.Reporting.Drawing.Unit.Cm(1.2999999523162842D));
            this.barcode1.Name = "barcode1";
            this.barcode1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.7000007629394531D), Telerik.Reporting.Drawing.Unit.Cm(9.5998992919921875D));
            this.barcode1.Stretch = true;
            this.barcode1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(15D);
            this.barcode1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.barcode1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top;
            this.barcode1.Value = "=QrCodeString";
            // 
            // txtName
            // 
            this.txtName.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.0000004768371582D), Telerik.Reporting.Drawing.Unit.Cm(10D));
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.7000007629394531D), Telerik.Reporting.Drawing.Unit.Cm(1.6000001430511475D));
            this.txtName.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(22D);
            this.txtName.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Cm(0D);
            this.txtName.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0D);
            this.txtName.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.txtName.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtName.Value = "=Code";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.4999990463256836D), Telerik.Reporting.Drawing.Unit.Cm(0.39989966154098511D));
            this.pictureBox3.MimeType = "image/png";
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.3000001907348633D), Telerik.Reporting.Drawing.Unit.Cm(1.8000000715255737D));
            this.pictureBox3.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional;
            this.pictureBox3.Value = ((object)(resources.GetObject("pictureBox3.Value")));
            // 
            // textBox1
            // 
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.8002004623413086D), Telerik.Reporting.Drawing.Unit.Cm(0.39989966154098511D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.2000000476837158D), Telerik.Reporting.Drawing.Unit.Cm(0.89990001916885376D));
            this.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18D);
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox1.Value = "集货";
            // 
            // textBox2
            // 
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.8002004623413086D), Telerik.Reporting.Drawing.Unit.Cm(1.2999997138977051D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.2000000476837158D), Telerik.Reporting.Drawing.Unit.Cm(0.89990001916885376D));
            this.textBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18D);
            this.textBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox2.Value = "库区";
            // 
            // WarehouseLabel
            // 
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.detail});
            this.Name = "RepairProductLabel";
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(1D), Telerik.Reporting.Drawing.Unit.Mm(1D), Telerik.Reporting.Drawing.Unit.Mm(1D), Telerik.Reporting.Drawing.Unit.Mm(1D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1});
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(20.799898147583008D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.Barcode barcode1;
        private Telerik.Reporting.PictureBox pictureBox3;
        private Telerik.Reporting.TextBox txtName;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox2;
    }
}