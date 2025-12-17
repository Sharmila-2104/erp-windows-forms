using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_DTO
{
    public class Warehouse_DTO
    {
        public Int64 WarehouseNumber { get; set; }

        public Int64 WarehouseCategory { get; set; }
        public String WarehouseCode { get; set; }
        public String WarehouseDescription { get; set; }
        public Int64 WarehouseGroup { get; set; }

        public Int32 Rights { get; set; }
        public Int32 Status { get; set; }
        public Int32 CreatorCode { get; set; }
        public Int32 Id { get; set; }
    }
}
