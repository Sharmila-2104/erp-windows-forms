using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_DTO
{
    public class ExpenseCode_DTO
    {
        public Int64 ExpenseCodeNumber { get; set; }

        public String ExpenseCode { get; set; }
        public String EC_Description { get; set; }
        public Int64 LedgerAccount { get; set; }

        public Int32 Rights { get; set; }
        public Int32 CreatorCode { get; set; }
        public Int32 Id { get; set; }
    }
}
