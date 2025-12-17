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
    public class Purchase_DAO
    {
        DBConnect DB = new DBConnect();
        DataSet DS = new DataSet();
        public DataSet PurchaseDB(Purchase_DTO P_DTO)
        {
            Database Db = new SqlDatabase(DB.Connection());
            DbCommand DbC = Db.GetStoredProcCommand("Purchase_SP");
            Db.AddInParameter(DbC, "@Number", DbType.Int64, P_DTO.Number);
            Db.AddInParameter(DbC, "@PurchaseOrderNo", DbType.String, P_DTO.PurchaseOrderNo);
            Db.AddInParameter(DbC, "@PoDate", DbType.Int64, P_DTO.PoDate);
            Db.AddInParameter(DbC, "@VendorCode", DbType.Int64, P_DTO.VendorCode);
            Db.AddInParameter(DbC, "@IsImportOrder", DbType.Int64, P_DTO.IsImportOrder);
            Db.AddInParameter(DbC, "@Currency", DbType.Int64, P_DTO.Currency);
            Db.AddInParameter(DbC, "@MaterialSegregation", DbType.Int64, P_DTO.MaterialSegregation);
            Db.AddInParameter(DbC, "@PaymentTerms", DbType.String, P_DTO.PaymentTerms);
            Db.AddInParameter(DbC, "@PaymentMethod", DbType.String, P_DTO.PaymentMethod);
            Db.AddInParameter(DbC, "@DeliveryTerms", DbType.String, P_DTO.DeliveryTerms);
            Db.AddInParameter(DbC, "@DeliveryMode", DbType.String, P_DTO.DeliveryMode);
            Db.AddInParameter(DbC, "@Tax", DbType.String, P_DTO.Tax);
            Db.AddInParameter(DbC, "@Inspection", DbType.String, P_DTO.Inspection);
            Db.AddInParameter(DbC, "@TechnicalDeliveryConditions", DbType.String, P_DTO.TechnicalDeliveryConditions);
            //Db.AddInParameter(DbC, "@Remarks", DbType.String, P_DTO.Remarks);

            Db.AddInParameter(DbC, "@PurchaseNumber", DbType.Int64, P_DTO.PurchaseNumber);
            Db.AddInParameter(DbC, "@PurchaseItemNumber", DbType.Int64, P_DTO.PurchaseItemNumber);
            Db.AddInParameter(DbC, "@ExpenseCode", DbType.Int64, P_DTO.ExpenseCode);
            Db.AddInParameter(DbC, "@Remarks", DbType.String, P_DTO.Remarks);
            Db.AddInParameter(DbC, "@Occurrence", DbType.Int64, P_DTO.Occurrence);
            Db.AddInParameter(DbC, "@ChargeableMethod", DbType.Int64, P_DTO.ChargeableMethod);
            Db.AddInParameter(DbC, "@ExpenseBase", DbType.Double, P_DTO.ExpenseBase);
            Db.AddInParameter(DbC, "@Allocate", DbType.Int64, P_DTO.Allocate);
            Db.AddInParameter(DbC, "@LedgerAccount", DbType.Int64, P_DTO.LedgerAccount);

            Db.AddInParameter(DbC, "@ItemCode", DbType.Int64, P_DTO.ItemCode);
            Db.AddInParameter(DbC, "@UoM", DbType.Int64, P_DTO.UoM);
            Db.AddInParameter(DbC, "@PO_Qty", DbType.Double, P_DTO.PO_Qty);
            Db.AddInParameter(DbC, "@UnitPrice", DbType.Double, P_DTO.UnitPrice);
            Db.AddInParameter(DbC, "@Amount", DbType.Double, P_DTO.Amount);
            Db.AddInParameter(DbC, "@DeliveryDate", DbType.Int32, P_DTO.DeliveryDate);


            Db.AddInParameter(DbC, "@Search", DbType.String, P_DTO.Search);
            Db.AddInParameter(DbC, "@Rights ", DbType.Int32, P_DTO.Rights);
            Db.AddInParameter(DbC, "@CreatorCode", DbType.Int32, P_DTO.CreatorCode);
            Db.AddInParameter(DbC, "@Id", DbType.Int32, P_DTO.Id);
            DS = Db.ExecuteDataSet(DbC);
            return DS;
        }
    }
}
