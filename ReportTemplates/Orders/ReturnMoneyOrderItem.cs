using System.Collections.Generic;
using Ruigu.Crm.BL.Sale;
using Ruigu.Crm.BL.Think;
using Ruigu.Crm.BL.WorkFlows;

namespace RuiguCrmReports.Orders
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for ExSupplierOrderItem.
    /// </summary>
    public partial class ReturnMoneyOrderItem : Telerik.Reporting.Report
    {
        public ReturnMoneyOrderItem(ThinkOrderShopReturns returnInfo)
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            List<object> dataSource = new List<object>();

            if (returnInfo.ReturnProduct != null && returnInfo.ReturnProduct.ID > 0)
            {
                dataSource.Add(new
                {
                    ProductCode = returnInfo.ReturnProduct.Bianma,
                    ProductName = returnInfo.ReturnProduct.Product_Name,
                    returnInfo.Return_Amount_Min,
                    returnInfo.ReturnProduct.Minunitname,
                    returnInfo.Return_Totalprice,
                    UnitPrice = returnInfo.Return_Realityprice/(returnInfo.Return_Amount_Min/returnInfo.Return_Amount)
                });
            }
            this.table1.DataSource = dataSource;
        }

        public ReturnMoneyOrderItem(RuiguAfterSaleShop returnShop)
        {
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            List<object> dataSource = new List<object>();
            dataSource.Add(new
            {
                ProductCode = returnShop.ReturnProduct.Bianma,
                ProductName = returnShop.ReturnProduct.Product_Name,
                Return_Amount_Min = returnShop.Count_Min,
                returnShop.ReturnProduct.Minunitname,
                Return_Totalprice = "",
                UnitPrice = ""//returnInfo.Return_Realityprice / (returnShop.Co / returnShop.Return_Amount)
            });
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