using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_DTO
{
    public class Currency_DTO
    {
        public Int64 CurrencyNumber { get; set; }
        public String CurrencyCode { get; set; }
        public String FormalName { get; set; }
        public String Symbol { get; set; }
        public Int32 DecimalPlaces { get; set; }
        public String DecimalPortionName { get; set; }
        public Int32 CurrencyLocation { get; set; }
        public Int32 Rights { get; set; }
        public Int32 CreatorCode { get; set; }
        public Int32 Id { get; set; }
    }
}
