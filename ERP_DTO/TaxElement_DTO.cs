using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_DAO
{
    public class TaxElement_DTO
    {
        public Int64 TaxElementNumber { get; set; }
        public Int64 TaxCategory { get; set; }
        public Int64 TaxType { get; set; }
        public String TaxElement { get; set; }
        public String ElementDescription { get; set; }
        public Int64 COA { get; set; }
        public Int32 Rights { get; set; }
        public Int32 CreatorCode { get; set; }
        public Int32 Id { get; set; }
    }
}
