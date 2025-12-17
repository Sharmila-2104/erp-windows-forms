using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_DTO
{
    public class UoM_DTO
    {
        public Int64 UnitNumber { get; set; }

        public String UnitCode { get; set; }
        public String UnitDescription { get; set; }
        public Int64 DecimalPlaces { get; set; }

        public Int32 Rights { get; set; }
        public Int32 CreatorCode { get; set; }
        public Int32 Id { get; set; }


    }
}
