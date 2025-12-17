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
    public class Warehouse_DAO
    {
        DBConnect DB = new DBConnect();
        DataSet DS = new DataSet();

        public DataSet WarehouseDB(Warehouse_DTO WH)
        {
            Database Db = new SqlDatabase(DB.Connection());
            DbCommand DbC = Db.GetStoredProcCommand("Warehouse_SP");
            Db.AddInParameter(DbC, "@WarehouseNumber", DbType.Int64, WH.WarehouseNumber);
            Db.AddInParameter(DbC, "@WarehouseCategory", DbType.Int64, WH.WarehouseCategory);
            Db.AddInParameter(DbC, "@WarehouseCode", DbType.String, WH.WarehouseCode);
            Db.AddInParameter(DbC, "@WarehouseDescription", DbType.String, WH.WarehouseDescription);
            Db.AddInParameter(DbC, "@WarehouseGroup", DbType.Int64, WH.WarehouseGroup);
            Db.AddInParameter(DbC, "@Rights", DbType.Int32, WH.Rights);
            Db.AddInParameter(DbC, "@CreatorCode", DbType.Int32, WH.CreatorCode);
            Db.AddInParameter(DbC, "@Id", DbType.Int32, WH.Id);
            DS = Db.ExecuteDataSet(DbC);
            return DS;
        }


    }
}
