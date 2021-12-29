using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranTuanKiet_QLNS.DAO
{
    public class DbConnection
    {
        public DbConnection()
        {
        }
        public SqlConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection(@"Data Source =TRAN-TUAN-KIET\SQLEXPRESS; Initial Catalog=QLNS_1;
                       User id = sa; Password = sa");
            return conn;

        }
    }
}
