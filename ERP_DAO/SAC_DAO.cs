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
    public class SAC_DAO
    {
        DBConnect DB = new DBConnect();
        DataSet DS = new DataSet();

        public DataSet SACDB(SAC_DTO SAC)
        {
            Database Db = new SqlDatabase(DB.Connection());
            DbCommand DbC = Db.GetStoredProcCommand("SAC_SP");
            Db.AddInParameter(DbC, "@SAC_Number", DbType.Int64, SAC.SAC_Number);
            Db.AddInParameter(DbC, "@SAC_Code", DbType.String, SAC.SAC_Code);
            Db.AddInParameter(DbC, "@Description", DbType.String, SAC.Description);
            Db.AddInParameter(DbC, "@Rights", DbType.Int32, SAC.Rights);
            Db.AddInParameter(DbC, "@CreatorCode", DbType.Int32, SAC.CreatorCode);
            Db.AddInParameter(DbC, "@Id", DbType.Int32, SAC.Id);
            DS = Db.ExecuteDataSet(DbC);
            return DS;
        }

    }
}
