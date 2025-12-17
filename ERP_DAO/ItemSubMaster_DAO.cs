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
    public class ItemSubMaster_DAO
    {
        DBConnect DB = new DBConnect();
        DataSet DS = new DataSet();

        public DataSet ItemSubMasterDB(ItemSubMaster_DTO I)
        {
            Database Db = new SqlDatabase(DB.Connection());
            DbCommand DbC = Db.GetStoredProcCommand("SpItemSubMaster");
            Db.AddInParameter(DbC, "@Number", DbType.Int64, I.Number);
            Db.AddInParameter(DbC, "@Title", DbType.String, I.Title);
            Db.AddInParameter(DbC, "@Notes", DbType.String, I.Notes);
            Db.AddInParameter(DbC, "@Rights ", DbType.Int32, I.Rights);
            Db.AddInParameter(DbC, "@CreatorCode", DbType.Int32, I.CreatorCode);
            Db.AddInParameter(DbC, "@Id", DbType.Int32, I.Id);
            DS = Db.ExecuteDataSet(DbC);
            return DS;

        }
    }
}
