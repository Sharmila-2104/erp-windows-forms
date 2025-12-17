using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_DTO
{
    public class TaxSetup_DTO
    {
        public Int64 TaxSetupNumber { get; set; }
        public Int64 TaxElement { get; set; }
        public Int32 LoadonInventory { get; set; }
        public Double LoadonInventoryPercent { get; set; }
        public Int64 TaxNature { get; set; }

        public Int64 TaxSetupDetailsNumber { get; set; }
        public Int64 FromDate { get; set; }
        public Int64 ToDate { get; set; }
        public Int64 GvTaxNature { get; set; }
        public Double FixedPercent { get; set; }
        public Int64 HSN { get; set; }
        public Double HSN_Percent { get; set; }
        public Int64 SAC { get; set; }
        public Double SAC_Percent { get; set; }
        public Double Abatement { get; set; }

        public String Search { get; set; }
        public Int32 Rights { get; set; }
        public Int32 CreatorCode { get; set; }
        public Int32 Id { get; set; }
    }
}
