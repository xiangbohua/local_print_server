using System.Linq;
using Ruigu.Crm.BL.IntentOrder;
using Ruigu.Crm.BL.OutboundOrder;
using Ruigu.Crm.BL.Think;

namespace RuiguCrmReports.Orders
{
    
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for ExCustomerIntentSmOrderItem.
    /// </summary>
    public partial class ExCustomerIntentSmOrderItem : Telerik.Reporting.Report
    {
        public ExCustomerIntentSmOrderItem(RuiguCustomerIntentOrder intentOrder, RuiguOutBoundOrderItemCollection outBoundOrderItem)
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            List<object> dataSource = new List<object>();
            
            for (int i = 0; i < outBoundOrderItem.Count; i++)
            {
                RuiguOutboundOrderItem t = outBoundOrderItem[i];
                
                ThinkShop product = ThinkShop.GetByProductCode(t.ProductCode);

                string ProductNumber = t.ProductCode;
                string ProductName = t.ProductName;
                string ProductUnit = t.Unit_Name;
                int MinUnitQuantity = t.ActualProductQtySend;
                float Volume = product.Product_Volume;
                float Weight = product.Product_Weight;

                RuiguCustomerIntentOrderItem orderItem =
                    intentOrder.ItemCustomerCollection.FirstOrDefault<RuiguCustomerIntentOrderItem>(ii => ii.Shop_Id == product.Id);
                if (orderItem == null)
                {
                    continue;
                }

                decimal ProductPrice = orderItem.Price;
                decimal PriceCount = orderItem.Shop_Amount * orderItem.Price;
                dataSource.Add(
                    new
                    {
                        Index = i + 1,
                        ProductNumber,
                        ProductName,
                        ProductUnit,
                        MinUnitQuantity,
                        t.DcReportedQty,
                        Volume,
                        Weight,
                        ProductPrice,
                        PriceCount
                    });
            }

            this.table1.DataSource = dataSource;
        }

    }
}