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
    public partial class WaybillTaskList : Telerik.Reporting.Report
    {
        public WaybillTaskList()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public void SetDateSource(WaybillTaskListModel model)
        {

            int splitNo = model.data.Length / 2;
            List<object> dataSource1 = new List<object>();
            List<object> dataSource2 = new List<object>();
            for (int i = 0; i < model.data.Length; i++)
            {
                WaybillTaskListItem item = model.data[i];
                object data = new
                {
                    smOrderId = item.smOrderId,
                    reciverName = item.reciverName,
                    reg_code = item.reg_code,
                    index = item.index,
                    boxInfo = item.box_count
                };
                if (i < splitNo + 1)
                {
                    dataSource1.Add(data);
                }
                else
                {
                    dataSource2.Add(data);
                }
            }

            table1.DataSource = dataSource1;
            table2.DataSource = dataSource2;
        }
        
    }
}