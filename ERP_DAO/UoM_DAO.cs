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
    public class UoM_DAO
    {
        DBConnect DB = new DBConnect();
        DataSet DS = new DataSet();
        public DataSet UoMDB(UoM_DTO U)
        {
            Database Db = new SqlDatabase(DB.Connection());
            DbCommand DbC = Db.GetStoredProcCommand("UoM_SP");
            Db.AddInParameter(DbC, "@UnitNumber", DbType.Int64, U.UnitNumber);
            Db.AddInParameter(DbC, "@UnitCode", DbType.String, U.UnitCode);
            Db.AddInParameter(DbC, "@UnitDescription", DbType.String, U.UnitDescription);
            Db.AddInParameter(DbC, "@DecimalPlaces", DbType.Int64, U.DecimalPlaces);
            Db.AddInParameter(DbC, "@Rights", DbType.Int32, U.Rights);
            Db.AddInParameter(DbC, "@CreatorCode", DbType.Int32, U.CreatorCode);
            Db.AddInParameter(DbC, "@Id", DbType.Int32, U.Id);
            DS = Db.ExecuteDataSet(DbC);
            return DS;
        }
    }
}
