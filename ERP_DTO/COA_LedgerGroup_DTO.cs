using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_DTO
{
    public class COA_LedgerGroup_DTO
    {
        public Int64 LedgerGroupNumber { get; set; }
        public String LedgerGroup { get; set; }
        public Int64 UnderLGroup { get; set; }
        public Int64 GroupNature { get; set; }
        public Int32 Rights { get; set; }
        public Int32 CreatorCode { get; set; }
        public Int32 Id { get; set; }
    }
}
