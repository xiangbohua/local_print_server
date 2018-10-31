using RuiguCrmReports.Properties;

namespace RuiguCrmReports.ProductLabel
{
    using ReportTemplates.Models;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for RepairProductLabel.
    /// </summary>
    public partial class ProductPackLabelMid : Telerik.Reporting.Report
    {
        public ProductPackLabelMid()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            
        }
        public void SetBrandId(int brandId)
        {
            if (89 == brandId)
            {
                txtProductName.Style.Color = Color.Teal;
                pictureBox1.Value = Resource1.logo_89;
            }
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
                pictureBox1.Value = Resource1.logo_89;
            }
        }

    }
}