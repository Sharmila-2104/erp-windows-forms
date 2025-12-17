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
    public class ItemCategory_DAO
    {

        DBConnect DB = new DBConnect();
        DataSet DS = new DataSet();

        ItemCategory_DTO IC = new ItemCategory_DTO();

        public DataSet ItemCategoryDB(ItemCategory_DTO IC)
        {
            Database Db = new SqlDatabase(DB.Connection());
            DbCommand DbC = Db.GetStoredProcCommand("ItemCategory_SP");
            Db.AddInParameter(DbC, "@ItemCategoryNumber", DbType.Int64, IC.ItemCategoryNumber);
            Db.AddInParameter(DbC, "@ItemCategory", DbType.String, IC.ItemCategory);
            Db.AddInParameter(DbC, "@IC_Description", DbType.String, IC.IC_Description);
            Db.AddInParameter(DbC, "@UnderICategory ", DbType.Int64, IC.UnderICategory);
            Db.AddInParameter(DbC, "@Rights", DbType.Int32, IC.Rights);
            Db.AddInParameter(DbC, "@CreatorCode", DbType.Int32, IC.CreatorCode);
            Db.AddInParameter(DbC, "@Id", DbType.Int32, IC.Id);
            DS = Db.ExecuteDataSet(DbC);
            return DS;
        }

    }
}
