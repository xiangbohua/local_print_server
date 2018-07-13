using System.Data;
using System.Drawing.Printing;
using RuiguCrmReports.ReportConfiguration;

namespace RuiguCrmReports.ProductLabel
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for ProductMinPackageLabelSmall.
    /// </summary>
    public partial class ProductLabelNewEdition : Report, ICustomReportLabel, IReportDocument
    {
        public ProductLabelNewEdition()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public void SetDataSource(DataTable dt)
        {
            ObjectDataSource objectDataSource = new ObjectDataSource();
            objectDataSource.DataSource = dt;

            this.DataSource = objectDataSource;
        }

        public void FitProductNameFontSize(int productLength)
        {
            if (productLength > 22)
                txtProductName.Style.Font.Size = new Unit(4, UnitType.Point);
            else
                txtProductName.Style.Font.Size = new Unit(6, UnitType.Point);
        }

        public void FitProductSpecFontSize(int length)
        {
            if (length > 22)
                txtModel.Style.Font.Size = new Unit(4, UnitType.Point);
            else
                txtModel.Style.Font.Size = new Unit(6, UnitType.Point);
        }

        public void CustomLebel(LabelSetting labelSetting)
        {
            PageSettings.PaperKind = labelSetting.PaperKind;

            PageSettings.PaperSize = new SizeU(new Unit(labelSetting.PaperWidhtByMm, UnitType.Mm),
                new Unit(labelSetting.PaperHeightByMm, UnitType.Mm));
            PageSettings.ColumnCount = labelSetting.Columns;

            PageSettings.Margins.Bottom = new Unit(labelSetting.MarginBottonByMm, UnitType.Mm);
            PageSettings.Margins.Top = new Unit(labelSetting.MarginTopByMm, UnitType.Mm);
            PageSettings.Margins.Left = new Unit(labelSetting.MarginLeftByMm, UnitType.Mm);
            PageSettings.Margins.Right = new Unit(labelSetting.MarginRightByMm, UnitType.Mm);
            detail.Height = new Unit(30 + labelSetting.RowSpancingByMm, UnitType.Mm);
        }
    }
}