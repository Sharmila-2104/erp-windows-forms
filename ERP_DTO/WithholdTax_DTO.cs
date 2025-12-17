using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_DTO
{
    public class WithholdTax_DTO
    {
        public Int64 WithholdtaxNumber { get; set; }
        public Int64 TaxCategory { get; set; }        
        public Int64 TaxType { get; set; }
        public String WH_TaxCode { get; set; }
        public String WH_TaxDescription { get; set; }        
        public Int64 WH_TaxImpact { get; set; }
        public Int32 Rights { get; set; }
        public Int32 CreatorCode { get; set; }
        public Int32 Id { get; set; }
    }
}
