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
    public partial class ExCustomerIntentSmOrder2 : Telerik.Reporting.Report
    {
        public ExCustomerIntentSmOrder2()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public void SetDateSource(RuiguCustomerIntentOrder intentOrder)
        {
            DataSource = intentOrder;
            RuiguOutBoundOrderCollection orders = RuiguOutBoundOrderCollection.GetByCustomerOrderNumber(intentOrder.Order_No);

            tCreated.Value = intentOrder.Created.ToShortDateString();
            txtConsignIndex.Value = intentOrder.Waybill_Sort.ToString();
            tDealerOrder.Value = intentOrder.Order_No;

            tRegoin.Value = intentOrder.Location_Prefix;
            tReciver.Value = intentOrder.Location_Consignee;
            tContact.Value = intentOrder.Location_Consignee_Mobile;
            tAddress.Value = intentOrder.Location_Address;
            txtDiscount.Value = intentOrder.Discount.ToString();
            txtDueMoney.Value = (intentOrder.Total_Money - intentOrder.Discount).ToString();
            txtWaybillNo.Value = intentOrder.Waybill_No;
            tTotal.Value = intentOrder.Total_Money.ToString();
            bcOrderNumber.Value = intentOrder.Order_No;
            //tSM.Value = outboundOrder.SmOrderId;
            


            SmOrderBoxCollection collection = SmOrderBoxCollection.GetByOrderNumber(intentOrder.Order_No);
            if (collection.Count == 0)
            {
                int boxQuantity = 0;
                int otherQuantity = 0;
                foreach (RuiguOutboundOrder outboundOrder in orders)
                {
                    SmOrderBoxInfoCollection orderBoxInfos = outboundOrder.GetSmOrderBoxInfo();
                    if (orderBoxInfos != null)
                    {
                        foreach (SmOrderBoxInfo orderBoxInfo in orderBoxInfos)
                        {
                            if (orderBoxInfo.BoxType == BoxType.Integrated)
                            {
                                boxQuantity++;
                            }
                            else
                            {
                                otherQuantity++;
                            }
                        }
                    }
                }

                string boxInfo = "";
                if (boxQuantity != 0)
                {
                    boxInfo += String.Format("整箱{0}箱", boxQuantity);
                }

                if (otherQuantity != 0)
                {
                    boxInfo += String.Format("拆零{0}件", otherQuantity);
                }
                if (boxQuantity == 0 && otherQuantity == 0)
                    boxInfo = "暂无包装信息";
                txtBoxInfo.Value = boxInfo;

            }
            else
            {
                txtBoxInfo.Value = SmOrderBoxCollection.GetSummeryText(collection);
            }


            List<object> dataSource = new List<object>();
            int index = 1;
            foreach (RuiguOutboundOrder outboundOrder in orders)
            {
                //只导出已发货的订单
                if(outboundOrder.Status != (int)OutboundOrderStatus.GoodsSent && outboundOrder.Status != (int)OutboundOrderStatus.GoodsSending)
                    continue;

                if(outboundOrder.DcWareHouseId != "RG01")
                    continue;

                for (int i = 0; i < outboundOrder.OrderItemCollection.Count; i++)
                {
                    RuiguOutboundOrderItem t = outboundOrder.OrderItemCollection[i];

                    ThinkShop product = ThinkShop.GetByProductCode(t.ProductCode);

                    RuiguCustomerIntentOrderItem orderItem =
                        intentOrder.ItemCustomerCollection.FirstOrDefault<RuiguCustomerIntentOrderItem>(ii => ii.Shop_Id == product.Id);
                    if (orderItem == null || orderItem.Shop_Amount_Min == 0)
                    {
                        continue;
                    }

                    string ProductNumber = t.ProductCode;
                    string ProductName = t.ProductName;
                    string ProductUnit = t.Unit_Name;
                    //购买数量为原始购买数量
                    int MinUnitQuantity = orderItem.Shop_Amount_Min - orderItem.GiftAmountMin;
                    float Volume = product.Product_Volume;
                    float Weight = product.Product_Weight;

                    int rate = orderItem.Shop_Amount_Min/orderItem.Shop_Amount;

                    decimal ProductPrice = Math.Round(orderItem.Price / rate, 2);
                    decimal PriceCount = Math.Round(orderItem.Shop_Amount * orderItem.Promotion_Price, 2);
                    dataSource.Add(
                        new
                        {
                            Index = index ++,
                            ProductNumber,
                            ProductName,
                            ProductUnit,
                            MinUnitQuantity,
                            orderItem.GiftAmountMin,
                            t.DcReportedQty,
                            Volume,
                            Weight,
                            ProductPrice,
                            Promotion_Price = Math.Round(orderItem.Promotion_Price/ rate,2),
                            PriceCount
                        });
                }
            }

            this.table1.DataSource = dataSource;
        }

        public void SetDateSource(DeliveryOrder deliveryOrder)
        {
            DataSource = deliveryOrder;
            RuiguOutBoundOrderCollection orders = RuiguOutBoundOrderCollection.GetByCustomerOrderNumber(deliveryOrder.Related_No);
            RuiguMemberOrder oldOrder = RuiguMemberOrder.GetByOrderNumber(deliveryOrder.Related_No);
            tCreated.Value = deliveryOrder.Created.ToShortDateString();
            txtConsignIndex.Value = deliveryOrder.Waybill_Sort.ToString();

            tDealerOrder.Value = deliveryOrder.Order_No;

            tRegoin.Value = deliveryOrder.Location_Prefix;
            tReciver.Value = deliveryOrder.Location_Consignee;
            tContact.Value = deliveryOrder.Location_Consignee_Mobile;
            tAddress.Value = deliveryOrder.Location_Address;
            txtDiscount.Value = oldOrder.Discount.ToString();

            txtDueMoney.Value = deliveryOrder.Total_Money.ToString();
            txtWaybillNo.Value = deliveryOrder.Waybill_No;
            tTotal.Value = oldOrder.TotalMoney.ToString();
            bcOrderNumber.Value = deliveryOrder.Related_No;
            tSM.Value = orders[0].SmOrderId;

            SmOrderBoxCollection collection = SmOrderBoxCollection.GetByOrderNumber(deliveryOrder.Related_No);
            if (collection.Count == 0)
            {
                int boxQuantity = 0;
                int otherQuantity = 0;
                foreach (RuiguOutboundOrder outboundOrder in orders)
                {
                    SmOrderBoxInfoCollection orderBoxInfos = outboundOrder.GetSmOrderBoxInfo();
                    if (orderBoxInfos != null)
                    {
                        foreach (SmOrderBoxInfo orderBoxInfo in orderBoxInfos)
                        {
                            if (orderBoxInfo.BoxType == BoxType.Integrated)
                            {
                                boxQuantity++;
                            }
                            else
                            {
                                otherQuantity++;
                            }
                        }
                    }
                }

                string boxInfo = "";
                if (boxQuantity != 0)
                {
                    boxInfo += String.Format("整箱{0}箱", boxQuantity);
                }

                if (otherQuantity != 0)
                {
                    boxInfo += String.Format("拆零{0}件", otherQuantity);
                }

                if (boxQuantity == 0 && otherQuantity == 0)
                    boxInfo = "暂无包装信息";
                txtBoxInfo.Value = boxInfo;
            }
            else
            {
                txtBoxInfo.Value = SmOrderBoxCollection.GetSummeryText(collection);
            }
            
            MemberOrderDetailCollection orderDetail = MemberOrderDetailCollection.GetByOrderNumber(deliveryOrder.Related_No);

            List<string> checkCode = new List<string>();
            List<object> dataSource = new List<object>();
            int index = 1;
            foreach (RuiguOutboundOrder outboundOrder in orders)
            {
                if (outboundOrder.DcWareHouseId != "RG01")
                    continue;

                for (int i = 0; i < outboundOrder.OrderItemCollection.Count; i++)
                {
                    RuiguOutboundOrderItem t = outboundOrder.OrderItemCollection[i];

                    ThinkShop product = ThinkShop.GetByProductCode(t.ProductCode);
                    if(checkCode.Contains(t.ProductCode))
                        continue;

                    MemberOrderDetail orderItem =
                        orderDetail.FirstOrDefault<MemberOrderDetail>(ii => ii.ShopId == product.Id);
                    if (orderItem == null || orderItem.ShopAmountMin == 0)
                    {
                        continue;
                    }

                    string ProductNumber = t.ProductCode;
                    string ProductName = t.ProductName;
                    string ProductUnit = t.Unit_Name;
                    //购买数量为原始购买数量
                    int MinUnitQuantity = orderItem.ShopAmountMin - orderItem.GiftAmountMin;
                    float Volume = product.Product_Volume;
                    float Weight = product.Product_Weight;

                    int rate = orderItem.ShopAmountMin / orderItem.ShopAmount;

                    decimal ProductPrice = Math.Round(orderItem.PurchasePrice / rate, 2);
                    decimal PriceCount = Math.Round(orderItem.ShopAmount * orderItem.Promotion_Price, 2);
                    checkCode.Add(ProductNumber);
                    dataSource.Add(
                        new
                        {
                            Index = index++,
                            ProductNumber,
                            ProductName,
                            ProductUnit,
                            MinUnitQuantity,
                            orderItem.GiftAmountMin,
                            t.DcReportedQty,
                            Volume,
                            Weight,
                            ProductPrice,
                            Promotion_Price = Math.Round(orderItem.Promotion_Price / rate, 2),
                            PriceCount
                        });
                }
            }

            this.table1.DataSource = dataSource;


        }

    }
}