using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_DTO
{
    public class TaxSubMaster_DTO
    {
        public Int64 Number { get; set; }

        public String Title { get; set; }
        public String Notes { get; set; }
        
        public Int32 Rights { get; set; }
        public Int32 Status { get; set; }
        public Int32 CreatorCode { get; set; }
        public Int32 Id { get; set; }
    }
}
