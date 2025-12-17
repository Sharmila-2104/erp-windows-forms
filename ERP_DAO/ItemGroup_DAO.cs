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
    public class ItemGroup_DAO
    {
        DBConnect DB = new DBConnect();
        DataSet DS = new DataSet();

        public DataSet ItemGroupDB(ItemGroup_DTO IG)
        {
            Database Db = new SqlDatabase(DB.Connection());
            DbCommand DbC = Db.GetStoredProcCommand("ItemGroup_SP");
            Db.AddInParameter(DbC, "@ItemGroupNumber", DbType.Int64, IG.ItemGroupNumber);
            Db.AddInParameter(DbC, "@ItemGroup", DbType.String, IG.ItemGroup);
            Db.AddInParameter(DbC, "@IG_Description", DbType.String, IG.IG_Description);
            Db.AddInParameter(DbC, "@UnderIGroup", DbType.Int64, IG.UnderIGroup);
            Db.AddInParameter(DbC, "@MaterialOwnership", DbType.Int64, IG.MaterialOwnership);
            Db.AddInParameter(DbC, "@PurchaseWarehouse", DbType.Int64, IG.PurchaseWarehouse);
            Db.AddInParameter(DbC, "@SaleWarehouse", DbType.Int64, IG.SaleWarehouse);
            Db.AddInParameter(DbC, "@MaterialClassification", DbType.Int64, IG.MaterialClassification);
            Db.AddInParameter(DbC, "@Rights", DbType.Int32, IG.Rights);
            Db.AddInParameter(DbC, "@CreatorCode", DbType.Int32, IG.CreatorCode);
            Db.AddInParameter(DbC, "@Id", DbType.Int32, IG.Id);
            DS = Db.ExecuteDataSet(DbC);
            return DS;
        }

    }
}
