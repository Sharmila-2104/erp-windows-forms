using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_DTO
{
    public class Vendor_DTO
    {
        public Int64 VendorNumber { get; set; }

        public String VendorCode { get; set; }

        public String VendorName { get; set; }

        public String Address { get; set; }

        public String City { get; set; }

        public String State { get; set; }

        public String Country { get; set; }

        public String PIN { get; set; }

        public String ContactPerson { get; set; }

        public String CP_Telephone { get; set; }

        public String CP_Mobile { get; set; }

        public String CP_Email { get; set; }

        public String AccountsPerson { get; set; }

        public String AP_Telephone { get; set; }

        public String AP_Mobile { get; set; }

        public String AP_Email { get; set; }

        public Int32 VendorLocation { get; set; }

        public Int64 VendorGroup { get; set; }

        public Int64 VendorCategory { get; set; }

        public Int64 RegistrationType { get; set; }

        public String GSTIN { get; set; }

        public Int64 AssesseeTerritory { get; set; } 

        public Int32 TransportAgency { get; set; }

        public String TransporterID { get; set; }

        public String PaymentTerms { get; set; }

        public String PaymentMode { get; set; }

        public Int64 CreditDays { get; set; }

        public Int64 PaymentBase { get; set; }

        public Int64 Currency { get; set; }

        public String AccountName { get; set; }

        public String AccountNumber { get; set; }

        public String IFSC { get; set; }

        public String BankName { get; set; }

        public String PAN { get; set; }

        public Int64 WithholdTax { get; set; }

        public Int64 AssesseeNature { get; set; }

        public Int64 Number { get; set; }
        public Int64 TaxCategory { get; set; }
        public Int64 TaxType { get; set; }
        public Int64 WH_TaxCode { get; set; }
       
        public Int64 TaxCluster { get; set; }

        public Int32 FromDate { get; set; }
        public Int32 ToDate { get; set; }

        public String Search { get; set; }

        public Int32 Rights { get; set; }

        public Int32 CreatorCode { get; set; }

        public Int32 Id { get; set; }
    }
}
