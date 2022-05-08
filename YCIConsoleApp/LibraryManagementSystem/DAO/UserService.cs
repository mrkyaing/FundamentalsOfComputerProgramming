using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DAO
{
    public class UserService : IUserDAO
    {
       public UserModel GetUser(string userName,string password)
        {
            UserModel user = new UserModel();
            SqlConnection connection = DbConnection.GetConnection();
            string sqlselectQuery = $"select * from [users] where userName={userName} and password={password}";
            SqlCommand sqlCommand = new SqlCommand(sqlselectQuery, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();//total 1 user
            while (reader.Read())//0
            {
                user.Id = Convert.ToInt32(reader["Id"]);
                user.Email = reader["Email"].ToString();
                user.UserName = reader["UserName"].ToString();
            }
            return user;
        }
    }
}
