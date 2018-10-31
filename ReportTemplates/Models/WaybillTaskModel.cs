using ReportTemplates.Transport;

namespace ReportTemplates.Models
{
    public class WaybillTaskModel : PrintModel
    {
        public string order_number { get; set; }
        public Item[] data { get; set; }
        public override string GenerateFile()
        {
            WaybillTask pp = new WaybillTask();
            pp.SetDateSource(this);

            return this.ExportPdf(pp);
        }
        
    }

    public class Item
    {
        public string type { get; set; }
        public string related_no { get; set; }
        public string location_prefix { get; set; }
        public string location_address { get; set; }
        public string location_consignee { get; set; }
        public string location_consignee_mobile { get; set; }
        public int waybill_sort { get; set; }
        public int box_count { get; set; }
        public string name { get; set; }
        public string remark { get; set; }
    }

}


