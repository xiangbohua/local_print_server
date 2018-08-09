namespace ReportTemplates.Transport
{
    partial class PickOrderProductLabel
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.Barcodes.QRCodeEncoder qrCodeEncoder1 = new Telerik.Reporting.Barcodes.QRCodeEncoder();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PickOrderProductLabel));
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            this.detail = new Telerik.Reporting.DetailSection();
            this.shape1 = new Telerik.Reporting.Shape();
            this.barcode1 = new Telerik.Reporting.Barcode();
            this.txtProductCode = new Telerik.Reporting.TextBox();
            this.txtProductName = new Telerik.Reporting.TextBox();
            this.txtWaybill = new Telerik.Reporting.TextBox();
            this.txtPickOrderNumber = new Telerik.Reporting.TextBox();
            this.txtUnitName = new Telerik.Reporting.TextBox();
            this.tUuid = new Telerik.Reporting.TextBox();
            this.txtRegion = new Telerik.Reporting.TextBox();
            this.txtSubFix = new Telerik.Reporting.TextBox();
            this.pictureBox2 = new Telerik.Reporting.PictureBox();
            this.txtTypeName = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(2.9000000953674316D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.shape1,
            this.barcode1,
            this.txtProductCode,
            this.txtProductName,
            this.txtWaybill,
            this.txtPickOrderNumber,
            this.txtUnitName,
            this.tUuid,
            this.txtRegion,
            this.txtSubFix,
            this.pictureBox2,
            this.txtTypeName});
            this.detail.Name = "detail";
            this.detail.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(0D);
            // 
            // shape1
            // 
            this.shape1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0.00010012308484874666D));
            this.shape1.Name = "shape1";
            this.shape1.ShapeType = new Telerik.Reporting.Drawing.Shapes.PolygonShape(4, 45D, 9);
            this.shape1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.96999979019165D), Telerik.Reporting.Drawing.Unit.Cm(2.899899959564209D));
            this.shape1.Stretch = true;
            // 
            // barcode1
            // 
            this.barcode1.Encoder = qrCodeEncoder1;
            this.barcode1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.2000000476837158D), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269D));
            this.barcode1.Name = "barcode1";
            this.barcode1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6999996900558472D), Telerik.Reporting.Drawing.Unit.Cm(1.7000000476837158D));
            this.barcode1.Stretch = true;
            this.barcode1.Value = "=qrcode";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.2000001072883606D), Telerik.Reporting.Drawing.Unit.Cm(1.3000000715255737D));
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.899999737739563D), Telerik.Reporting.Drawing.Unit.Cm(0.29999977350234985D));
            this.txtProductCode.Style.Font.Name = "Microsoft YaHei";
            this.txtProductCode.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6D);
            this.txtProductCode.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.txtProductCode.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtProductCode.Value = "=product_code";
            // 
            // txtProductName
            // 
            this.txtProductName.CanGrow = true;
            this.txtProductName.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.1000000536441803D), Telerik.Reporting.Drawing.Unit.Cm(0.49999994039535522D));
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.099799633026123D), Telerik.Reporting.Drawing.Unit.Cm(0.60000014305114746D));
            this.txtProductName.Style.Font.Name = "Microsoft YaHei";
            this.txtProductName.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6D);
            this.txtProductName.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.txtProductName.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top;
            this.txtProductName.Value = "=product_name";
            // 
            // txtWaybill
            // 
            this.txtWaybill.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.20000004768371582D), Telerik.Reporting.Drawing.Unit.Cm(2D));
            this.txtWaybill.Name = "txtWaybill";
            this.txtWaybill.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.9000000953674316D), Telerik.Reporting.Drawing.Unit.Cm(0.30000013113021851D));
            this.txtWaybill.Style.Font.Name = "Microsoft YaHei";
            this.txtWaybill.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.txtWaybill.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.txtWaybill.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtWaybill.Value = "=waybill_no";
            // 
            // txtPickOrderNumber
            // 
            this.txtPickOrderNumber.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612D), Telerik.Reporting.Drawing.Unit.Cm(0.099999949336051941D));
            this.txtPickOrderNumber.Name = "txtPickOrderNumber";
            this.txtPickOrderNumber.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.2999999523162842D), Telerik.Reporting.Drawing.Unit.Cm(0.40000000596046448D));
            this.txtPickOrderNumber.Style.Font.Bold = true;
            this.txtPickOrderNumber.Style.Font.Name = "Microsoft YaHei";
            this.txtPickOrderNumber.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.txtPickOrderNumber.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtPickOrderNumber.Value = "=order_number";
            // 
            // txtUnitName
            // 
            this.txtUnitName.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.20000015199184418D), Telerik.Reporting.Drawing.Unit.Cm(1.6999999284744263D));
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.9000000953674316D), Telerik.Reporting.Drawing.Unit.Cm(0.20000018179416657D));
            this.txtUnitName.Style.Font.Name = "Microsoft YaHei";
            this.txtUnitName.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6D);
            this.txtUnitName.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.txtUnitName.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtUnitName.Value = "=unit_name";
            // 
            // tUuid
            // 
            this.tUuid.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.20000015199184418D), Telerik.Reporting.Drawing.Unit.Cm(2.4000000953674316D));
            this.tUuid.Name = "tUuid";
            this.tUuid.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.90000057220459D), Telerik.Reporting.Drawing.Unit.Cm(0.29999974370002747D));
            this.tUuid.Style.Font.Name = "Microsoft YaHei";
            this.tUuid.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.tUuid.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.tUuid.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.tUuid.Value = "=uuid";
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.2000000476837158D), Telerik.Reporting.Drawing.Unit.Cm(2.3002002239227295D));
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6999993324279785D), Telerik.Reporting.Drawing.Unit.Cm(0.29999974370002747D));
            this.txtRegion.Style.Font.Name = "Microsoft YaHei";
            this.txtRegion.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.txtRegion.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.txtRegion.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtRegion.Value = "=region";
            // 
            // txtSubFix
            // 
            this.txtSubFix.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.5999999046325684D), Telerik.Reporting.Drawing.Unit.Cm(0.099999986588954926D));
            this.txtSubFix.Name = "txtSubFix";
            this.txtSubFix.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.7797996997833252D), Telerik.Reporting.Drawing.Unit.Cm(0.40000000596046448D));
            this.txtSubFix.Style.Font.Bold = true;
            this.txtSubFix.Style.Font.Name = "Microsoft YaHei";
            this.txtSubFix.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.txtSubFix.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtSubFix.Value = "=sub_fix";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.3002002239227295D), Telerik.Reporting.Drawing.Unit.Cm(0.099999949336051941D));
            this.pictureBox2.MimeType = "image/png";
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.4439997673034668D), Telerik.Reporting.Drawing.Unit.Cm(0.5000002384185791D));
            this.pictureBox2.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional;
            this.pictureBox2.Value = ((object)(resources.GetObject("pictureBox2.Value")));
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.4000000953674316D), Telerik.Reporting.Drawing.Unit.Cm(1.3000001907348633D));
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.79980003833770752D), Telerik.Reporting.Drawing.Unit.Cm(0.29999977350234985D));
            this.txtTypeName.Style.Font.Name = "Microsoft YaHei";
            this.txtTypeName.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6D);
            this.txtTypeName.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.txtTypeName.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtTypeName.Value = "=type_name";
            // 
            // PickOrderProductLabel
            // 
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.detail});
            this.Name = "ProductMinPackageLabelSmall";
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.PageSettings.PaperSize = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(50D), Telerik.Reporting.Drawing.Unit.Mm(30D));
            this.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1});
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(5.0322914123535156D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.Barcode barcode1;
        private Telerik.Reporting.TextBox txtPickOrderNumber;
        private Telerik.Reporting.TextBox txtProductCode;
        private Telerik.Reporting.TextBox txtProductName;
        private Telerik.Reporting.TextBox txtWaybill;
        private Telerik.Reporting.Shape shape1;
        private Telerik.Reporting.TextBox txtUnitName;
        private Telerik.Reporting.TextBox tUuid;
        private Telerik.Reporting.TextBox txtRegion;
        private Telerik.Reporting.TextBox txtSubFix;
        private Telerik.Reporting.PictureBox pictureBox2;
        private Telerik.Reporting.TextBox txtTypeName;
    }
}