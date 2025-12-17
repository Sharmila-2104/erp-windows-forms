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
    public class COA_LedgerGroup_DAO
    {
        DBConnect DB = new DBConnect();
        DataSet DS = new DataSet();

        public DataSet COALedgerGroupDB(COA_LedgerGroup_DTO CO)
        {
            Database Db = new SqlDatabase(DB.Connection());
            DbCommand DbC = Db.GetStoredProcCommand("COA_LedgerGroup_SP");
            Db.AddInParameter(DbC, "@LedgerGroupNumber", DbType.Int64, CO.LedgerGroupNumber);
            Db.AddInParameter(DbC, "@LedgerGroup", DbType.String, CO.LedgerGroup);
            Db.AddInParameter(DbC, "@UnderLGroup", DbType.Int64, CO.UnderLGroup);
            Db.AddInParameter(DbC, "@GroupNature", DbType.Int64, CO.GroupNature);
            Db.AddInParameter(DbC, "@Rights", DbType.Int32, CO.Rights);
            Db.AddInParameter(DbC, "@CreatorCode", DbType.Int32, CO.CreatorCode);
            Db.AddInParameter(DbC, "@Id", DbType.Int32, CO.Id);
            DS = Db.ExecuteDataSet(DbC);
            return DS;
        }

    }
}
