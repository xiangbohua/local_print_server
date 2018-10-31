using RuiguCrmReports.ProductLabel;

namespace ReportTemplates.Models
{
    public class ProductPackLabelModel : PrintModel
    {
        public override string GenerateFile()
        {
            if (this.packType == 1)
            {
                if (this.isOutSource == 0)
                {
                    ProductPackLabe53 p = new ProductPackLabe53();
                    p.SetDataSource(this);
                    return this.ExportPdf(p);
                }
                else
                {
                    ProductPackLabe53Other p = new ProductPackLabe53Other();
                    p.SetDataSource(this);
                    return this.ExportPdf(p);
                }

            } 
            else
            {
                if (this.isOutSource == 0)
                {
                    ProductPackLabelMid p = new ProductPackLabelMid();
                    p.SetDataSource(this);
                    return this.ExportPdf(p);
                }
                else
                {
                    ProductPackLabelMidOther p = new ProductPackLabelMidOther();
                    p.SetDataSource(this);
                    return this.ExportPdf(p);
                }
            }

        }

        public int packType;
        public int isOutSource;
        public string ProductCode;
        public string ProductName;
        public string Quantity;
        public string QrCodeString;
        public int brandId;
    }


}
