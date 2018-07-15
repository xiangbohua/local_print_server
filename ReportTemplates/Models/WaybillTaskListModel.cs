using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportTemplates.Transport;

namespace ReportTemplates.Models
{
    public class WaybillTaskListModel : PrintModel
    {
        public WaybillTaskListItem[] data { get; set; }

        public override string PrintFile()
        {
            WaybillTaskList pp = new WaybillTaskList();
            pp.SetDateSource(this);

            return this.ExportPdf(pp);
        }
    }

    public class WaybillTaskListItem
    {
        public string warehouseName { get; set; }
        public string smOrderId { get; set; }
        public string related_no { get; set; }
        public string reciverName { get; set; }
        public string reg_code { get; set; }
        public string index { get; set; }
        public string box_count { get; set; }

    }
}
