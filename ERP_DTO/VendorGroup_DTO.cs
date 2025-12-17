using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_DTO
{
    public class VendorGroup_DTO
    {
        public Int64 VendorGroupNumber { get; set; }

        public String VendorGroup { get; set; }

        public String VG_Description { get; set; }

        public Int64 UnderVGroup { get; set; }

        public Int32 Rights { get; set; }

        public Int32 CreatorCode { get; set; }

        public Int32 Id { get; set; }

    }
}
