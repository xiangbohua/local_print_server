using System;
using System.IO;
using Telerik.Reporting;
using Telerik.Reporting.Processing;

namespace RuiguCrmReports
{
    public static class ReportExporter
    {
        public static bool SaveReport(IReportDocument report, string filename, out Exception exception, string format)
        {
            try
            {
                ReportProcessor reportProcessor = new ReportProcessor();
                InstanceReportSource instanceReportSource = new InstanceReportSource();

                instanceReportSource.ReportDocument = report;

                RenderingResult renderingResult = reportProcessor.RenderReport(format.ToUpper(), instanceReportSource, null);
                filename = filename.Replace('\n', ' ');
                using (FileStream fs = new FileStream(filename, FileMode.Create))
                {
                    fs.Write(renderingResult.DocumentBytes,0,renderingResult.DocumentBytes.Length);
                }
                exception = null;
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool SaveReport(IReportDocument report, string filename, out Exception exception)
        {
            return SaveReport(report, filename, out exception,"PDF");
        }
        public static Stream GetReportStream(IReportDocument report, string filename, out Exception exception, string format)
        {
            try
            {
                ReportProcessor reportProcessor = new ReportProcessor();
                InstanceReportSource instanceReportSource = new InstanceReportSource();

                instanceReportSource.ReportDocument = report;

                RenderingResult renderingResult = reportProcessor.RenderReport(format.ToUpper(), instanceReportSource, null);


                MemoryStream stream = new MemoryStream(renderingResult.DocumentBytes, 0, renderingResult.DocumentBytes.Length);
                     
                exception = null;
                return stream;
            }
            catch (Exception ex)
            {
                exception = ex;
                return null;
            }
        }

        public static Stream GetReportStream(IReportDocument report, string filename, out Exception exception)
        {
            return GetReportStream(report, filename, out exception, "PDF");
        }
    }
}
