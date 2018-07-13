using System.Linq;
using Ruigu.Crm.BL.Supplier;
using Ruigu.Crm.BL.Think;
using Zangar.Framework.DataUI;

namespace RuiguCrmReports.Orders
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;
    using Ruigu.Crm.BL.WorkFlows;

    /// <summary>
    /// Summary description for ExPurchaseReturnOrderItem.
    /// </summary>
    public partial class ExPurchaseReturnOrderItem : Telerik.Reporting.Report
    {
        public ExPurchaseReturnOrderItem(SupplierReturnOrder returnOrder)
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            List<string> codeList=new List<string>(); 
            foreach (var item in returnOrder.ReturnOrderItemCollection)
            {
                SupplierReturnOrderItem returnItem = (SupplierReturnOrderItem) item;
                codeList.Add(returnItem.ProductCode);
            }
            object[] obj = codeList.ToObjectArray();
            ThinkShopCollection shopCol = ThinkShopCollection.GetByProductCodes(obj);
            
            List<object> dataSource = new List<object>();
            for (int i = 0; i < returnOrder.ReturnOrderItemCollection.Count; i++)
            {
                SupplierReturnOrderItem orderItem = returnOrder.ReturnOrderItemCollection[i];
                ThinkShop shop = shopCol.FirstOrDefault<ThinkShop>(ii => ii.Bianma == orderItem.ProductCode);
                
                string productSpecAndModel = shop.ProductModel + " " + shop.Specification;
                double orderBoxQuantity = orderItem.MinunitQuantity / (double)shop.BoxQuantity;

                string Total_Purchasing_Price = CutZero(Math.Round(orderItem.Min_Purchasing_Price * orderItem.MinunitQuantity, 4));
                string Min_Unit_Purchasing_Price = CutZero(Math.Round(orderItem.Min_Purchasing_Price, 4));

                 
                dataSource.Add(
                    new
                    {
                        Index = i + 1,
                        orderItem.ProductCode,
                        orderItem.ProductName,
                        productSpecAndModel,
                        orderItem.MinunitQuantity,
                        orderItem.MinUnitName,
                        shop.BoxQuantity,
                        orderBoxQuantity,
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