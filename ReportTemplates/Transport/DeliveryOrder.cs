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

            tRegoin.Value = deliveryOrder.location_prefix;
            tReciver.Value = deliveryOrder.location_consignee;
            tContact.Value = deliveryOrder.location_consignee_mobile;
            tAddress.Value = deliveryOrder.location_address;
            txtDiscount.Value = deliveryOrder.discount.ToString();

            txtDueMoney.Value = (deliveryOrder.total_money - deliveryOrder.discount).ToString();
            txtWaybillNo.Value = deliveryOrder.waybill_no;
            tTotal.Value = deliveryOrder.total_money.ToString();
            bcOrderNumber.Value = deliveryOrder.related_no;
            tSM.Value = deliveryOrder.detrusion_no;
            txtMark.Value = deliveryOrder.mark;

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
                            Volume = i.volume,
                            Weight = i.weight,
                            ProductPrice = i.origin_price,
                            Promotion_Price = i.pro_price,
                            PriceCount = i.total
                        });
            }

            this.table1.DataSource = dataSource;
        }
    }
}