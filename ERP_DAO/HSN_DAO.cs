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
    public class HSN_DAO
    {
        DBConnect DB = new DBConnect();
        DataSet DS = new DataSet();

        HSN_DTO HSN = new HSN_DTO();

        public DataSet HSNDB(HSN_DTO HSN)
        {
            Database Db = new SqlDatabase(DB.Connection());
            DbCommand DbC = Db.GetStoredProcCommand("HSN_SP");
            Db.AddInParameter(DbC, "@HSN_Number", DbType.Int64, HSN.HSN_Number);
            Db.AddInParameter(DbC, "@HSN_Code", DbType.String, HSN.HSN_Code);
            Db.AddInParameter(DbC, "@Description", DbType.String, HSN.Description);
            Db.AddInParameter(DbC, "@Rights", DbType.Int32, HSN.Rights);
            Db.AddInParameter(DbC, "@CreatorCode", DbType.Int32, HSN.CreatorCode);
            Db.AddInParameter(DbC, "@Id", DbType.Int32, HSN.Id);
            DS = Db.ExecuteDataSet(DbC);
            return DS;
        }
    }
}
