using System.Collections.Generic;
using Ruigu.Crm.BL.Enums;
using Ruigu.Crm.BL.WorkFlows;

namespace RuiguCrmReports.Orders
{
    using System;

    /// <summary>
    /// Summary description for Report1.
    /// </summary>
    public partial class ExSupplierConsignment : Telerik.Reporting.Report
    {
        public ExSupplierConsignment()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public void SetDateSource(SupplierPurchasingOrder purchasingOrder)
        {
            this.DataSource = purchasingOrder;
            this.tableOrderInfo.DataSource = purchasingOrder;
            this.tablePayInfo.DataSource = purchasingOrder;

            if (purchasingOrder.Order_Type != 1)
            {
                txtPrice.Value = "单价";
            }
            List<object> dataSource = new List<object>();
            for (int i = 0; i < purchasingOrder.ItemCollection.Count; i++)
            {
                SupplierPurchasingOrderItem t = purchasingOrder.ItemCollection[i];

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
                        Total_Purchasing_Price = CutZero(Math.Round(t.Total_Purchasing_Price, 2)),
                        Min_Unit_Purchasing_Price = CutZero(Math.Round(t.Min_Unit_Purchasing_Price, 2)),
                        Total_Promotion_Price = CutZero(Math.Round(t.Total_Promotion_Price, 2)),
                        Min_Unit_Promotion_Price = CutZero(Math.Round(t.Min_Unit_Promotion_Price, 2)),
                    });
            }

            tableDetail.DataSource = dataSource;

            this.txtProductRequir.Value = " 供方必须保证产品规格、款式符合国家法律法规及相关标准认证，且无任何质量问题，因质量问题产生的全部责任由供货方承担。";
            
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