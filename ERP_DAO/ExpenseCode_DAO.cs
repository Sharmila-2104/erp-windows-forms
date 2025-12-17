using ERP_DTO;
using ERP_Help;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_DAO
{
    public class ExpenseCode_DAO
    {
        DBConnect DB = new DBConnect();
        DataSet DS = new DataSet();

        public DataSet ExpenseCodeDB(ExpenseCode_DTO E)
        {
            Database Db = new SqlDatabase(DB.Connection());
            DbCommand DbC = Db.GetStoredProcCommand("ExpenseCode_SP");
            Db.AddInParameter(DbC, "@ExpenseCodeNumber", DbType.Int64, E.ExpenseCodeNumber);
            Db.AddInParameter(DbC, "@ExpenseCode", DbType.String, E.ExpenseCode);
            Db.AddInParameter(DbC, "@EC_Description", DbType.String, E.EC_Description);
            Db.AddInParameter(DbC, "@LedgerAccount", DbType.Int64, E.LedgerAccount);
            Db.AddInParameter(DbC, "@Rights", DbType.Int32, E.Rights);
            Db.AddInParameter(DbC, "@CreatorCode", DbType.Int32, E.CreatorCode);
            Db.AddInParameter(DbC, "@Id", DbType.Int32, E.Id);
            DS = Db.ExecuteDataSet(DbC);
            return DS;
        }
    }
}
