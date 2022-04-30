using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace CRUDDemoWithConsoleProram
{
  public  class DatabaseConnection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "Server=localhost;Initial Catalog=SimpleDB;User Id=sa;Password=sasa";
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                return con;
            }catch(SqlException ex)
            {
                throw ex;
            }
        }
    }
}
