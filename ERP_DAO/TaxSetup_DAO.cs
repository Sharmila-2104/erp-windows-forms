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
    public class TaxSetup_DAO
    {
        DBConnect DB = new DBConnect();
        DataSet DS = new DataSet();

        public DataSet TaxSetupDB(TaxSetup_DTO TS_DTO)
        {
            Database Db = new SqlDatabase(DB.Connection());
            DbCommand DbC = Db.GetStoredProcCommand("TaxSetup_SP");
            Db.AddInParameter(DbC, "@TaxSetupNumber", DbType.Int64, TS_DTO.TaxSetupNumber);
            Db.AddInParameter(DbC, "@TaxElement", DbType.Int64, TS_DTO.TaxElement);
            Db.AddInParameter(DbC, "@LoadonInventory", DbType.Int32, TS_DTO.LoadonInventory);
            Db.AddInParameter(DbC, "@LoadonInventoryPercent", DbType.Int64, TS_DTO.LoadonInventoryPercent);
            Db.AddInParameter(DbC, "@TaxNature", DbType.String, TS_DTO.TaxNature);

            Db.AddInParameter(DbC, "@TaxSetupDetailsNumber", DbType.Int64, TS_DTO.TaxSetupDetailsNumber);
            Db.AddInParameter(DbC, "@FromDate", DbType.Int64, TS_DTO.FromDate);
            Db.AddInParameter(DbC, "@ToDate", DbType.Int64, TS_DTO.ToDate);
            Db.AddInParameter(DbC, "@GvTaxNature", DbType.Int64, TS_DTO.GvTaxNature);
            Db.AddInParameter(DbC, "@FixedPercent", DbType.Int64, TS_DTO.FixedPercent);
            Db.AddInParameter(DbC, "@HSN", DbType.Int64, TS_DTO.HSN);
            Db.AddInParameter(DbC, "@HSN_Percent", DbType.Int64, TS_DTO.HSN_Percent);
            Db.AddInParameter(DbC, "@SAC", DbType.Int64, TS_DTO.SAC);
            Db.AddInParameter(DbC, "@SAC_Percent", DbType.Int64, TS_DTO.SAC_Percent);
            Db.AddInParameter(DbC, "@Abatement", DbType.Int64, TS_DTO.Abatement);

            Db.AddInParameter(DbC, "@Search", DbType.String, TS_DTO.Search);
            Db.AddInParameter(DbC, "@Rights", DbType.Int32, TS_DTO.Rights);
            Db.AddInParameter(DbC, "@CreatorCode", DbType.Int32, TS_DTO.CreatorCode);
            Db.AddInParameter(DbC, "@Id", DbType.Int32, TS_DTO.Id);
            DS = Db.ExecuteDataSet(DbC);
            return DS;
        }
    }
}
