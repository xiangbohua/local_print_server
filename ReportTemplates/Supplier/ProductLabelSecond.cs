using System.Data;

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
    public partial class ProductLabelSecond : Telerik.Reporting.Report
    {
        public ProductLabelSecond()
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
        
    }
}