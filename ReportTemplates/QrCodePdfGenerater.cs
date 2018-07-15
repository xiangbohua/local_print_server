using System;
using System.Data;
using System.IO;
using Utility;

namespace ReportTemplates
{
    public class QrCodePdfGenerater
    {
//        private const int MaxRowsForPdf = 4000;
//        public static Exception GeneratePdfWithDataTableAndFileName(DataTable workingDataTable, string savingFileFullName)
//        {
//            Exception exportException = null;
//            try
//            {
//                if (CheckExcelFormat(workingDataTable))
//                {
//                    if (workingDataTable.Rows.Count > MaxRowsForPdf)
//                    {
//                        string childFolder = Path.GetDirectoryName(savingFileFullName) + "\\" + Path.GetFileNameWithoutExtension(savingFileFullName);
//                        Utilities.CreateDir(childFolder);
//                        int tableCount = workingDataTable.Rows.Count / MaxRowsForPdf + 1;
//                        for (int i = 0; i < tableCount; i++)
//                        {
//                            DataTable splitedTable = workingDataTable.Clone();  //copy data table structure of loaded
//                            for (int j = 0; j < MaxRowsForPdf; j++)
//                            {
//                                if (workingDataTable.Rows.Count > 0)
//                                {
//                                    splitedTable.ImportRow(workingDataTable.Rows[0]);
//                                    workingDataTable.Rows.RemoveAt(0);
//                                }
//                            }
//                            string fileName = string.Format("{0}\\{1}-{2}.pdf", childFolder, Path.GetFileNameWithoutExtension(savingFileFullName), i);
//
//                            exportException = CreatePdfFileWithDataTable(splitedTable, fileName);
//
//                        }
//
//                    }
//                    else
//                    {
//                        exportException = CreatePdfFileWithDataTable(workingDataTable, savingFileFullName);
//                    }
//                }
//            }
//            catch
//            {
//
//            }
//            return exportException;
//        }
//
//
//
//        private static bool CheckExcelFormat(DataTable datatable)
//        {
//            string[] excelColumns = new string[]
//            {
//                "ProductName","Spec","Model","Quantity","ProductCode","QrCode","Type","Sequence"
//            };
//
//            if (datatable.Columns.Count != 8) return false;
//            for (int i = 0; i < excelColumns.Length; i++)
//            {
//                if (excelColumns[i] != datatable.Columns[i].ColumnName)
//                    return false;
//            }
//
//            return true;
//        }
//
//        private static Exception CreatePdfFileWithDataTable(DataTable excelDataTable, string pdfFileName)
//        {
//            //选择产品
//            Exception exportException = null;
//            ICustomReportLabel label = null;
//            switch (setting.CurrentLabelType)
//            {
//                case LabelType.Standard:
//                    label = new ProductMinPackageLabel();
//                    break;
//                case LabelType.Small:
//                    label = new ProductMinPackageLabelSmall();
//                    break;
//                default:
//                    return new ArgumentException("标签设置不正确");
//            }
//            label.DataSource = excelDataTable;
//            label.FitProductNameFontSize(GetLengthOfProductName(excelDataTable));
//            label.FitProductSpecFontSize(GetLengthOfProductSpec(excelDataTable));
//            label.CustomLebel(setting);
//            ReportExporter.SaveReport(label, pdfFileName, out exportException);
//            
//            return exportException;
//        }
//
//        private static int GetLengthOfProductName(DataTable workingDataTable)
//        {
//            if (workingDataTable.Rows.Count <= 1) return 10;
//
//            return workingDataTable.Rows[1][0].ToString().Length;
//        }
//
//        private static int GetLengthOfProductSpec(DataTable workingDataTable)
//        {
//            if (workingDataTable.Rows.Count <= 1) return 10;
//            return workingDataTable.Rows[1][1].ToString().Length;
//        }


    }
}
