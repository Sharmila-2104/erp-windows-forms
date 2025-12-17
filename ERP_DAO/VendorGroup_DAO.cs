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
    public class VendorGroup_DAO
    {
        DBConnect DB = new DBConnect();
        DataSet DS = new DataSet();

        public DataSet VendorGroupDB(VendorGroup_DTO VG)
        {
            Database Db = new SqlDatabase(DB.Connection());
            DbCommand DbC = Db.GetStoredProcCommand("VendorGroup_SP");
            Db.AddInParameter(DbC, "@VendorGroupNumber", DbType.Int64, VG.VendorGroupNumber);
            Db.AddInParameter(DbC, "@VendorGroup", DbType.String, VG.VendorGroup);
            Db.AddInParameter(DbC, "@VG_Description", DbType.String, VG.VG_Description);
            Db.AddInParameter(DbC, "@UnderVGroup", DbType.Int64, VG.UnderVGroup);
            Db.AddInParameter(DbC, "@Rights ", DbType.Int32, VG.Rights);
            Db.AddInParameter(DbC, "@CreatorCode", DbType.Int32, VG.CreatorCode);
            Db.AddInParameter(DbC, "@Id", DbType.Int32, VG.Id);
            DS = Db.ExecuteDataSet(DbC);
            return DS;

        }
    }
}
