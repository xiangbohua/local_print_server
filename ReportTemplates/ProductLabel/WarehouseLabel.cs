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
    public partial class WarehouseLabel : Telerik.Reporting.Report
    {
        public WarehouseLabel(object source)
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            this.DataSource = source;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

    }
}