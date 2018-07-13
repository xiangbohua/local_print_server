using System;
using System.Collections.Generic;
using Ruigu.Crm.BL.Think;
using Ruigu.Crm.BL.WarehousingOrder;

namespace RuiguCrmReports.Orders
{

    /// <summary>
    /// Summary description for ExConsignOrderItem.
    /// </summary>
    public partial class ExConsignOrderItem : Telerik.Reporting.Report
    {
        public ExConsignOrderItem(RuiguToDCCosignOrderItemCollection cosignOrderItems)
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            List<object> dataSource = new List<object>();
            for (int i = 0; i < cosignOrderItems.Count; i++)
            {
                RuiguToDCConsignOrderItem t = cosignOrderItems[i];
                string ProductModelAndSpec = GetProductModelAndSpec(t.ProductCode);
                int MinUnitQuantity = t.MinPkgQty;
                string MinUnitName = t.MinPkgUnit;
                int QuantityInBox = t.ShipPkgQty;
                int OrderBoxQuantity = t.ProductTotalQty;
                //string Total_Purchasing_Price = CutZero(Math.Round(t.Total_Purchasing_Price, 4));
                //string Min_Unit_Purchasing_Price = CutZero(Math.Round(t.Min_Unit_Purchasing_Price, 4));

                //double OrderBoxQuantity = Math.Round(t.OrderBoxQuantity, 2);
                dataSource.Add(
                    new
                    {
                        Index = i + 1,
                        t.ProductCode,
                        t.ProductName,
                        ProductModelAndSpec,
                        MinUnitQuantity,
                        MinUnitName,
                        QuantityInBox,
                        OrderBoxQuantity
                    });
            }

            this.table1.DataSource = dataSource;
        }

        //技术规格
        private string GetProductModelAndSpec(string productCode)
        {
            ThinkShop ts = ThinkShop.GetByProductCode(productCode);
            return ts != null ? ts.Specification : string.Empty;
        }

        private string CutZero(decimal num)
        {
            string arraylist = Convert.ToString(num);
            int temp = 0;
            string str1 = "";
            for (int i = arraylist.Length - 1; i >= 0; i--)
            {
                if (arraylist[i].ToString() != "0")
                {
                    temp = i;
                    break;
                }
            }
            for (int i = 0; i <= temp; i++)
            {
                str1 += arraylist[i].ToString();
            }

            if (arraylist[arraylist.Length - 1] == '.')
            {
                str1 = arraylist.Remove(arraylist.Length - 2, 1);
            }

            return str1;
        }
    }
}