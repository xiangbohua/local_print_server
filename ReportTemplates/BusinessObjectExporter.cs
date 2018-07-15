using System;
using System.Collections.Generic;
using System.IO;
using ReportTemplates.Models;
using ReportTemplates.Transport;
using RuiguCrmReports;
using Telerik.Reporting;
using Telerik.Reporting.Processing;

namespace ReportTemplates
{
    public class BusinessObjectExporter
    {
//        /// <summary>
//        /// 将采购订单生成可打印的pdf 
//        /// </summary>
//        /// <param name="supplierPurchasingOrder"></param>
//        /// <param name="savingPath"></param>
//        /// <returns></returns>
//        public static string ExportPurchasingOrder(SupplierPurchasingOrder supplierPurchasingOrder, string savingPath)
//        {
//            savingPath = GetFileSavingPath(savingPath);
//            string fileName = string.Format("{0}\\{1}{2}.pdf", savingPath, supplierPurchasingOrder.Supplier_Name, supplierPurchasingOrder.Order_Number);
//            if (supplierPurchasingOrder.Order_Type != 1 || supplierPurchasingOrder.Order_Type != 1)
//            {
//                ExSupplierConsignment pp = new ExSupplierConsignment();
//                Exception exportException;
//                pp.SetDateSource(supplierPurchasingOrder);
//                ReportExporter.SaveReport(pp, fileName, out exportException);
//            }
//            else
//            {
//                ExSupplierOrder1 pp = new ExSupplierOrder1();
//                Exception exportException;
//                pp.SetDateSource(supplierPurchasingOrder);
//                ReportExporter.SaveReport(pp, fileName, out exportException);
//
//                
//            }
//            return fileName;
//        }
//
//        /// <summary>
//        /// 将入库通知单生成可打印的pdf 
//        /// </summary>
//        /// <param name="toDcConsignOrder"></param>
//        /// <param name="savingPath"></param>
//        /// <returns></returns>
//        public static string ExportConsignOrder(RuiguToDcConsignOrder toDcConsignOrder, string savingPath)
//        {
//            savingPath = GetFileSavingPath(savingPath);
//            string fileName = string.Format("{0}\\入库通知单{1}.pdf", savingPath, toDcConsignOrder.ConsignId);
//            ExConsignOrder eo = new ExConsignOrder();
//            Exception exportException;
//            eo.SetDateSource(toDcConsignOrder);
//            ReportExporter.SaveReport(eo, fileName, out exportException);
//            return fileName;
//        }
//
//        /// <summary>
//        /// 将出库通知单生成可打印的pdf 
//        /// </summary>
//        /// <param name="intentOrderNumber"></param>
//        /// <param name="savingPath"></param>
//        /// <returns></returns>
//        public static string ExportOutBoundOrder(string intentOrderNumber, string savingPath)
//        {
//            savingPath = GetFileSavingPath(savingPath);
//            Exception exportException = null;
//            RuiguCustomerIntentOrder customerIntentOrderOrder = RuiguCustomerIntentOrder.GetByOrderNumber(intentOrderNumber);
//            if (customerIntentOrderOrder.CanPrentOrder)
//            {
//                //RuiguOutboundOrder toSmOrderOrder = RuiguOutboundOrder.GetByCustomerOrderNumber(intentOrderNumber);
//                
//                string fileName = string.Format("{0}\\{1} {2} {3}意向单.pdf", savingPath, customerIntentOrderOrder.Waybill_Sort, customerIntentOrderOrder.Location_Consignee, customerIntentOrderOrder.Order_No);
//                
//                ExCustomerIntentSmOrder2 eo = new ExCustomerIntentSmOrder2 ();
//                
//                eo.SetDateSource(customerIntentOrderOrder);
//                ReportExporter.SaveReport(eo, fileName, out exportException);
//                if (exportException != null)
//                    return "意向单打印文件失败" + intentOrderNumber;
//                return fileName;
//            }
//            return string.Empty;
//        }
//
//        public static string ExportAfterServicePickOrder(DeliveryOrder deliverOrder)
//        {
//            string savingPath = GetFileSavingPath(null);
//            
//            Exception exportException = null;
//            //if (deliverOrder.CanPrentOrder)
//            {
//                //RuiguOutboundOrder toSmOrderOrder = RuiguOutboundOrder.GetByCustomerOrderNumber(intentOrderNumber);
//
//                string fileName = string.Format("{0}\\{1} {2} {3}售后提货单.pdf", savingPath, deliverOrder.Waybill_Sort, deliverOrder.Location_Consignee, deliverOrder.Order_No);
//
//                AfterServicePickUpOrder eo = new AfterServicePickUpOrder();
//
//                eo.SetDateSource(deliverOrder);
//                ReportExporter.SaveReport(eo, fileName, out exportException);
//                if (exportException != null)
//                    return "售后提货单打印文件失败" + deliverOrder.Related_No;
//                return fileName;
//            }
//        }
//
//
//        /// <summary>
//        /// 将出库通知单生成可打印的pdf 
//        /// </summary>
//        /// <param name="order"></param>
//        /// <param name="savingPath"></param>
//        /// <returns></returns>
//        public static string ExportOutBoundOrder(RuiguCustomerIntentOrder order, string savingPath)
//        {
//            savingPath = GetFileSavingPath(savingPath);
//            Exception exportException = null;
//            if (order.CanPrentOrder)
//            {
//                //RuiguOutboundOrder toSmOrderOrder = RuiguOutboundOrder.GetByCustomerOrderNumber(intentOrderNumber);
//
//                string fileName = string.Format("{0}\\{1} {2} {3}配送线上订单.pdf", savingPath, order.Waybill_Sort, order.Location_Consignee, order.Order_No);
//
//                ExCustomerIntentSmOrder2 eo = new ExCustomerIntentSmOrder2();
//
//                eo.SetDateSource(order);
//                ReportExporter.SaveReport(eo, fileName, out exportException);
//                return fileName;
//            }
//            return string.Empty;
//        }
//
//        public static string ExportOutBoundOrder(DeliveryOrder order, string savingPath)
//        {
//            savingPath = GetFileSavingPath(savingPath);
//            Exception exportException = null;
//            //if (order.CanPrentOrder)
//            {
//                //RuiguOutboundOrder toSmOrderOrder = RuiguOutboundOrder.GetByCustomerOrderNumber(intentOrderNumber);
//
//                string fileName = string.Format("{0}\\{1} {2} {3}线上.pdf", savingPath, order.Waybill_Sort, order.Location_Consignee, order.Order_No);
//
//                ExCustomerIntentSmOrder2 eo = new ExCustomerIntentSmOrder2();
//
//                eo.SetDateSource(order);
//                ReportExporter.SaveReport(eo, fileName, out exportException);
//                return fileName;
//            }
//            return string.Empty;
//        }
//
//
//        public static string ExportAfterPickProductLabel(DeliveryOrder deliverOrder, string savingPath)
//        {
//            //获取
//            savingPath = GetFileSavingPath(savingPath);
//            string fileName = string.Format("{0}\\{1}{2}.pdf", savingPath, "售后提货标签", deliverOrder.Order_No);
//
//            RuiguDealers dealer = RuiguDealers.GetByID(deliverOrder.DC_Id);
//
//            List<object> dataSource = new List<object>();
//            if (deliverOrder.Type != "PICK_AFTER_SALE")
//                return null;
//
//            foreach (DeliveryOrderItem shopItem in deliverOrder.Items)
//            {
//                string[] uuids = shopItem.Uuid.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
//
//                foreach (string uuid in uuids)
//                {
//                    dataSource.Add(new
//                    {
//                        AfterSaleOrderNumber = deliverOrder.Related_No.Substring(0, deliverOrder.Related_No.Length - 3),
//                        AfterSaleOrderNumberSubFix = deliverOrder.Related_No.Substring(deliverOrder.Related_No.Length - 3 , 3),
//                        ProductName = deliverOrder.Items.GetProductInfoById(shopItem.Shop_Id).Product_Name,
//                        ProductCode = deliverOrder.Items.GetProductInfoById(shopItem.Shop_Id).Bianma,
//                        UnitName = shopItem.Unit_Name,
//                        WaybillNo = deliverOrder.Waybill_No,
//                        QrCode = uuid,
//                        Uuid = uuid,
//                        Region  = dealer.Mname_True
//                    });
//                }
//            }
//
//            //无需导出
//            if (dataSource.Count == 0)
//                return null;
//            PickOrderProductLabel label = new PickOrderProductLabel();
//            label.SetDataSource(dataSource);
//            Exception exportException;
//
//            ReportExporter.SaveReport(label, fileName, out exportException);
//            return fileName;
//        }
//
//        /// <summary>
//        /// 将付款申请单生成可打印的pdf
//        /// </summary>
//        /// <param name="payMent"></param>
//        /// <param name="savingPath"></param>
//        /// <returns></returns>
//        public static string ExportPayMent(PaymentRequest payMent, string savingPath)
//        {
//            savingPath = GetFileSavingPath(savingPath);
//            string fileName = string.Format("{0}\\付款申请单{1}-{2}-{3}-{4}.pdf", savingPath, payMent.Order_Number, payMent.Total_Amount, DateTime.Now.Minute, DateTime.Now.Second);
//            ExOrderPaymentManagement eo = new ExOrderPaymentManagement();
//            Exception exportException;
//            eo.SetDateSource(payMent);
//            ReportExporter.SaveReport(eo, fileName, out exportException);
//            return fileName;
//        }
//
//
//        /// <summary>
//        /// 将采购退货订单生成可打印的pdf 
//        /// </summary>
//        /// <param name="supplierPurchasingOrder"></param>
//        /// <param name="savingPath"></param>
//        /// <returns></returns>
//        public static string ExportPurchasingReturnOrder(SupplierReturnOrder supplierReturnOrder, string savingPath)
//        {
//            savingPath = GetFileSavingPath(savingPath);
//            string fileName = string.Format("{0}\\{1}{2}.pdf", savingPath, "退货订单", supplierReturnOrder.Order_Number);
//            ExPurchaseReturnOrder pro=new ExPurchaseReturnOrder(); 
//            Exception exportException;
//            pro.SetDateSource(supplierReturnOrder);
//            ReportExporter.SaveReport(pro, fileName, out exportException);
//            return fileName;
//        }
//        
//        public static string ExportRefundVoucher(ThinkRefund refund, string savingPath)
//        {
//            savingPath = GetFileSavingPath(savingPath);
//            string fileName = string.Format("{0}\\{1}{2}{3}.pdf", savingPath, "退款凭证",refund.MemberOrder.OrderNumber,FileUtility.CleanInvalidFileName(refund.Reason));
//            ReturnMoneyOrder pp = new ReturnMoneyOrder();
//            Exception exportException;
//            pp.SetDataSource(refund);
//            ReportExporter.SaveReport(pp, fileName, out exportException);
//            return fileName;
//        }
//
//        public static string ExportWayBillCheck(ConsignWaybill waybillOrder, string savingPath)
//        {
//            savingPath = GetFileSavingPath(savingPath);
//            string fileName = string.Format("{0}\\{1}{2}.pdf", savingPath, "发货对账单", waybillOrder.Waybill_No);
//            ExWayBillCheck checkObject = new ExWayBillCheck();
//            checkObject.SetDateSource(waybillOrder);
//            Exception exportException;
//            ReportExporter.SaveReport(checkObject, fileName, out exportException);
//            return fileName;
//        }
//
//
//        private static string GetRamdomPath()
//        {
//            string path = Environment.CurrentDirectory + "\\PdfExportFolder\\";
//            Utility.Utilities.CreateDir(path);
//            return path;
//        }
//
//        private static string GetFileSavingPath(string filePath)
//        {
//            if (string.IsNullOrEmpty(filePath))
//                return GetRamdomPath();
//            return filePath;
//        }
//
//        public static string ExportWabill(ConsignWaybill bill, string savingPath)
//        {
//            savingPath = GetFileSavingPath(savingPath);
//            string fileName = string.Format("{0}\\{1}{2}.pdf", savingPath, "配送总单", bill.Waybill_No);
//            WaybillTask pp = new WaybillTask();
//            Exception exportException;
//            pp.SetDateSource(bill);
//            ReportExporter.SaveReport(pp, fileName, out exportException);
//            return fileName;
//        }


//        private static void CreateLabel(object tran, string filePath, string FileFormate)
//        {
//            if (File.Exists(filePath))
//                return;
//
//            ProductPackageQrCode report1 = new ProductPackageQrCode();
//
//            report1.DataSource = tran;
//
//            ReportProcessor processor = new ReportProcessor();
//            InstanceReportSource source = new InstanceReportSource();
//            source.ReportDocument = report1;
//            RenderingResult result = processor.RenderReport(FileFormate, source, null);
//
//            using (FileStream fs = new FileStream(filePath, FileMode.Create))
//            {
//                fs.Write(result.DocumentBytes, 0, result.DocumentBytes.Length);
//            }
//        }
    }
}
