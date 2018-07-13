namespace RuiguCrmReports.Supplier
{
    partial class OuterPackageLabel
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            this.detail = new Telerik.Reporting.DetailSection();
            this.shape1 = new Telerik.Reporting.Shape();
            this.txtProductName = new Telerik.Reporting.TextBox();
            this.txtProductCode = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.txtModel = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.txtSpec = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(3D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.shape1,
            this.txtProductName,
            this.txtProductCode,
            this.textBox5,
            this.textBox2,
            this.txtModel,
            this.textBox3,
            this.txtSpec});
            this.detail.Name = "detail";
            this.detail.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(0D);
            // 
            // shape1
            // 
            this.shape1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.099999949336051941D), Telerik.Reporting.Drawing.Unit.Cm(0.1000000536441803D));
            this.shape1.Name = "shape1";
            this.shape1.ShapeType = new Telerik.Reporting.Drawing.Shapes.PolygonShape(4, 45D, 9);
            this.shape1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8000001907348633D), Telerik.Reporting.Drawing.Unit.Cm(2.7999999523162842D));
            this.shape1.Stretch = true;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.40000015497207642D), Telerik.Reporting.Drawing.Unit.Cm(0.19999997317790985D));
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.2000002861022949D), Telerik.Reporting.Drawing.Unit.Cm(0.40000000596046448D));
            this.txtProductName.Style.Font.Bold = true;
            this.txtProductName.Style.Font.Name = "Microsoft YaHei";
            this.txtProductName.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.txtProductName.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtProductName.Value = "=Fields.I_Name";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.7000001668930054D), Telerik.Reporting.Drawing.Unit.Cm(1.0999997854232788D));
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.9000003337860107D), Telerik.Reporting.Drawing.Unit.Cm(0.39999991655349731D));
            this.txtProductCode.Style.Font.Name = "Microsoft YaHei";
            this.txtProductCode.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.txtProductCode.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtProductCode.Value = "=Fields.Bianma";
            // 
            // textBox5
            // 
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.40000021457672119D), Telerik.Reporting.Drawing.Unit.Cm(1.0999997854232788D));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.4000002145767212D), Telerik.Reporting.Drawing.Unit.Cm(0.39999991655349731D));
            this.textBox5.Style.Font.Name = "Microsoft YaHei";
            this.textBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.textBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox5.Value = "物料编码：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.40000003576278687D), Telerik.Reporting.Drawing.Unit.Cm(1.5999997854232788D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.90000015497207642D), Telerik.Reporting.Drawing.Unit.Cm(0.40000003576278687D));
            this.textBox2.Style.Font.Name = "Microsoft YaHei";
            this.textBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.textBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox2.Value = "型号：";
            // 
            // txtModel
            // 
            this.txtModel.CanGrow = true;
            this.txtModel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.3000000715255737D), Telerik.Reporting.Drawing.Unit.Cm(1.5999997854232788D));
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.3000006675720215D), Telerik.Reporting.Drawing.Unit.Cm(0.39999985694885254D));
            this.txtModel.Style.Font.Name = "Microsoft YaHei";
            this.txtModel.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6D);
            this.txtModel.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtModel.Value = "=Fields.ProductModel";
            // 
            // textBox3
            // 
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.40000003576278687D), Telerik.Reporting.Drawing.Unit.Cm(2.0999999046325684D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.89979994297027588D), Telerik.Reporting.Drawing.Unit.Cm(0.40000003576278687D));
            this.textBox3.Style.Font.Name = "Microsoft YaHei";
            this.textBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.textBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox3.Value = "规格：";
            // 
            // txtSpec
            // 
            this.txtSpec.CanGrow = true;
            this.txtSpec.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.2000001668930054D), Telerik.Reporting.Drawing.Unit.Cm(2.0999999046325684D));
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.3999996185302734D), Telerik.Reporting.Drawing.Unit.Cm(0.3999997079372406D));
            this.txtSpec.Style.Font.Name = "Microsoft YaHei";
            this.txtSpec.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.txtSpec.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.txtSpec.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtSpec.Value = "=Fields.Specification";
            // 
            // OuterPackageLabel
            // 
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.detail});
            this.Name = "ProductMinPackageLabelSmall";
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.PageSettings.PaperSize = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(60D), Telerik.Reporting.Drawing.Unit.Mm(30D));
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1});
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(6D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox txtProductName;
        private Telerik.Reporting.TextBox txtProductCode;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox txtModel;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox txtSpec;
        private Telerik.Reporting.Shape shape1;
    }
}