using System.Data;
using RuiguCrmReports.ReportConfiguration;

namespace RuiguCrmReports.Supplier
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for ProductMinPackageLabelSmall.
    /// </summary>
    public partial class ProductMinPackageLabelSmall : Telerik.Reporting.Report, ICustomReportLabel
    {
        public ProductMinPackageLabelSmall()
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
            if (productLength >= 40)
                txtProductName.Style.Font.Size = new Unit(3, UnitType.Point);
            else if (productLength >= 20)
                txtProductName.Style.Font.Size = new Unit(4, UnitType.Point);
            else
                txtProductName.Style.Font.Size = new Unit(5, UnitType.Point);
        }

        public void FitProductSpecFontSize(int stringLength)
        {
            if (stringLength >= 30)
                txtSpec.Style.Font.Size = new Unit(2, UnitType.Point);
            else if(stringLength >= 20)
                txtSpec.Style.Font.Size = new Unit(3, UnitType.Point);
            else txtSpec.Style.Font.Size = new Unit(4, UnitType.Point);
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