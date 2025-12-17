using ERP_DTO;
using ERP_Help;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_DAO
{
    public class VendorSubMaster_DAO
    {
        DBConnect DB = new DBConnect();
        DataSet DS = new DataSet();

        public DataSet VendorSubMasterDB(VendorSubMaster_DTO V)
        {
            Database Db = new SqlDatabase(DB.Connection());
            DbCommand DbC = Db.GetStoredProcCommand("SpVendorSubMaster");
            Db.AddInParameter(DbC, "@Number", DbType.Int64, V.Number);
            Db.AddInParameter(DbC, "@Title", DbType.String, V.Title);
            Db.AddInParameter(DbC, "@Notes", DbType.String, V.Notes);
            Db.AddInParameter(DbC, "@Rights ", DbType.Int32, V.Rights);
            Db.AddInParameter(DbC, "@CreatorCode", DbType.Int32, V.CreatorCode);
            Db.AddInParameter(DbC, "@Id", DbType.Int32, V.Id);
            DS = Db.ExecuteDataSet(DbC);
            return DS;

        }
    }
}

