using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_DTO
{
    public class VendorCategory_DTO
    {
        public Int64 VendorCategoryNumber { get; set; }

        public String VendorCategory { get; set; }

        public String VC_Description { get; set; }

        public Int64 UnderVCategory { get; set; }

        public Int32 Rights { get; set; }

        public Int32 CreatorCode { get; set; }

        public Int32 Id { get; set; }
    }
}
