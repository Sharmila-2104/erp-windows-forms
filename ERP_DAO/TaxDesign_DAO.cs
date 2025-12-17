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
    public class TaxDesign_DAO
    {
       DBConnect DB = new DBConnect();
            DataSet DS = new DataSet();

            public DataSet TaxDesignDB(TaxDesign_DTO TD_DTO)
            {
                Database Db = new SqlDatabase(DB.Connection());
                DbCommand DbC = Db.GetStoredProcCommand("TaxDesign_SP");
                Db.AddInParameter(DbC, "@TaxDesignNumber", DbType.Int64, TD_DTO.TaxDesignNumber);
                Db.AddInParameter(DbC, "@TaxCluster", DbType.Int64, TD_DTO.TaxCluster);

                Db.AddInParameter(DbC, "@TaxDesignDetailsNumber", DbType.Int64, TD_DTO.TaxDesignDetailsNumber);
                Db.AddInParameter(DbC, "@TaxClusterDetailsNumber", DbType.Int64, TD_DTO.TaxClusterDetailsNumber);
                Db.AddInParameter(DbC, "@Index", DbType.Int64, TD_DTO.Index);
                Db.AddInParameter(DbC, "@LoadonInventory", DbType.Int32, TD_DTO.LoadonInventory);
                Db.AddInParameter(DbC, "@LoadonInventoryPercent", DbType.Double, TD_DTO.LoadonInventoryPercent);
                Db.AddInParameter(DbC, "@TaxNature", DbType.Int64, TD_DTO.TaxNature);
                Db.AddInParameter(DbC, "@ChargeableBasis", DbType.Int64, TD_DTO.ChargeableBasis);
                Db.AddInParameter(DbC, "@CalculationFactors", DbType.String, TD_DTO.CalculationFactors);

                Db.AddInParameter(DbC, "@Rights", DbType.Int32, TD_DTO.Rights);
                Db.AddInParameter(DbC, "@CreatorCode", DbType.Int32, TD_DTO.CreatorCode);
                Db.AddInParameter(DbC, "@Id", DbType.Int32, TD_DTO.Id);
                DS = Db.ExecuteDataSet(DbC);
                return DS;
            }
       
    }
}
