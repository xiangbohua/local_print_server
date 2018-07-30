using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReportTemplates.Models
{

    public class DeliveryOrderModel
    {
        public string delivery_no { get; set; }
        public int dealer_order_id { get; set; }
        public int waybill_sort { get; set; }
        public string waybill_no { get; set; }
        public string created { get; set; }
        public string related_no { get; set; }
        public string location_prefix { get; set; }
        public string location_address { get; set; }
        public string type { get; set; }
        public string location_consignee { get; set; }
        public string location_consignee_mobile { get; set; }
        public string detrusion_no { get; set; }
        public int box_count { get; set; }
        public int print_interval { get; set; }
        public string total_money { get; set; }
        public string discount { get; set; }
        public dItem[] item { get; set; }
    }

    public class dItem
    {
        public string order_number { get; set; }
        public string code { get; set; }
        public string product_name { get; set; }
        public string unit { get; set; }
        public int buy_qty { get; set; }
        public string volume { get; set; }
        public string weight { get; set; }
        public string origin_price { get; set; }
        public string pro_price { get; set; }
        public float total { get; set; }
        public int actual { get; set; }
    }

}
