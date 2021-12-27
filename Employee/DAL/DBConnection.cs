using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DAL
{
    public class DBConnection
    {
        public DBConnection()
        {

        }
        public SqlConnection CreateConnection()
        {
            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = @"Data Source=LAPTOP-S334D23P\SQLEXPRESS; Initial Catalog=HR;
                      User Id=sa;Password=123";
            return connect;
        }
    }
}
