using System.Collections.Generic;
using ReportTemplates.Models;

namespace ReportTemplates.Transport
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for AfterServicePickUpOrder.
    /// </summary>
    public partial class AfterServicePickUpOrder : Telerik.Reporting.Report
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
        public void SetDateSource(AfterServicePickUpOrderModel deliverOrder)
        {
            lbOrderType.Value = deliverOrder.title;
            txtNeedPay.Value = deliverOrder.pay_money;
            tOrderNumber.Value = deliverOrder.sys_order;
            txtConsignIndex.Value = deliverOrder.waybill_sort.ToString();
            tServicesOrderNo.Value = deliverOrder.related_no;
            tCustomerName.Value = deliverOrder.location_consignee;
            tAddress.Value = deliverOrder.location_prefix + deliverOrder.location_address;
            tWaybillNo.Value = deliverOrder.waybill_no;
            tContact.Value = deliverOrder.location_consignee_mobile;
            txtRemark.Value = deliverOrder.remark;

            txtType.Value = deliverOrder.type;

            List<object> dataSource = new List<object>();
            int index = 1;
            foreach (var orderItem in deliverOrder.data)
            {
                dataSource.Add(new
                {
                    Index = index,
                    Product_Code = orderItem.code,
                    ProductName = orderItem.name,
                    ProductUnit = orderItem.unit,
                    Shop_Amount = orderItem.qty
                });
            }

            this.table1.DataSource = dataSource;
        }
    }
}