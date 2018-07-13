using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Ruigu.Crm.BL.Dc;
using Ruigu.Crm.BL.IntentOrder;
using Ruigu.Crm.BL.OutboundOrder;
using Ruigu.Crm.BL.Think;
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
    public partial class ExCustomerIntentSmOrder : Telerik.Reporting.Report
    {
        public ExCustomerIntentSmOrder()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public void SetDateSource(RuiguOutboundOrder outboundOrder)
        {
            DataSource = outboundOrder;
            RuiguCustomerIntentOrder intentOrder = RuiguCustomerIntentOrder.GetByOrderNumber(outboundOrder.DealerOrderNumber);
            
            if (outboundOrder != null)
            {
                DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
                long lTime = long.Parse(outboundOrder.CreatedOn + "0000000");
                TimeSpan toNow = new TimeSpan(lTime);

                txtConsignIndex.Value = intentOrder.Waybill_Sort.ToString();
                tCreated.Value = dtStart.Add(toNow).ToString("yyyy-MM-dd");
                tSM.Value = outboundOrder.SmOrderId;
                txtDueMoney.Value = intentOrder.Waybill_No;
                tDealerOrder.Value = outboundOrder.DealerOrderNumber;
                tRegoin.Value = outboundOrder.ReciverProvience + outboundOrder.ReciverRegion;
                tReciver.Value = outboundOrder.ReciverName;
                tContact.Value = outboundOrder.ReciverContact;
                tAddress.Value = outboundOrder.ReciverAddress;
                txtDiscount.Value = intentOrder.Discount.ToString();
                txtDueMoney.Value = (intentOrder.Total_Money - intentOrder.Discount).ToString();
                txtWaybillNo.Value = intentOrder.Waybill_No;
                tTotal.Value = intentOrder.Total_Money.ToString();
                SmOrderBoxInfoCollection boxInfo = outboundOrder.GetSmOrderBoxInfo();

                txtBoxInfo.Value = boxInfo == null ? "暂无信息" : boxInfo.BoxSummeryText;
            }

            List<object> dataSource = new List<object>();

            for (int i = 0; i < outboundOrder.OrderItemCollection.Count; i++)
            {
                RuiguOutboundOrderItem t = outboundOrder.OrderItemCollection[i];

                ThinkShop product = ThinkShop.GetByProductCode(t.ProductCode);

                string ProductNumber = t.ProductCode;
                string ProductName = t.ProductName;
                string ProductUnit = t.Unit_Name;
                int MinUnitQuantity = t.ActualProductQtySend;
                float Volume = product.Product_Volume;
                float Weight = product.Product_Weight;

                RuiguCustomerIntentOrderItem orderItem =
                    intentOrder.ItemCustomerCollection.FirstOrDefault<RuiguCustomerIntentOrderItem>(ii => ii.Shop_Id == product.Id);
                if (orderItem == null)
                {
                    continue;
                }

                decimal ProductPrice = orderItem.Price;
                decimal PriceCount = orderItem.Shop_Amount * orderItem.Price;
                dataSource.Add(
                    new
                    {
                        Index = i + 1,
                        ProductNumber,
                        ProductName,
                        ProductUnit,
                        MinUnitQuantity,
                        t.DcReportedQty,
                        Volume,
                        Weight,
                        ProductPrice,
                        PriceCount
                    });
            }

            this.table1.DataSource = dataSource;
        }

       
    }
}