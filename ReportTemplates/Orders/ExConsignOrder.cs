using System.Globalization;
using Ruigu.Crm.BL.WarehousingOrder;
using Ruigu.Crm.BL.WorkFlows;

namespace RuiguCrmReports.Orders
{

    /// <summary>
    /// Summary description for ExConsignOrder.
    /// </summary>
    public partial class ExConsignOrder : Telerik.Reporting.Report
    {
        public ExConsignOrder()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public void SetDateSource(RuiguToDcConsignOrder toDcConsignOrder)
        {
            DataSource = toDcConsignOrder;
            SupplierPurchasingOrder purchasingOrder =
                SupplierPurchasingOrder.GetByOrderNumber(toDcConsignOrder.SupplierOrderNumber);
            if (purchasingOrder != null)
            {
                txtConsignor.Value = purchasingOrder.Consignor;
                txtConsignorContcat.Value = purchasingOrder.Consignor_Contcat;
                txtConsignLocation.Value = purchasingOrder.Consign_Location;
                txtTotalAmount.Value = purchasingOrder.Total_Amount.ToString(CultureInfo.InvariantCulture);
                txtCargo.Value = "";
                txtRemark.Value = "";
                txtTime.Value = "Äê        ÔÂ       ÈÕ";
            }
            ExConsignOrderItem itemReport = new ExConsignOrderItem(toDcConsignOrder.ConsignItemCollection)
            {
                Width = subReport1.Width
            };
            subReport1.ReportSource = itemReport;
        }
    }
}