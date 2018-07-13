using System.Collections.Generic;
using Ruigu.Crm.BL.WorkFlows;

namespace RuiguCrmReports.Orders
{
    using System;

    /// <summary>
    /// Summary description for ExSupplierOrderItem.
    /// </summary>
    public partial class ExSupplierOrderItem : Telerik.Reporting.Report
    {
        public ExSupplierOrderItem(SupplierPurchasingOrder order)
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            if (order.Order_Type != 1)
            {
                txtPrice.Value = "µ¥¼Û";
            }
            List<object> dataSource = new List<object>();
            for (int i = 0; i < order.ItemCollection.Count; i++)
            {
                SupplierPurchasingOrderItem t = order.ItemCollection[i];

                string Total_Purchasing_Price = CutZero(Math.Round(t.Total_Purchasing_Price, 4));
                string Min_Unit_Purchasing_Price = CutZero(Math.Round(t.Min_Unit_Purchasing_Price, 4));
                
                double OrderBoxQuantity = Math.Round(t.OrderBoxQuantity, 2);
                dataSource.Add(
                    new
                    {
                        Index = i + 1,
                        t.ProductCode,
                        t.ProductName,
                        t.ProductModelAndSpec,
                        t.MinUnitQuantity,
                        t.MinUnitName,
                        t.QuantityInBox,
                        OrderBoxQuantity,
                        Total_Purchasing_Price,
                        Min_Unit_Purchasing_Price
                    });
            }

            this.table1.DataSource = dataSource;
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