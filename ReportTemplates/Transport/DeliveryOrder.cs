using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ReportTemplates.Models;
using Telerik.Reporting;
using Telerik.Reporting.Drawing;


namespace ReportTemplates.Transport
{
    /// <summary>
    /// Summary description for DeliveryOrder.
    /// </summary>
    public partial class DeliveryOrder : Telerik.Reporting.Report
    {
        public DeliveryOrder()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public void SetDateSource(DeliveryOrderModel deliveryOrder)
        {
            tCreated.Value = deliveryOrder.created;
            txtConsignIndex.Value = deliveryOrder.waybill_sort.ToString();

            tDealerOrder.Value = deliveryOrder.related_no;
            txtBoxInfo.Value = "¹² " + deliveryOrder.box_count + " ¼þ";
            txtDeliveyTip.Value = deliveryOrder.order_tip;

            tRegoin.Value = deliveryOrder.location_prefix;
            tReciver.Value = deliveryOrder.location_consignee;
            tContact.Value = deliveryOrder.location_consignee_mobile;
            tAddress.Value = deliveryOrder.location_address;
            txtPayThisOrderTop.Value = deliveryOrder.pay_money;

            txtPayed.Value = deliveryOrder.paidMoney;
            txtWaybillNo.Value = deliveryOrder.waybill_no;
            tTotal.Value = deliveryOrder.totalMoney.ToString();
            bcOrderNumber.Value = deliveryOrder.detrusion_no;
            tSM.Value = deliveryOrder.detrusion_no;
            txtMark.Value = deliveryOrder.mark;

            txtProductMoney.Value = deliveryOrder.product_total;
            txtOtherDiscount.Value = deliveryOrder.other_discount;
            txtTotalThisOrder.Value = deliveryOrder.total_this_order;
            txtDeliveryFee.Value = deliveryOrder.deliveFee;
            txtCoupon.Value = deliveryOrder.coupon;
            txtPayThisOrder.Value = deliveryOrder.pay_money_string;

            List<object> dataSource = new List<object>();
            int index = 1;
            foreach (var i in deliveryOrder.data)
            {
                dataSource.Add(
                        new
                        {
                            Index = index++,
                            ProductNumber = i.code,
                            ProductName = i.product_name,
                            ProductUnit = i.unit,
                            MinUnitQuantity = i.buy_qty,
                            GiftAmountMin = 0,
                            DcReportedQty = i.actual,
                            ProductPrice = i.price,
                            PriceCount = i.total
                        });
            }

            this.table1.DataSource = dataSource;
        }
    }
}