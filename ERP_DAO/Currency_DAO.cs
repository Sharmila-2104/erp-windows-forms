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
    public class Currency_DAO
    {
        DBConnect DB = new DBConnect();
        DataSet DS = new DataSet();

        public DataSet CurrencyDB(Currency_DTO C)
        {
            Database Db = new SqlDatabase(DB.Connection());
            DbCommand DbC = Db.GetStoredProcCommand("Currency_SP");
            Db.AddInParameter(DbC, "@CurrencyNumber", DbType.Int64, C.CurrencyNumber);
            Db.AddInParameter(DbC, "@CurrencyCode", DbType.String, C.CurrencyCode);
            Db.AddInParameter(DbC, "@FormalName", DbType.String, C.FormalName);
            Db.AddInParameter(DbC, "@Symbol", DbType.String, C.Symbol);
            Db.AddInParameter(DbC, "@DecimalPlaces", DbType.Int32, C.DecimalPlaces);
            Db.AddInParameter(DbC, "@DecimalPortionName", DbType.String, C.DecimalPortionName);
            Db.AddInParameter(DbC, "@CurrencyLocation", DbType.Int32, C.CurrencyLocation);
            Db.AddInParameter(DbC, "@Rights", DbType.Int32, C.Rights);
            Db.AddInParameter(DbC, "@CreatorCode", DbType.Int32, C.CreatorCode);
            Db.AddInParameter(DbC, "@Id", DbType.Int32, C.Id);
            DS = Db.ExecuteDataSet(DbC);
            return DS;
        }


    }
}
