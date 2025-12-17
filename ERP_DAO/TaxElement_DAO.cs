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
    public class TaxElement_DAO
    {
        DBConnect DB = new DBConnect();
        DataSet DS = new DataSet();

        public DataSet TaxElementDB(TaxElement_DTO T)
        {
            Database Db = new SqlDatabase(DB.Connection());
            DbCommand DbC = Db.GetStoredProcCommand("TaxElement_SP");
            Db.AddInParameter(DbC, "@TaxElementNumber", DbType.Int64, T.TaxElementNumber);
            Db.AddInParameter(DbC, "@TaxCategory", DbType.Int64, T.TaxCategory);
            Db.AddInParameter(DbC, "@TaxType", DbType.Int64, T.TaxType);
            Db.AddInParameter(DbC, "@TaxElement", DbType.String, T.TaxElement);
            Db.AddInParameter(DbC, "@ElementDescription", DbType.String, T.ElementDescription);
            Db.AddInParameter(DbC, "@COA", DbType.Int64, T.COA);
            Db.AddInParameter(DbC, "@Rights", DbType.Int32, T.Rights);
            Db.AddInParameter(DbC, "@CreatorCode", DbType.Int32, T.CreatorCode);
            Db.AddInParameter(DbC, "@Id", DbType.Int32, T.Id);
            DS = Db.ExecuteDataSet(DbC);
            return DS;
        }
    }
}
