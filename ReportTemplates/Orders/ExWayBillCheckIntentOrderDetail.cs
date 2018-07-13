using System.Collections.Generic;
using Ruigu.Crm.BL.IntentOrder;
using Ruigu.Crm.BL.Think;
using Ruigu.Crm.BL.Transport;
using Ruigu.Crm.BL.WorkFlows;
using Zangar.Framework.DataUI;

namespace RuiguCrmReports.Orders
{
    using System;

    /// <summary>
    /// Summary description for ExSupplierOrderItem.
    /// </summary>
    public partial class ExWayBillCheckIntentOrderDetail : Telerik.Reporting.Report
    {
        public ExWayBillCheckIntentOrderDetail(List<ITransportableOrder> detail)
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            List<object> dataSource = new List<object>();
            for (int i = 0; i < detail.Count; i++)
            {
                ITransportableOrder order = detail[i];
                dataSource.Add(
                    new
                    {
                        Index = i + 1,
                        order.Location_Consignee,
                        order.Order_No,
                        order.Total_Money,
                        order.Total_Money_Final,
                        order.OrderTypeString,
                        order.Remark
                    });

                
            }

            this.table1.DataSource = dataSource;
        }
        
    }

}