using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ModelLayer.Models;

namespace ModelLayer.DatabaseFacades
{
    public static class FirmDatabaseFacade
    {
        public static List<Firm> GetFirmsFromCompany(int Company) {
            SqlConnection connection = DatabaseConnection.Connect();
            
            List<Firm> firms = new List<Firm>();

            try {
                connection.Open();

                SqlCommand command = new SqlCommand("GetFirmsFromCompany", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) {
                    while (reader.Read()) {
                        firms.Add(new Firm((int)reader["CVRNR"], (string)reader["Name"], (int)reader["Telephone"]));
                    }
                }
            }
            catch (Exception e) {
                throw e;
            }
            finally {
                connection.Close();
                connection.Dispose();
            }

            return firms;
        }
    }
}
