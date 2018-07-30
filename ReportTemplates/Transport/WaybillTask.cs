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
    /// Summary description for Report1.
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

        public void SetDateSource(WaybillTaskModel wayBillOrder)
        {
            List<object> dataSource = new List<object>();

            foreach (var o in wayBillOrder.data)
            {
                dataSource.Add(new
                {
                    OrderTypeString = o.type,
                    Order_NO = o.related_no,
                    Waybill_Sort = o.waybill_sort,
                    Location_Address = o.location_address,
                    Location_Consignee = o.location_consignee,
                    Location_Consignee_Mobile = o.location_consignee_mobile,
                    Remark = o.remark,
                    Box_Info = o.box_count,
                    StoreName = o.name
                });
            }

            textBox7.Value = "ÅäËÍ×Üµ¥" + wayBillOrder.order_number;

            table2.DataSource = dataSource;
        }

        
    }
}