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
    public class GRNNumber_DAO
    {
        DBConnect DB = new DBConnect();
        DataSet DS = new DataSet();

        public DataSet GRNNumberDB(GRNNumber_DTO G_DTO)
        {
            Database Db = new SqlDatabase(DB.Connection());
            DbCommand DbC = Db.GetStoredProcCommand("GRNNumber_SP");
            Db.AddInParameter(DbC, "@Number", DbType.Int64, G_DTO.Number);
            Db.AddInParameter(DbC, "@GRNNumber", DbType.Int64, G_DTO.GRNNumber);
            Db.AddInParameter(DbC, "@GRNMethod", DbType.Int64, G_DTO.GRNOrderMethod);
            Db.AddInParameter(DbC, "@StartingNumber", DbType.Int32, G_DTO.StartingNumber);
            Db.AddInParameter(DbC, "@NumberofDigits", DbType.Int32, G_DTO.NumberofDigits);
            Db.AddInParameter(DbC, "@PrefilZero", DbType.Int64, G_DTO.PrefilZero);

            Db.AddInParameter(DbC, "@Date", DbType.Int32, G_DTO.Date);
            Db.AddInParameter(DbC, "@Frequency", DbType.String, G_DTO.Frequency);

            Db.AddInParameter(DbC, "@FrequencyNumber", DbType.Int64, G_DTO.FrequencyNumber);

            Db.AddInParameter(DbC, "@Rights ", DbType.Int32, G_DTO.Rights);
            Db.AddInParameter(DbC, "@CreatorCode", DbType.Int32, G_DTO.CreatorCode);
            Db.AddInParameter(DbC, "@Id", DbType.Int32, G_DTO.Id);
            DS = Db.ExecuteDataSet(DbC);
            return DS;
        }
    }
}
