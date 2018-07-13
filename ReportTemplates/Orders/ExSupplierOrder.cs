using Ruigu.Crm.BL.Enums;
using Ruigu.Crm.BL.WorkFlows;

namespace RuiguCrmReports.Orders
{
    using System;

    /// <summary>
    /// Summary description for Report1.
    /// </summary>
    public partial class ExSupplierOrder : Telerik.Reporting.Report
    {
        public ExSupplierOrder()
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
            if (purchasingOrder.Order_Type == 3)
                txtTitle.Value = "居间合同";
            this.DataSource = purchasingOrder;
            this.tableOrderInfo.DataSource = purchasingOrder;
            this.tablePayInfo.DataSource = purchasingOrder;
            ExSupplierOrderItem itemReport = new ExSupplierOrderItem(purchasingOrder)
            {
                Width = this.subReport1.Width
            };
            this.txtProductRequir.Value = string.Format("供方必须保证产品规格、款式符合甲方要求，符合国家法律法规及相关标准认证，且无任何质量问题，否则要承担相应的违约费用即合同金额的{0}%，并赔偿需方因此受到的其他损失。", Math.Round(purchasingOrder.Quality_Damages, 2) * 100);
            this.txtPackageRequir.Value = string.Format("供方需按照需方要求的包装方式，包装数量交付商品，如不经需方同意而擅自更改，需方有权提出此批订单总额的{0}%作为赔偿。", Math.Round(purchasingOrder.Package_Damages, 2) * 100);
            this.txtAssemblyRate.Value = string.Format("供方需对提供给需方的商品提供售后服务支持，供方给予需方销售额{0}%的赠送配件，提供售后技术支持等，其它售后服务支持详情以另外合同的形式进行补充。",purchasingOrder.Assembly_Preferential_Rate);
            if (purchasingOrder.Payment_Type == (int)RuiguMemberPaymentType.PrePayment)
            {
                decimal payRate = purchasingOrder.Total_Amount == 0
                    ? 0
                    : Math.Round(purchasingOrder.Advance_Payment_Amount/purchasingOrder.Total_Amount, 2)*100;
                txtPayMethod.Value = string.Format("供需双方签订合同后，需方向供方交付总货款的{0}%即{1}元作为预付款，供方交货经需方验收合格后，再结清尾款。", payRate, Math.Round(purchasingOrder.Advance_Payment_Amount, 2));
            }
            else
            {
                txtPayMethod.Value = string.Format("在供应方货物到货，并通过需方仓库验收或需方指定人验收后，需方向供方交付全额货款即{0}元", purchasingOrder.Total_Amount);
            }
            this.subReport1.ReportSource = itemReport;
        }
    }


}