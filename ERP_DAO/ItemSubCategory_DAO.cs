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
    public class ItemSubCategory_DAO
    {
        DBConnect DB = new DBConnect();
        DataSet DS = new DataSet();
        public DataSet ItemSubCategoryDB(ItemSubCategory_DTO IS)
        {
            Database Db = new SqlDatabase(DB.Connection());
            DbCommand DbC = Db.GetStoredProcCommand("ItemSubCategory_SP");
            Db.AddInParameter(DbC, "@ItemSubCategoryNumber", DbType.Int64, IS.ItemSubCategoryNumber);
            Db.AddInParameter(DbC, "@ItemSubCategory", DbType.String, IS.ItemSubCategory);
            Db.AddInParameter(DbC, "@ISC_Description", DbType.String, IS.ISC_Description);
            Db.AddInParameter(DbC, "@UnderISubCategory ", DbType.Int64, IS.UnderISubCategory);
            Db.AddInParameter(DbC, "@Rights", DbType.Int32, IS.Rights);
            Db.AddInParameter(DbC, "@CreatorCode", DbType.Int32, IS.CreatorCode);
            Db.AddInParameter(DbC, "@Id", DbType.Int32, IS.Id);
            DS = Db.ExecuteDataSet(DbC);
            return DS;
        }

    }
}
