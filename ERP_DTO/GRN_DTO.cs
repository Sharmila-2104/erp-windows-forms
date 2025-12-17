using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_DTO
{
    public class GRN_DTO
    {
        public Int64 Number { get; set; }
        public String GRN_Number { get; set; }
        public Int32 GRN_Date { get; set; }
        public String PurchaseInvoiceNo { get; set; }
        public Int32 PurchaseInvoiceDate { get; set; }
        public Int64 VendorName { get; set; }
        public Int64 TaxCluster { get; set; }
        public Int64 WH_TaxCode { get; set; }
        public Int64 MaterialSegregation { get; set; }

        public Int64 GRNItemNumber { get; set; }
        public Int64 ItemCode { get; set; }
        public Int64 UoM { get; set; }
        public Double Qty { get; set; }
        public Double UnitPrice { get; set; }
        public Double Amount { get; set; }
        public Int64 ExpenseCode { get; set; }
        public Double ExpenseValue { get; set; }
        public Int64 HSN { get; set; }
        public Double GST_TaxAmount { get; set; }
        public Double Percent { get; set; }
        public Double WH_TaxAmount { get; set; }

        public Double InvoiceAmount { get; set; }
        public Double WithHoldTax { get; set; }
        public Double RoundOff { get; set; }
        public Double VendorPayable { get; set; }
        public Double Total { get; set; }

        public Int32 Rights { get; set; }
        public Int32 CreatorCode { get; set; }
        public Int32 Id { get; set; }


        public String Search { get; set; }
    }
}
