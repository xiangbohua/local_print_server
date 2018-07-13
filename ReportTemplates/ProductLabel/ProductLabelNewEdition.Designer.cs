namespace RuiguCrmReports.ProductLabel
{
    partial class ProductLabelNewEdition
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductLabelNewEdition));
            Telerik.Reporting.Barcodes.QRCodeEncoder qrCodeEncoder1 = new Telerik.Reporting.Barcodes.QRCodeEncoder();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            this.detail = new Telerik.Reporting.DetailSection();
            this.shape1 = new Telerik.Reporting.Shape();
            this.pictureBox2 = new Telerik.Reporting.PictureBox();
            this.barcode1 = new Telerik.Reporting.Barcode();
            this.txtProductCode = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.txtModel = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.txtQty = new Telerik.Reporting.TextBox();
            this.txtProductName = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(2.9000000953674316D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.shape1,
            this.pictureBox2,
            this.barcode1,
            this.txtProductCode,
            this.textBox5,
            this.textBox2,
            this.txtModel,
            this.textBox4,
            this.txtQty,
            this.txtProductName,
            this.textBox1,
            this.textBox6});
            this.detail.Name = "detail";
            this.detail.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(0D);
            // 
            // shape1
            // 
            this.shape1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.029999999329447746D), Telerik.Reporting.Drawing.Unit.Cm(0.05000000074505806D));
            this.shape1.Name = "shape1";
            this.shape1.ShapeType = new Telerik.Reporting.Drawing.Shapes.PolygonShape(4, 45D, 9);
            this.shape1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.75D), Telerik.Reporting.Drawing.Unit.Cm(2.5999999046325684D));
            this.shape1.Stretch = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.7000000476837158D), Telerik.Reporting.Drawing.Unit.Cm(0.088541686534881592D));
            this.pictureBox2.MimeType = "image/png";
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.8807361125946045D), Telerik.Reporting.Drawing.Unit.Cm(0.57125860452651978D));
            this.pictureBox2.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional;
            this.pictureBox2.Value = ((object)(resources.GetObject("pictureBox2.Value")));
            // 
            // barcode1
            // 
            this.barcode1.Encoder = qrCodeEncoder1;
            this.barcode1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.5560002326965332D), Telerik.Reporting.Drawing.Unit.Cm(0.64205563068389893D));
            this.barcode1.Name = "barcode1";
            this.barcode1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0247364044189453D), Telerik.Reporting.Drawing.Unit.Cm(1.8979442119598389D));
            this.barcode1.Stretch = true;
            this.barcode1.Value = "=Fields.QrCode";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.399999737739563D), Telerik.Reporting.Drawing.Unit.Cm(0.64205557107925415D));
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9999995231628418D), Telerik.Reporting.Drawing.Unit.Cm(0.39999991655349731D));
            this.txtProductCode.Style.Font.Name = "Microsoft YaHei";
            this.txtProductCode.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.txtProductCode.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtProductCode.Value = "=Fields.ProductCode";
            // 
            // textBox5
            // 
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612D), Telerik.Reporting.Drawing.Unit.Cm(0.64205557107925415D));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.4000002145767212D), Telerik.Reporting.Drawing.Unit.Cm(0.39999991655349731D));
            this.textBox5.Style.Font.Name = "Microsoft YaHei";
            this.textBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.textBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox5.Value = "商品编码:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.099999949336051941D), Telerik.Reporting.Drawing.Unit.Cm(1.1622002124786377D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.90000015497207642D), Telerik.Reporting.Drawing.Unit.Cm(0.40000003576278687D));
            this.textBox2.Style.Font.Name = "Microsoft YaHei";
            this.textBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.textBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox2.Value = "型号:";
            // 
            // txtModel
            // 
            this.txtModel.CanGrow = true;
            this.txtModel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1D), Telerik.Reporting.Drawing.Unit.Cm(1.1622002124786377D));
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.3999993801116943D), Telerik.Reporting.Drawing.Unit.Cm(0.39999985694885254D));
            this.txtModel.Style.Font.Name = "Microsoft YaHei";
            this.txtModel.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6D);
            this.txtModel.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.txtModel.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtModel.Value = "=Fields.Model";
            // 
            // textBox4
            // 
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.099999949336051941D), Telerik.Reporting.Drawing.Unit.Cm(2.0582559108734131D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.899800181388855D), Telerik.Reporting.Drawing.Unit.Cm(0.40000003576278687D));
            this.textBox4.Style.Font.Name = "Microsoft YaHei";
            this.textBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.textBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox4.Value = "数量:";
            // 
            // txtQty
            // 
            this.txtQty.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D), Telerik.Reporting.Drawing.Unit.Cm(2.0582559108734131D));
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.3999996185302734D), Telerik.Reporting.Drawing.Unit.Cm(0.40000009536743164D));
            this.txtQty.Style.Font.Name = "Microsoft YaHei";
            this.txtQty.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.txtQty.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.txtQty.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtQty.Value = "=Fields.Quantity";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612D), Telerik.Reporting.Drawing.Unit.Cm(0.09999992698431015D));
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.299999475479126D), Telerik.Reporting.Drawing.Unit.Cm(0.40000000596046448D));
            this.txtProductName.Style.Font.Bold = true;
            this.txtProductName.Style.Font.Name = "Microsoft YaHei";
            this.txtProductName.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.txtProductName.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtProductName.Value = "=Fields.ProductName";
            // 
            // textBox1
            // 
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.084199883043766022D), Telerik.Reporting.Drawing.Unit.Cm(1.6580555438995361D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.91579991579055786D), Telerik.Reporting.Drawing.Unit.Cm(0.40000003576278687D));
            this.textBox1.Style.Font.Name = "Microsoft YaHei";
            this.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox1.Value = "包装:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D), Telerik.Reporting.Drawing.Unit.Cm(1.6580555438995361D));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.3999996185302734D), Telerik.Reporting.Drawing.Unit.Cm(0.40000009536743164D));
            this.textBox6.Style.Font.Name = "Microsoft YaHei";
            this.textBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.textBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox6.Value = "=Fields.Location";
            // 
            // ProductLabelNewEdition
            // 
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.detail});
            this.Name = "ProductMinPackageLabelSmall";
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.PageSettings.PaperSize = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(60D), Telerik.Reporting.Drawing.Unit.Mm(31D));
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1});
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(5.820000171661377D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.PictureBox pictureBox2;
        private Telerik.Reporting.Barcode barcode1;
        private Telerik.Reporting.TextBox txtProductName;
        private Telerik.Reporting.TextBox txtProductCode;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox txtModel;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox txtQty;
        private Telerik.Reporting.Shape shape1;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox6;
    }
}