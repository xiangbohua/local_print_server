using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReportTemplates.Transport;

namespace ReportTemplates.Models
{
    public class AfterServicePickUpOrderModel : PrintModel
    { 
        public string title { get; set; }
        public string delivery_no { get; set; }
        public int dealer_order_id { get; set; }
        public int waybill_sort { get; set; }
        public string created { get; set; }
        public string related_no { get; set; }
        public string waybill_no { get; set; }
        public string location_prefix { get; set; }
        public string location_address { get; set; }
        public string type { get; set; }
        public string location_consignee { get; set; }
        public string location_consignee_mobile { get; set; }
        public string detrusion_no { get; set; }
        public string sys_order { get; set; }
        public int box_count { get; set; }
        public string pay_money { get; set; }
        public string remark { get; set; }
        public int print_interval { get; set; }
        public override string GenerateFile()
        {
            AfterServicePickUpOrder print = new AfterServicePickUpOrder();
            print.SetDateSource(this);
            return this.ExportPdf(print);
        }

        public Aitem[] aitem { get; set; }
    }

    public class Aitem
    {
        public string code { get; set; }
        public string name { get; set; }
        public string unit { get; set; }
        public int qty { get; set; }
    }

}
