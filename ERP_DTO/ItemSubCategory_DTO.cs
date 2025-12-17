using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_DTO
{
    public class ItemSubCategory_DTO
    {
        public Int64 ItemSubCategoryNumber { get; set; }

        public String ItemSubCategory { get; set; }
        public String ISC_Description { get; set; }
        public Int64 UnderISubCategory { get; set; }

        public Int32 Rights { get; set; }
        public Int32 CreatorCode { get; set; }
        public Int32 Id { get; set; }

    }
}
