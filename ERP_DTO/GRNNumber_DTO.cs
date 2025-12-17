using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_DTO
{
    public class GRNNumber_DTO
    {
        public Int64 Number { get; set; }
        public Int64 GRNNumber { get; set; }
        public Int64 GRNOrderMethod { get; set; }

        public Int32 StartingNumber { get; set; }

        public Int32 NumberofDigits { get; set; }

        public Int64 PrefilZero { get; set; }


        public Int32 Date { get; set; }
       
        public String Frequency { get; set; }

        public Int64 FrequencyNumber { get; set; }

        public Int32 Rights { get; set; }

        public Int32 Status { get; set; }

        public Int32 CreatorCode { get; set; }

        public Int32 Id { get; set; }
    }
}
