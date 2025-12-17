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
    public class COA_Ledger_DAO
    {
        DBConnect DB = new DBConnect();
        DataSet DS = new DataSet();

        public DataSet COA_LedgerDB(COA_Ledger_DTO CO)
        {
            Database Db = new SqlDatabase(DB.Connection());
            DbCommand DbC = Db.GetStoredProcCommand("COA_Ledger_SP");
            Db.AddInParameter(DbC, "@LedgerNumber", DbType.Int64, CO.LedgerNumber);
            Db.AddInParameter(DbC, "@LedgerAccount", DbType.String, CO.LedgerAccount);
            Db.AddInParameter(DbC, "@LedgerName", DbType.String, CO.LedgerName);
            Db.AddInParameter(DbC, "@LedgerGroup ", DbType.String, CO.LedgerGroup);
            Db.AddInParameter(DbC, "@Rights", DbType.Int32, CO.Rights);
            Db.AddInParameter(DbC, "@CreatorCode", DbType.Int32, CO.CreatorCode);
            Db.AddInParameter(DbC, "@Id", DbType.Int32, CO.Id);
            DS = Db.ExecuteDataSet(DbC);
            return DS;
        }

    }
}
