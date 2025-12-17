using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_DTO
{
    public class WH_TaxAssign_DTO
    {
        public Int64 WH_TaxAssignNumber { get; set; }
        public Int64 WH_TaxCode { get; set; }

        public Int64 WH_TaxAssignDetailsNumber { get; set; }
        public Int64 AssesseeNature { get; set; }
        public Int32 FromDate { get; set; }
        public Int32 ToDate { get; set; }
        public Int32 SingleTransLimit { get; set; }
        public Int32 AggregateTransLimit { get; set; }
        public Int64 IncludeTax { get; set; }
        public Double PAN_TaxPercent { get; set; }
        public Double NON_PAN_TaxPercent { get; set; }
        public Int64 COA { get; set; }

        public String Search { get; set; }
        public Int32 Rights { get; set; }
        public Int32 CreatorCode { get; set; }
        public Int32 Id { get; set; }

    }
}
