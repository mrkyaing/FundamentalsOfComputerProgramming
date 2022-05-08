using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DAO
{
   public class DbConnection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "Server=localhost;Initial Catalog=LibMgtDb;User Id=sa;Password=sasa";
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                return con;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
