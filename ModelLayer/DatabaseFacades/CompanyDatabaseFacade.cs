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
    public static class CompanyDatabaseFacade
    {

        public static List<Company> GetAllCompanyNames()
        {
            List<Company> tempCompanyList = new List<Company>();

            SqlConnection connection = DatabaseConnection.Connect();

            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("GetAllCompanies", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tempCompanyList.Add(new Company(int.Parse(""+reader["id"]), (string)reader["Name"]));
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
            return tempCompanyList;
        }

    }
}
