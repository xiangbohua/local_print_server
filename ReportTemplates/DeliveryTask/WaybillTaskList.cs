using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using MySql.Data.MySqlClient;
using Ruigu.Crm.BL.Dc;
using Ruigu.Crm.BL.IntentOrder;
using Ruigu.Crm.BL.OutboundOrder;
using Ruigu.Crm.BL.Transport;
using RuiguCrmReports.Orders;
using Zangar.Framework.Data.MySql;

namespace RuiguCrmReports.DeliveryTask
{

    /// <summary>
    /// Summary description for ExConsignOrder.
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

        public bool SetDateSource(int dcId)
        {

            SqlSearchObject search = SqlSearchObject.New(false);
            search.SqlStatement = @" 
                      select 
                            dd.dc_id,GROUP_CONCAT(smOrderId) as 'smOrderId',
                            related_no,
                            dd.location_consignee as 'reciverName',
														consign_region_code as 'reg_code',
                            CONCAT(SUBSTR(ww.waybill_no FROM 10 FOR 2),
                            SUBSTR(ww.waybill_no FROM 14 FOR 5),'-', dd.waybill_sort)
                            as 'index'
                            FROM ruigu_delivery  dd 
                            INNER JOIN ruigu_consign_waybill ww
                            ON dd.waybill_no = ww.waybill_no
                            INNER JOIN ruigu_to_dc_sm_order ss
                            ON ss.dealerOrderNumber = dd.related_no
                            WHERE dd.dc_id  = @order_dc_id
                            AND dd.type = 'DELIVER_SYSTEM_ORDER'
                            AND ww.waybill_status = 0
                            GROUP BY dealerOrderNumber, dd.location_consignee,dd.dc_id,dd.related_no
                            order by consign_region_code, dd.waybill_no, dd.waybill_sort
                            ";
            search.Parameters.AddInputParameter("order_dc_id", MySqlDbType.Int32, dcId);
            search.Search();

            if (search.SearchResults.Tables[0].Rows.Count == 0)
                return false;

            int splitNo = search.SearchResults.Tables[0].Rows.Count/2;
            List<object> dataSource1 = new List<object>();
            List<object> dataSource2 = new List<object>();
            for (int i = 0; i < search.SearchResults.Tables[0].Rows.Count; i++)
            {
                string membrOrderNumber = search.SearchResults.Tables[0].Rows[i]["related_no"].ToString();
                SmOrderBoxCollection collection = SmOrderBoxCollection.GetByOrderNumber(membrOrderNumber);
                string boxInfo = "";
                if (collection.Count == 0)
                {
                    RuiguOutBoundOrderCollection oo = RuiguOutBoundOrderCollection.GetByCustomerOrderNumber(membrOrderNumber);
                    boxInfo = SmOrderBoxCollection.GetBoxInfoWithApi(oo);
                }
                else
                {
                    boxInfo = SmOrderBoxCollection.GetSummeryText(collection);
                }
                

                object data = new
                {
                    smOrderId = search.SearchResults.Tables[0].Rows[i]["smOrderId"],
                    reciverName = search.SearchResults.Tables[0].Rows[i]["reciverName"],
                    reg_code = search.SearchResults.Tables[0].Rows[i]["reg_code"],
                    index = search.SearchResults.Tables[0].Rows[i]["index"],
                    boxInfo
                };
                if (i < splitNo  + 1)
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
            return true;
        }
    }
}