namespace RuiguCrmReports.Supplier
{
    partial class ProductMinPackageLabelSmall
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
            this.shape1 = new Telerik.Reporting.Shape();
            this.barcode1 = new Telerik.Reporting.Barcode();
            this.txtProductName = new Telerik.Reporting.TextBox();
            this.txtProductCode = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.txtModel = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.txtSpec = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.txtQty = new Telerik.Reporting.TextBox();
            this.txtSequence = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(2D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.shape1,
            this.barcode1,
            this.txtProductName,
            this.txtProductCode,
            this.textBox5,
            this.textBox2,
            this.txtModel,
            this.textBox3,
            this.txtSpec,
            this.textBox4,
            this.txtQty,
            this.txtSequence});
            this.detail.Name = "detail";
            this.detail.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(0D);
            // 
            // shape1
            // 
            this.shape1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.05000000074505806D), Telerik.Reporting.Drawing.Unit.Cm(0.05000000074505806D));
            this.shape1.Name = "shape1";
            this.shape1.ShapeType = new Telerik.Reporting.Drawing.Shapes.PolygonShape(4, 45D, 9);
            this.shape1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.9000000953674316D), Telerik.Reporting.Drawing.Unit.Cm(1.8999999761581421D));
            this.shape1.Stretch = true;
            // 
            // barcode1
            // 
            this.barcode1.Encoder = qrCodeEncoder1;
            this.barcode1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.0999999046325684D), Telerik.Reporting.Drawing.Unit.Cm(0.099999956786632538D));
            this.barcode1.Name = "barcode1";
            this.barcode1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.7999999523162842D), Telerik.Reporting.Drawing.Unit.Cm(1.7999998331069946D));
            this.barcode1.Stretch = true;
            this.barcode1.Value = "=Fields.QrCode";
            // 
            // txtProductName
            // 
            this.txtProductName.CanGrow = false;
            this.txtProductName.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.09236115962266922D), Telerik.Reporting.Drawing.Unit.Cm(0.092361122369766235D));
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9499999284744263D), Telerik.Reporting.Drawing.Unit.Cm(0.299999862909317D));
            this.txtProductName.Style.Font.Bold = true;
            this.txtProductName.Style.Font.Name = "Microsoft YaHei";
            this.txtProductName.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(4D);
            this.txtProductName.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.txtProductName.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.txtProductName.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtProductName.Value = "=Fields.ProductName";
            // 
            // txtProductCode
            // 
            this.txtProductCode.CanGrow = false;
            this.txtProductCode.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1D), Telerik.Reporting.Drawing.Unit.Cm(0.759027898311615D));
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.130902886390686D), Telerik.Reporting.Drawing.Unit.Cm(0.19980010390281677D));
            this.txtProductCode.Style.Font.Name = "Microsoft YaHei";
            this.txtProductCode.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(5D);
            this.txtProductCode.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.txtProductCode.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.txtProductCode.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtProductCode.Value = "=Fields.ProductCode";
            // 
            // textBox5
            // 
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.092361122369766235D), Telerik.Reporting.Drawing.Unit.Cm(0.759027898311615D));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.90763896703720093D), Telerik.Reporting.Drawing.Unit.Cm(0.19980010390281677D));
            this.textBox5.Style.Font.Name = "Microsoft YaHei";
            this.textBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(4D);
            this.textBox5.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.textBox5.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.textBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox5.Value = "物料编码：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.092361122369766235D), Telerik.Reporting.Drawing.Unit.Cm(1.0256943702697754D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.81087678670883179D), Telerik.Reporting.Drawing.Unit.Cm(0.19980031251907349D));
            this.textBox2.Style.Font.Name = "Microsoft YaHei";
            this.textBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(4D);
            this.textBox2.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.textBox2.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.textBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox2.Value = "型号：";
            // 
            // txtModel
            // 
            this.txtModel.CanGrow = false;
            this.txtModel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.892361044883728D), Telerik.Reporting.Drawing.Unit.Cm(1.0256943702697754D));
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.2385420799255371D), Telerik.Reporting.Drawing.Unit.Cm(0.19980010390281677D));
            this.txtModel.Style.Font.Name = "Microsoft YaHei";
            this.txtModel.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(5D);
            this.txtModel.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.txtModel.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.txtModel.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtModel.Value = "=Fields.Model";
            // 
            // textBox3
            // 
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.09236115962266922D), Telerik.Reporting.Drawing.Unit.Cm(1.2923613786697388D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.7999998927116394D), Telerik.Reporting.Drawing.Unit.Cm(0.20000013709068298D));
            this.textBox3.Style.Font.Name = "Microsoft YaHei";
            this.textBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(4D);
            this.textBox3.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.textBox3.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.textBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox3.Value = "规格：";
            // 
            // txtSpec
            // 
            this.txtSpec.CanGrow = false;
            this.txtSpec.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.90343773365020752D), Telerik.Reporting.Drawing.Unit.Cm(1.2923613786697388D));
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.2274652719497681D), Telerik.Reporting.Drawing.Unit.Cm(0.20000040531158447D));
            this.txtSpec.Style.Font.Name = "Microsoft YaHei";
            this.txtSpec.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(5D);
            this.txtSpec.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.txtSpec.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.txtSpec.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.txtSpec.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtSpec.Value = "=Fields.Spec";
            // 
            // textBox4
            // 
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.09236115962266922D), Telerik.Reporting.Drawing.Unit.Cm(1.559027910232544D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.79999995231628418D), Telerik.Reporting.Drawing.Unit.Cm(0.19999992847442627D));
            this.textBox4.Style.Font.Name = "Microsoft YaHei";
            this.textBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(4D);
            this.textBox4.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.textBox4.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.textBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox4.Value = "数量：";
            // 
            // txtQty
            // 
            this.txtQty.CanGrow = false;
            this.txtQty.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.89236098527908325D), Telerik.Reporting.Drawing.Unit.Cm(1.5488607883453369D));
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.238541841506958D), Telerik.Reporting.Drawing.Unit.Cm(0.19999979436397553D));
            this.txtQty.Style.Font.Name = "Microsoft YaHei";
            this.txtQty.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(5D);
            this.txtQty.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.txtQty.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.txtQty.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.txtQty.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtQty.Value = "=Fields.Quantity";
            // 
            // txtSequence
            // 
            this.txtSequence.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.15902778506278992D), Telerik.Reporting.Drawing.Unit.Cm(0.49236112833023071D));
            this.txtSequence.Name = "txtSequence";
            this.txtSequence.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.4999997615814209D), Telerik.Reporting.Drawing.Unit.Cm(0.1999998539686203D));
            this.txtSequence.Style.Font.Bold = false;
            this.txtSequence.Style.Font.Name = "Microsoft YaHei";
            this.txtSequence.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(5D);
            this.txtSequence.Style.Font.Underline = true;
            this.txtSequence.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtSequence.Value = "=Fields.Sequence";
            // 
            // ProductMinPackageLabelSmall
            // 
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.detail});
            this.Name = "ProductMinPackageLabelSmall";
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.PageSettings.PaperSize = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(40D), Telerik.Reporting.Drawing.Unit.Mm(20D));
            this.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1});
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(4D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.Barcode barcode1;
        private Telerik.Reporting.TextBox txtProductName;
        private Telerik.Reporting.TextBox txtProductCode;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox txtModel;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox txtSpec;
        private Telerik.Reporting.Shape shape1;
        private Telerik.Reporting.TextBox txtSequence;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox txtQty;
    }
}