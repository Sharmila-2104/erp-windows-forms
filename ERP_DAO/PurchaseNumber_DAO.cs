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
    public class PurchaseNumber_DAO
    {
        DBConnect DB = new DBConnect();
        DataSet DS = new DataSet();

        public DataSet PurchaseNumberDB(PurchaseNumber_DTO P_DTO)
        {
            Database Db = new SqlDatabase(DB.Connection());
            DbCommand DbC = Db.GetStoredProcCommand("PurchaseNumber_SP");
            Db.AddInParameter(DbC, "@Number", DbType.Int64, P_DTO.Number);
            Db.AddInParameter(DbC, "@PurchaseNumber", DbType.Int64, P_DTO.PurchaseNumber);
            Db.AddInParameter(DbC, "@PurchaseOrderMethod", DbType.Int64, P_DTO.PurchaseOrderMethod);
            Db.AddInParameter(DbC, "@StartingNumber", DbType.Int32, P_DTO.StartingNumber);
            Db.AddInParameter(DbC, "@NumberofDigits", DbType.Int32, P_DTO.NumberofDigits);
            Db.AddInParameter(DbC, "@PrefilZero", DbType.Int64, P_DTO.PrefilZero);

            Db.AddInParameter(DbC, "@Date", DbType.Int32, P_DTO.Date);
            Db.AddInParameter(DbC, "@Frequency", DbType.String, P_DTO.Frequency);

            Db.AddInParameter(DbC, "@FrequencyNumber", DbType.Int64, P_DTO.FrequencyNumber);

            Db.AddInParameter(DbC, "@Rights ", DbType.Int32, P_DTO.Rights);
            Db.AddInParameter(DbC, "@CreatorCode", DbType.Int32, P_DTO.CreatorCode);
            Db.AddInParameter(DbC, "@Id", DbType.Int32, P_DTO.Id);
            DS = Db.ExecuteDataSet(DbC);
            return DS;
        }
    }
}
