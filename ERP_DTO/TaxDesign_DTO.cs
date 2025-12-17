using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_DTO
{
    public class TaxDesign_DTO
    {
        public Int64 TaxDesignNumber { get; set; }
        public Int64 TaxCluster { get; set; }
        
        public Int64 TaxDesignDetailsNumber { get; set; }
        public Int64 TaxClusterDetailsNumber { get; set; }
        public Int64 Index { get; set; }
        public Int32 LoadonInventory { get; set; }
        public Double LoadonInventoryPercent { get; set; }
        public Int64 TaxNature { get; set; }
        public Int64 ChargeableBasis { get; set; }
        public String CalculationFactors { get; set; }

        public Int32 Rights { get; set; }
        public Int32 Status { get; set; }
        public Int32 CreatorCode { get; set; }
        public Int32 Id { get; set; }
    }
}
