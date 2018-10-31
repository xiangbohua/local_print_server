using ReportTemplates.Transport;

namespace ReportTemplates.Models
{
    public class AfterSaleLabelModel : PrintModel
    {
        public string order_number { get; set; }
        public string sub_fix { get; set; }
        public string product_name { get; set; }
        public string product_code { get; set; }
        public string waybill_no { get; set; }
        public string uuid { get; set; }
        public string region { get; set; }
        public string qrcode { get; set; }
        public string unit_name { get; set; }
        public string type_name { get; set; }

        public override string GenerateFile()
        {
            PickOrderProductLabel af = new PickOrderProductLabel();
            af.SetDataSource(this);
            return this.ExportPdf(af);
        }
    }
}
