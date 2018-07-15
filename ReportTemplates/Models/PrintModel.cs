using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Reporting;

namespace ReportTemplates.Models
{
    public abstract class PrintModel
    {
        public string file_name { get; set; }

        public string print_type { get; set; }

        public abstract string PrintFile();

        protected string ExportPdf(IReportDocument report)
        {
            string rootPath = Environment.CurrentDirectory;
            string fullPath = rootPath + "/" + Utility.Utilities.CleanInvalidFileName(this.file_name) + ".pdf";

            Exception exportException;
            ReportExporter.SaveReport(report, fullPath, out exportException);

            if (exportException != null)
            {
                throw exportException;
            }
            return fullPath;
        }

    }
}
