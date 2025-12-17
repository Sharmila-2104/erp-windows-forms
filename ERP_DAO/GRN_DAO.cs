using ERP_DTO;
using ERP_Help;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_DAO
{
    public class GRN_DAO
    {
        DBConnect DB = new DBConnect();
        DataSet DS = new DataSet();
        
        public DataSet GRNDB(GRN_DTO GRN_DTO)
        {
            Database Db = new SqlDatabase(DB.Connection());
            DbCommand DbC = Db.GetStoredProcCommand("GRN_SP");
            Db.AddInParameter(DbC, "@Number", DbType.Int64, GRN_DTO.Number);
            Db.AddInParameter(DbC, "@GRN_Number", DbType.String, GRN_DTO.GRN_Number);
            Db.AddInParameter(DbC, "@GRN_Date", DbType.Int32, GRN_DTO.GRN_Date);

            Db.AddInParameter(DbC, "@PurchaseInvoiceNo", DbType.String, GRN_DTO.PurchaseInvoiceNo);
            Db.AddInParameter(DbC, "@PurchaseInvoiceDate", DbType.Int32, GRN_DTO.PurchaseInvoiceDate);
            Db.AddInParameter(DbC, "@VendorName", DbType.String, GRN_DTO.VendorName);
            Db.AddInParameter(DbC, "@TaxCluster", DbType.Int64, GRN_DTO.TaxCluster);
            Db.AddInParameter(DbC, "@WH_TaxCode", DbType.Int64, GRN_DTO.WH_TaxCode);
            Db.AddInParameter(DbC, "@MaterialSegregation", DbType.Int64, GRN_DTO.MaterialSegregation);

            Db.AddInParameter(DbC, "@ItemCode", DbType.Int64, GRN_DTO.ItemCode);
            Db.AddInParameter(DbC, "@UoM", DbType.Int64, GRN_DTO.UoM);
            Db.AddInParameter(DbC, "@Qty", DbType.Double, GRN_DTO.Qty);
            Db.AddInParameter(DbC, "@UnitPrice", DbType.Double, GRN_DTO.UnitPrice);
            Db.AddInParameter(DbC, "@Amount", DbType.Double, GRN_DTO.Amount);
            Db.AddInParameter(DbC, "@ExpenseCode", DbType.Int64, GRN_DTO.ExpenseCode);
            Db.AddInParameter(DbC, "@ExpenseValue", DbType.Double, GRN_DTO.ExpenseValue);
            Db.AddInParameter(DbC, "@HSN", DbType.Int64, GRN_DTO.HSN);
            Db.AddInParameter(DbC, "@GST_TaxAmount", DbType.Double, GRN_DTO.GST_TaxAmount);
            Db.AddInParameter(DbC, "@Percent", DbType.Double, GRN_DTO.Percent);
            Db.AddInParameter(DbC, "@WH_TaxAmount", DbType.Double, GRN_DTO.WH_TaxAmount);

            Db.AddInParameter(DbC, "@InvoiceAmount", DbType.Double, GRN_DTO.InvoiceAmount);
            Db.AddInParameter(DbC, "@WithHoldTax", DbType.Double, GRN_DTO.WithHoldTax);
            Db.AddInParameter(DbC, "@Total", DbType.Double, GRN_DTO.Total);
            Db.AddInParameter(DbC, "@RoundOff", DbType.Double, GRN_DTO.RoundOff);
            Db.AddInParameter(DbC, "@VendorPayable", DbType.Double, GRN_DTO.VendorPayable);
            
            Db.AddInParameter(DbC, "@Search", DbType.String, GRN_DTO.Search);

            Db.AddInParameter(DbC, "@CreatorCode", DbType.Int32, GRN_DTO.CreatorCode);
            Db.AddInParameter(DbC, "@Id", DbType.Int32, GRN_DTO.Id);
            DS = Db.ExecuteDataSet(DbC);
            return DS;
        }


    }
}
