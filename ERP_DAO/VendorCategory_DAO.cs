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
    public class VendorCategory_DAO
    {
        DBConnect DB = new DBConnect();
        DataSet DS = new DataSet();

        public DataSet VendorCategoryDB(VendorCategory_DTO VC)
        {
            Database Db = new SqlDatabase(DB.Connection());
            DbCommand DbC = Db.GetStoredProcCommand("VendorCategory_SP");
            Db.AddInParameter(DbC, "@VendorCategoryNumber", DbType.Int64, VC.VendorCategoryNumber);
            Db.AddInParameter(DbC, "@VendorCategory", DbType.String, VC.VendorCategory);
            Db.AddInParameter(DbC, "@VC_Description", DbType.String, VC.VC_Description);
            Db.AddInParameter(DbC, "@UnderVCategory", DbType.Int64, VC.UnderVCategory);
            Db.AddInParameter(DbC, "@Rights ", DbType.Int32, VC.Rights);
            Db.AddInParameter(DbC, "@CreatorCode", DbType.Int32, VC.CreatorCode);
            Db.AddInParameter(DbC, "@Id", DbType.Int32, VC.Id);
            DS = Db.ExecuteDataSet(DbC);
            return DS;

        }
    }
}
