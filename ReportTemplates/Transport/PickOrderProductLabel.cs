using ReportTemplates.Models;

namespace ReportTemplates.Transport
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for PickOrderProductLabel.
    /// </summary>
    public partial class PickOrderProductLabel : Telerik.Reporting.Report
    {
        public PickOrderProductLabel()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }


        public void SetDataSource(AfterSaleLabelModel d)
        {
            txtPickOrderNumber.Value = d.order_number;
            txtProductCode.Value = d.product_code;
            txtProductName.Value = d.product_name;
            txtSubFix.Value = d.sub_fix;
            txtUnitName.Value = d.unit_name;
            txtWaybill.Value = d.waybill_no;
            barcode1.Value = d.qrcode;
            txtRegion.Value = d.region;
            tUuid.Value = d.uuid;

        }
    }
}