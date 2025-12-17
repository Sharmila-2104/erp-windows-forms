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
    public class WithholdTax_DAO
    {
        DBConnect DB = new DBConnect();
        DataSet DS = new DataSet();

        public DataSet WithholdTaxDB(WithholdTax_DTO WHT)
        {
            Database Db = new SqlDatabase(DB.Connection());
            DbCommand DbC = Db.GetStoredProcCommand("WithholdTax_SP");
            Db.AddInParameter(DbC, "@WithholdtaxNumber", DbType.Int64,WHT.WithholdtaxNumber);
            Db.AddInParameter(DbC, "@TaxCategory", DbType.Int64,WHT.TaxCategory);           
            Db.AddInParameter(DbC, "@TaxType", DbType.Int64,WHT.TaxType);
            Db.AddInParameter(DbC, "@WH_TaxCode", DbType.String,WHT.WH_TaxCode);
            Db.AddInParameter(DbC, "@WH_TaxDescription", DbType.String,WHT.WH_TaxDescription);
            Db.AddInParameter(DbC, "@WH_TaxImpact", DbType.Int64,WHT.WH_TaxImpact);
            Db.AddInParameter(DbC, "@Rights", DbType.Int32, WHT.Rights);
            Db.AddInParameter(DbC, "@CreatorCode", DbType.Int32,WHT.CreatorCode);
            Db.AddInParameter(DbC, "@Id", DbType.Int32, WHT.Id);
            DS = Db.ExecuteDataSet(DbC);
            return DS;
        }
    }
}
