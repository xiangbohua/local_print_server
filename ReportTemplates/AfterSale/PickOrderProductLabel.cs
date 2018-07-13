using System.Data;
using Ruigu.Crm.BL.IntentOrder;
using Ruigu.Crm.BL.Sale;
using RuiguCrmReports.ReportConfiguration;
using Telerik.Reporting;
using Telerik.Reporting.Drawing;

namespace RuiguCrmReports.AfterSale
{
    /// <summary>
    /// Summary description for ProductMinPackageLabelSmall.
    /// </summary>
    public partial class PickOrderProductLabel : Report
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

        public void SetDataSource(object dataSource)
        {
            this.DataSource = dataSource;
        }
    }
}