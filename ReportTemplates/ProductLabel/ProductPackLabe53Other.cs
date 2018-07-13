namespace RuiguCrmReports.ProductLabel
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for RepairProductLabel.
    /// </summary>
    public partial class ProductPackLabe53Other : Telerik.Reporting.Report
    {
        public ProductPackLabe53Other(PackageLabelDataSource source)
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            txtProductCode.Value = source.ProductCode;
            txtProductName.Value = source.ProductName;
            txtQuantity.Value = source.Quantity;
            barcode1.Value = source.QrCodeString;
            
        }


    }
}