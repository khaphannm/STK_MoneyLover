using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STK
{
    class Utilities
    {
        public static SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=MINH-KHA\SQLEXPRESS;Initial Catalog=db_Money;Integrated Security=True");
        }
    }
}
