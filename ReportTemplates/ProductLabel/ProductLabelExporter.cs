using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ruigu.Crm.BL.Dc;
using Ruigu.Crm.BL.Product;
using Ruigu.Crm.BL.Think;
using Ruigu.Crm.Utility;

namespace RuiguCrmReports.ProductLabel
{
    public class ProductLabelExporter
    {        
        public static string GenerateProductLabel(string chossedPath, ThinkShop product,string format)
        {
            string fileEx = format == "pdf" ? "pdf" : "png";

            StringBuilder message = new StringBuilder();
            string savingProductPath = string.Format("{0}\\{1}", chossedPath,product.Supplier.CompanyName);
            FileUtility.CreateDir(savingProductPath);
            PackageLabelDataSourceProvider provider = new PackageLabelDataSourceProvider(product);

            if (product.EntityType == 2)
            {
                RepairProductLabel label = new RepairProductLabel();
                string qrCodeString = string.Format("{0}{1}-{2}-{3}-{4}", "PR", product.Bianma, 1, 1, "1");
                label.DataSource = new {Bianma = product.Bianma, Product_Name = product.Product_Name, MinUnitName = product.Minunitname, QrCodeString = qrCodeString};
                string filename = string.Format("{0}\\{1}-{2}.pdf", savingProductPath, product.Bianma,FileUtility.CleanInvalidFileName(product.Product_Name));
                Exception ee = null;
                ReportExporter.SaveReport(label, filename, out ee);

            }
            else
            {
                RuiguProductPackageInfo min = product.ProductPackageInfoCollection.FirstOrDefault<RuiguProductPackageInfo>(pp => pp.PackageTypeId == 1);
                if (min != null)
                {
                    if (product.Brand_Id == 15 || product.Brand_Id == 89)
                    {
                        ProductPackLabe53 label = new ProductPackLabe53(provider.GetDataSource(min.PackageTypeId));
                        label.SetBrandId(product.Brand_Id);
                        Exception ex = null;
                        ReportExporter.SaveReport(label, savingProductPath +"\\"+ product.Bianma + FileUtility.CleanInvalidFileName(product.Product_Name) + "-小." + fileEx, out ex, format);
                        if (ex != null)
                            message.AppendLine(product.Bianma + "小标签 生成失败");
                    }
                    else
                    {
                        ProductPackLabe53Other label = new ProductPackLabe53Other(provider.GetDataSource(min.PackageTypeId));
                        Exception ex = null;
                        ReportExporter.SaveReport(label, savingProductPath + "\\" + product.Bianma + FileUtility.CleanInvalidFileName(product.Product_Name) + "-小." + fileEx, out ex, format);
                        if (ex != null)
                            message.AppendLine(product.Bianma + "小标签 生成失败");
                    }
                }
                RuiguProductPackageInfo mid = product.ProductPackageInfoCollection.FirstOrDefault<RuiguProductPackageInfo>(pp => pp.PackageTypeId == 2);
                if (mid != null)
                {
                    if (product.Brand_Id == 15 || product.Brand_Id == 89)
                    {

                        ProductPackLabelMid label = new ProductPackLabelMid(provider.GetDataSource(mid.PackageTypeId));
                        label.SetBrandId(product.Brand_Id);
                        Exception ex = null;
                        ReportExporter.SaveReport(label, savingProductPath + "\\" + product.Bianma + FileUtility.CleanInvalidFileName(product.Product_Name) + "-中." + fileEx, out ex, format);
                        if (ex != null)
                            message.AppendLine(product.Bianma + "中标签 生成失败");
                    }
                    else
                    {
                        ProductPackLabelMidOther label = new ProductPackLabelMidOther(provider.GetDataSource(mid.PackageTypeId));
                        Exception ex = null;
                        ReportExporter.SaveReport(label, savingProductPath + "\\" + product.Bianma + FileUtility.CleanInvalidFileName(product.Product_Name) + "-中." + fileEx, out ex, format);
                        if (ex != null)
                            message.AppendLine(product.Bianma + "中标签 生成失败");
                    }
                }

                RuiguProductPackageInfo max = product.ProductPackageInfoCollection.FirstOrDefault<RuiguProductPackageInfo>(pp => pp.PackageTypeId == 3);
                if (max != null)
                {
                    if (product.Brand_Id == 15 || product.Brand_Id == 89)
                    {
                        ProductPackLabelMid label = new ProductPackLabelMid(provider.GetDataSource(max.PackageTypeId));
                        label.SetBrandId(product.Brand_Id);
                        Exception ex = null;
                        ReportExporter.SaveReport(label, savingProductPath + "\\" + product.Bianma + FileUtility.CleanInvalidFileName(product.Product_Name) + "-大." + fileEx, out ex, format);
                        if (ex != null)
                            message.AppendLine(product.Bianma + "大标签 生成失败");
                    }
                    else
                    {
                        ProductPackLabelMidOther label = new ProductPackLabelMidOther(provider.GetDataSource(max.PackageTypeId));

                        Exception ex = null;
                        ReportExporter.SaveReport(label, savingProductPath + "\\" + product.Bianma + FileUtility.CleanInvalidFileName(product.Product_Name) + "-大." + fileEx, out ex, format);
                        if (ex != null)
                            message.AppendLine(product.Bianma + "大标签 生成失败");
                    }
                }
            }


            return message.ToString();
        }

        public static string GenerateProductLabel(string chossedPath, ThinkShop product)
        {
            return GenerateProductLabel(chossedPath, product, "pdf");
        }

        public static string GenerateWarehouseLabel(string chossedPath, RuiguDcWarehouseInfo ww)
        {
            object data = new 
            {
                QrCodeString = ww.GetWarehouseLabelCode(),
                Code = ww.GetWarehouseLabelCode() + " " + ww.WarehouseName.Replace("地推仓","")
            };
            Exception ex = null;
            WarehouseLabel label = new WarehouseLabel(data);
            ReportExporter.SaveReport(label, chossedPath+ "\\"+ ww.GetWarehouseLabelCode() + " " + ww.WarehouseName.Replace("地推仓", "") +".pdf", out ex, "PDF");
            return "";
        }

    }

    

    public class PackageLabelDataSourceProvider
    {
        private ThinkShop _product;
        public PackageLabelDataSourceProvider(ThinkShop product)
        {
            _product = product;
        }

        public PackageLabelDataSource GetDataSource(int packageTypeId)
        {
            foreach (RuiguProductPackageInfo productPackageInfo in _product.ProductPackageInfoCollection)
            {
                if (productPackageInfo.PackageTypeId == packageTypeId)
                {
                    string quantity = productPackageInfo.MinUnitQuantity + _product.Minunitname;
                    string weight = Math.Round(productPackageInfo.GrossWeight,2) + "Kg";
                    string qrCode = string.Format("{0}{1}-{2}-{3}-{4}", _product.EntityType == 256 ? "PA" : "PR",_product.Bianma, productPackageInfo.PackageTypeId,productPackageInfo.MinUnitQuantity,"1");
                    string supplierAddress= string.Empty;
                    if (!string.IsNullOrEmpty(_product.Supplier.CompanyLocation.Address))
                        supplierAddress = _product.Supplier.CompanyLocation.Address;
                    
                    return new PackageLabelDataSource()
                    {
                        ProductName =  _product.Product_Name,
                        ProductModel =  _product.ProductModel,
                        ProductCode = _product.Bianma,
                        Quantity = quantity,
                        QrCodeString =  qrCode,
                        GrooseWeight = weight,
                        PackageSize = string.Format("{0}x{1}x{2}cm", Math.Round(productPackageInfo.Width * 100, 1)  , Math.Round(productPackageInfo.Height * 100, 1)  , Math.Round(productPackageInfo.Depth * 100, 1) ),
                        SupplierName =  _product.Supplier.CompanyName,
                        SupplierAddress = supplierAddress,
                        UnitName = _product.Minunitname
                    };
                }
            }
            return null;
        }

    }

    public class PackageLabelDataSource
    {
        public string ProductName;
        public string ProductCode;
        public string Quantity;
        public string GrooseWeight;
        public string PackageSize;
        public string QrCodeString;
        public string SupplierName;
        public string SupplierAddress;
        public string UnitName;
        public string ProductModel;
    }

}
