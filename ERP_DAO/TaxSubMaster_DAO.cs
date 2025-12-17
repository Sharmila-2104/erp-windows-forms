using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_Help;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using ERP_DTO;

namespace ERP_DAO
{
    public class TaxSubMaster_DAO
    {
        DBConnect DB = new DBConnect();
        DataSet DS = new DataSet();

        public DataSet TaxSubMasterDB(TaxSubMaster_DTO T)
        {
            Database Db = new SqlDatabase(DB.Connection());
            DbCommand DbC = Db.GetStoredProcCommand("SpTaxSubMaster");
            Db.AddInParameter(DbC, "@Number", DbType.Int64, T.Number);
            Db.AddInParameter(DbC, "@Name", DbType.String, T.Title);
            Db.AddInParameter(DbC, "@Notes", DbType.String, T.Notes);
            Db.AddInParameter(DbC, "@Rights", DbType.Int32, T.Rights);
            Db.AddInParameter(DbC, "@CreatorCode", DbType.Int32, T.CreatorCode);
            Db.AddInParameter(DbC, "@Id", DbType.Int32, T.Id);
            DS = Db.ExecuteDataSet(DbC);
            return DS;
        }

    }
}
