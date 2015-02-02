using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.DatabaseFacades
{
    static class DatabaseConnection
    {
        private static string _connectionString = "Server=ealdb1.eal.local; User ID=ejl02_usr; Password=Baz1nga2";

        public static SqlConnection Connect()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            return connection;
        }
    }
}
