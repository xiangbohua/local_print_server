using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Ruigu.Crm.BL.Dc;
using Ruigu.Crm.BL.IntentOrder;
using Ruigu.Crm.BL.OutboundOrder;
using Ruigu.Crm.BL.Sale;
using Ruigu.Crm.BL.Think;
using Ruigu.Crm.BL.Transport;
using Ruigu.Crm.BL.WorkFlows;


namespace RuiguCrmReports.Orders
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;                                                

    /// <summary>
    /// Summary description for ExCustomerIntentSmOrder.
    /// </summary>
    public partial class AfterServicePickUpOrder : Report
    {
        public AfterServicePickUpOrder()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public void SetDateSource(DeliveryOrder deliverOrder)
        {
            RuiguAfterSales sale = RuiguAfterSales.GetByNo(deliverOrder.Related_No);

            lbOrderType.Value = deliverOrder.BusinessType;
            txtNeedPay.Value = deliverOrder.Total_Money.ToString();
            tOrderNumber.Value = sale.System_Order_No;
            txtConsignIndex.Value = deliverOrder.Waybill_Sort.ToString();
            tServicesOrderNo.Value = deliverOrder.Related_No;
            tCustomerName.Value = deliverOrder.Location_Consignee;
            tAddress.Value = deliverOrder.Location_Prefix + deliverOrder.Location_Address;
            tWaybillNo.Value = deliverOrder.Waybill_No;
            tContact.Value = deliverOrder.Location_Consignee_Mobile;
            txtRemark.Value = deliverOrder.Remark;

            if (!string.IsNullOrEmpty(deliverOrder.Consume_No))
            {
                RuiguOutboundOrder o = RuiguOutboundOrder.GetByCustomerOrderNumber(deliverOrder.Consume_No);
                txtSmOrder.Value = o == null ? "" : o.RuiguSmOrderId;
            }
            
            string type = "";
            switch (sale.Type)
            {
                case 1:
                    type = "退货";
                    break;
                case 2:
                    type = "换货";
                    break;
                case 3:
                    type = "维修";
                    break;
            }

            if (sale.Repair_Type == 1)
                type += " 仅配件";

            
            txtType.Value = string.IsNullOrEmpty(type)?"": "(" + type + ")";

            List<object> dataSource = new List<object>();
            int index = 1;
            foreach (DeliveryOrderItem orderItem in deliverOrder.Items)
            {
                dataSource.Add(new
                {
                    Index = index,
                    Product_Code = deliverOrder.Items.GetProductInfoById(orderItem.Shop_Id).Bianma,
                    ProductName =  deliverOrder.Items.GetProductInfoById(orderItem.Shop_Id).Product_Name,
                    ProductUnit = orderItem.Unit_Name,
                    orderItem.Shop_Amount
                });
            }

            this.table1.DataSource = dataSource;
        }

       
    }
}