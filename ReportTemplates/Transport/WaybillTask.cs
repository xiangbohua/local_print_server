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

            foreach (var o in wayBillOrder.items)
            {
                dataSource.Add(new
                {
                    o.type,
                    o.related_no,
                    o.waybill_sort,
                    o.location_address,
                    o.location_consignee,
                    o.location_consignee_mobile,
                    o.remark,
                    Box_Info = o.box_count,
                    StoreName = o.name
                });
            }

            textBox7.Value = "ÅäËÍ×Üµ¥" + wayBillOrder.order_number;

            table2.DataSource = dataSource;
        }


    }
}