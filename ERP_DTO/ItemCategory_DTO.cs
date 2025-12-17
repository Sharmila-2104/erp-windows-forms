using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_DTO
{
    public class ItemCategory_DTO
    {
        public Int64 ItemCategoryNumber { get; set; }

        public String ItemCategory { get; set; }
        public String IC_Description { get; set; }
        public Int64 UnderICategory { get; set; }
        
        public Int32 Rights { get; set; }
        public Int32 CreatorCode { get; set; }
        public Int32 Id { get; set; }

    }
}
