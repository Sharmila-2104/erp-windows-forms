using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_DTO
{
    public class COA_Ledger_DTO
    {
        public Int64 LedgerNumber { get; set; }
        
        public String LedgerAccount { get; set; }
        public String LedgerName { get; set; }
        public Int64 LedgerGroup { get; set; }

        public Int32 Rights { get; set; }
        public Int32 CreatorCode { get; set; }
        public Int32 Id { get; set; }
    }
}
