using System;
using System.Collections.Generic;
using Ruigu.Crm.BL.Think;
using Zangar.Framework.DataUI;

namespace RuiguCrmReports.Orders
{
    /// <summary>
    /// Summary description for ExConsignOrderItem.
    /// </summary>
    public partial class ExWayBillCheckItem : Telerik.Reporting.Report
    {
        public ExWayBillCheckItem(Dictionary<string,int > details)
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            object[] codes = details.Keys.ToObjectArray();
            ThinkShopCollection products = ThinkShopCollection.GetByProductCodes(codes);
            List<object> dataSource = new List<object>();
            int index = 1;
            foreach (KeyValuePair<string, int> detail in details)
            {
                ThinkShop currentProduct = products.GetByProductCode(detail.Key);

                string ProductModelAndSpec = currentProduct != null ? currentProduct.Specification : string.Empty;
                dataSource.Add(
                    new
                    {
                        Index = index,
                        currentProduct.Bianma,
                        currentProduct.Product_Name,
                        ProductModelAndSpec,
                        MinUnitName = currentProduct.Minunitname,
                        MinUnitQuantity = detail.Value
                    });
                index++;
            }
            this.table1.DataSource = dataSource;
        }
    }
}