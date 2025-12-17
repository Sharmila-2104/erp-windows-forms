using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_DTO
{
    public class TaxCluster_DTO
    {
        public Int64 TaxClusterNumber { get; set; }
        public Int64 TaxCategory { get; set; }
        public Int64 TaxType { get; set; }
        public String TaxCluster { get; set; }
        public String ClusterDescription { get; set; }

        public Int64 TaxClusterDetailsNumber { get; set; }
        public Int64 TaxElement { get; set; }

        public String Search { get; set; }
        public Int32 Rights { get; set; }
        public Int32 Status { get; set; }
        public Int32 CreatorCode { get; set; }
        public Int32 Id { get; set; }
    }
}
