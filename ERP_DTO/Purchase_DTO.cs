using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_DTO
{
    public class Purchase_DTO
    {
        public Int64 Number { get; set; }

        public String PurchaseOrderNo { get; set; }

        public Int32 PoDate { get; set; }

        public Int64 VendorCode { get; set; }

        //public Int64 VendorNumber { get; set; }
        
        //public String VendorName { get; set; }

        //public String Address { get; set; }

        //public String City { get; set; }

        //public String State { get; set; }

        //public String Country { get; set; }

        //public String PIN { get; set; }

        //public String GST { get; set; }

        //public String PAN { get; set; }

        public Int64 IsImportOrder { get; set; }

        public Int64 Currency { get; set; }

        public Int64 MaterialSegregation { get; set; }

        public String PaymentTerms { get; set; }

        public String PaymentMethod { get; set; }

        public String DeliveryTerms { get; set; }

        public String DeliveryMode { get; set; }

        public String Tax { get; set; }

        public String Inspection { get; set; }

        public String TechnicalDeliveryConditions { get; set; }

        public String Remarks { get; set; }

        public Int64 PurchaseItemNumber { get; set; }
        public Int64 PurchaseNumber { get; set; }
        public Int64 ExpenseCode { get; set; }
        public Int64 Occurrence { get; set; }
        public Int64 ChargeableMethod { get; set; }
        public Double ExpenseBase { get; set; }
        public Int64 Allocate { get; set; }
        public Int64 LedgerAccount { get; set; }

        public Int64 ItemCode { get; set; }
        public Int64 UoM { get; set; }
        public Double PO_Qty { get; set; }
        public Double UnitPrice { get; set; }
        public Double Amount { get; set; }
        public Int32 DeliveryDate { get; set; }


        public String Search { get; set; }
        public Int32 Rights { get; set; }

        public Int32 Status { get; set; }

        public Int32 CreatorCode { get; set; }

        public Int32 Id { get; set; }

    }
}
