namespace RuiguCrmReports.ProductLabel
{
    using ReportTemplates.Models;
    using System.Drawing;

    /// <summary>
    /// Summary description for RepairProductLabel.
    /// </summary>
    public partial class ProductPackLabelMidOther : Telerik.Reporting.Report
    {
        public ProductPackLabelMidOther()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public void SetDataSource(ProductPackLabelModel source)
        {
            txtProductCode.Value = source.ProductCode;
            txtProductName.Value = source.ProductName;
            txtQuantity.Value = source.Quantity;
            barcode1.Value = source.QrCodeString;
            if (89 == source.brandId)
            {
                txtProductName.Style.Color = Color.Teal;
            }
        }

    }
}