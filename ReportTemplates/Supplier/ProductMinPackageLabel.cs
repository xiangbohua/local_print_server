using System.Data;

namespace RuiguCrmReports.Supplier
{
    using System;
    using System.ComponentModel;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for ProductMinPackageLabelSmall.
    /// </summary>
    public partial class ProductMinPackageLabel : Report
    {
        public ProductMinPackageLabel()
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
            if (productLength > 25)
                txtProductName.Style.Font.Size = new Unit(5, UnitType.Point);
            else
                txtProductName.Style.Font.Size = new Unit(7, UnitType.Point);
        }

        public void FitProductSpecFontSize(int stringLength)
        {
            if (stringLength > 22)
                txtSpec.Style.Font.Size = new Unit(4, UnitType.Point);
            else
                txtSpec.Style.Font.Size = new Unit(6, UnitType.Point);
        }
    }
}