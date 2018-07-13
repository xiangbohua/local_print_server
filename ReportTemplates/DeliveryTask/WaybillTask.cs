using System;
using System.Collections.Generic;
using System.Linq;
using Ruigu.Crm.BL.Dc;
using Ruigu.Crm.BL.IntentOrder;
using Ruigu.Crm.BL.OutboundOrder;
using Ruigu.Crm.BL.Sale;
using Ruigu.Crm.BL.Transport;
using RuiguCrmReports.Orders;

namespace RuiguCrmReports.DeliveryTask
{

    /// <summary>
    /// Summary description for ExConsignOrder.
    /// </summary>
    public partial class WaybillTask : Telerik.Reporting.Report
    {
        public WaybillTask()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public void SetDateSource(ConsignWaybill wayBillOrder)
        {
            List<ITransportableOrder> currentOrderItems = TransportableOrderProvider.GetOrdersInWaybill(wayBillOrder.Waybill_No);
            List<int> userIds = new List<int>();
            foreach (ITransportableOrder order in currentOrderItems)
            {
                if(!userIds.Contains(order.User_Id))
                    userIds.Add(order.User_Id);
            }

            GroundSaleMemberInfoCollection storeInfo = GroundSaleMemberInfoCollection.GetByUserIDs(userIds);
            currentOrderItems.Sort(SortOrders);

            List<object> dataSource = new List<object>();

            foreach (ITransportableOrder o in currentOrderItems)
            {
                GroundSaleMemberInfo store = storeInfo.FirstOrDefault<GroundSaleMemberInfo>(oo => oo.User_Id == o.User_Id);
                SmOrderBoxCollection collection = SmOrderBoxCollection.GetByOrderNumber(o.Order_No);
                string boxInfo = "暂无装箱信息";
                if (collection.Count == 0)
                {
                    RuiguOutBoundOrderCollection oo = RuiguOutBoundOrderCollection.GetByCustomerOrderNumber(o.Order_No);
                    boxInfo = SmOrderBoxCollection.GetBoxInfoWithApi(oo);
                }
                else
                {
                    boxInfo = SmOrderBoxCollection.GetSummeryText(collection);
                }
                dataSource.Add(new
                {
                    o.OrderTypeString,
                    o.Order_No,
                    o.Waybill_Sort,
                    o.Location_Address,
                    o.Location_Consignee,
                    o.Location_Consignee_Mobile,
                    o.Remark,
                    Box_Info = boxInfo,
                    StoreName = store== null?"":store.Name
                });
            }

            textBox7.Value = "配送总单" + wayBillOrder.Waybill_No;
            
            table2.DataSource = dataSource;
        }


        
        

        private int SortOrders(ITransportableOrder x, ITransportableOrder y)
        {
            if (x.Waybill_Sort == y.Waybill_Sort)
                return 0;

            return x.Waybill_Sort > y.Waybill_Sort ? 1 : -1;
        }
    }
}