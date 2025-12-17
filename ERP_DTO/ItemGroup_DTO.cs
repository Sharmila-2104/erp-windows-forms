using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_DTO
{
    public class ItemGroup_DTO
    {
        public Int64 ItemGroupNumber { get; set; }
        public String ItemGroup { get; set; }
        public String IG_Description { get; set; }
        public Int64 UnderIGroup { get; set; }
        public Int64 MaterialOwnership { get; set; }
        public Int64 PurchaseWarehouse { get; set; }
        public Int64 SaleWarehouse { get; set; }
        public Int64 MaterialClassification { get; set; }
        public Int32 Rights { get; set; }
        public Int32 CreatorCode { get; set; }
        public Int32 Id { get; set; }
    }
}
