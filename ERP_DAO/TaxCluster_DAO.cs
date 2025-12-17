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
    public class TaxCluster_DAO
    {
        DBConnect DB = new DBConnect();
        DataSet DS = new DataSet();

        public DataSet TaxClusterDB(TaxCluster_DTO TC)
        {
            Database Db = new SqlDatabase(DB.Connection());
            DbCommand DbC = Db.GetStoredProcCommand("TaxCluster_SP");
            Db.AddInParameter(DbC, "@TaxClusterNumber", DbType.Int64,TC.TaxClusterNumber);
            Db.AddInParameter(DbC, "@TaxCategory", DbType.Int64,TC.TaxCategory);
            Db.AddInParameter(DbC, "@TaxType", DbType.Int64, TC.TaxType);
            Db.AddInParameter(DbC, "@TaxCluster", DbType.String,TC.TaxCluster);
            Db.AddInParameter(DbC, "@ClusterDescription", DbType.String, TC.ClusterDescription);

            Db.AddInParameter(DbC, "@TaxClusterDetailsNumber", DbType.Int64, TC.TaxClusterDetailsNumber);
            Db.AddInParameter(DbC, "@TaxElement", DbType.String, TC.TaxElement);

            Db.AddInParameter(DbC, "@Search", DbType.String, TC.Search);
            Db.AddInParameter(DbC, "@Rights", DbType.Int32,TC.Rights);
            Db.AddInParameter(DbC, "@CreatorCode", DbType.Int32,TC.CreatorCode);
            Db.AddInParameter(DbC, "@Id", DbType.Int32,TC.Id);
            DS = Db.ExecuteDataSet(DbC);
            return DS;
        }
    }
}
