using System.Linq;
using Ruigu.Crm.BL;
using Ruigu.Crm.BL.Enums;
using Ruigu.Crm.BL.Sale;
using Ruigu.Crm.BL.Think;

namespace RuiguCrmReports.Orders
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;
    using System.Collections.Generic;

    /// <summary>
    /// Summary description for ReturnMoneyOrder.
    /// </summary>
    public partial class ReturnMoneyOrder : Telerik.Reporting.Report
    {
        public ReturnMoneyOrder()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public void SetDataSource(ThinkRefund refoun)
        {
            string statusString = string.Empty;
            if (RuiguMemberOrderStatusMapping.MemberOrderStatusMapping.ContainsKey(refoun.MemberOrder.OrderStatus))
                statusString = RuiguMemberOrderStatusMapping.MemberOrderStatusMapping[refoun.MemberOrder.OrderStatus];
            tOrderNumber.Value = refoun.MemberOrder.OrderNumber;
            tUser.Value = refoun.MemberOrder.LocationConsignee;
            tTotalAmount.Value = string.Format("(商品总额：{0}+运费：{1}-折扣：{2}-配件额度：{3}-现金余额：{4}-使用金券：{5} )=应付金额：{6}",
                refoun.MemberOrder.TotalMoney, refoun.MemberOrder.DeliveFee, refoun.MemberOrder.Discount,
                refoun.MemberOrder.Use_Money_Accessory, refoun.MemberOrder.Use_Money, refoun.MemberOrder.Use_Gold_Ticket,
                refoun.MemberOrder.DueMoney);
            tPayType.Value = refoun.MemberOrder.PayTypeName;
            tPayTime.Value = refoun.MemberOrder.PayTime;
            tOrderStatus.Value = statusString;
            tOrderTime.Value = refoun.MemberOrder.CreateTime.ToString("yyyy-MM-dd HH:mm:ss");
            tTotalReturn.Value = refoun.refund_Fee.ToString();
            tRemark.Value = refoun.Reason;

            RuiguDealers member = RuiguDealers.GetByID(refoun.MemberOrder.OrderingUser.Associated_Id);
            if (member.ID > 0)
            {
                txtRegion.Value = member.Mname_True;
            }
            else
            {
                txtRegion.Value = "线上";
            }

            if (refoun.Reason.StartsWith("AS"))
            {
                RuiguAfterSaleShop result = RuiguAfterSaleShop.GetByAfterNo(refoun.Reason);

                ReturnMoneyOrderItem reportItems = new ReturnMoneyOrderItem(result);

                subReport1.ReportSource = reportItems;
            }
            else
            {

                ThinkOrderShopReturns returnInfo = ThinkOrderShopReturns.GetByID(refoun.return_Id);
                ReturnMoneyOrderItem reportItems = new ReturnMoneyOrderItem(returnInfo);
                subReport1.ReportSource = reportItems;
            }

            

        }

    }
}