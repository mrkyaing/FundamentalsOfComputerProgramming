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
        public List<UserModel> GetAllUser()
        {
            List<UserModel> users = new List<UserModel>();
            SqlConnection connection = DbConnection.GetConnection();
            string sqlselectQuery = $"select * from [users] ";
            SqlCommand sqlCommand = new SqlCommand(sqlselectQuery, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();//get total users
            while (reader.Read())//0
            {
                UserModel user = new UserModel()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Email = reader["Email"].ToString(),
                    UserName = reader["UserName"].ToString(),
                    Role = reader["Role"].ToString(),
                };
                users.Add(user);    
            }
            return users;
        }

        public int GetMaxUserId()
        {
            int maxId = 0;
            SqlConnection connection = DbConnection.GetConnection();
            string sqlselectQuery = $"select MAX(id) as Id from [users]";
            SqlCommand sqlCommand = new SqlCommand(sqlselectQuery, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();//total 1 user
            while (reader.Read())
            {
                maxId = Convert.ToInt32(reader["Id"]);              
            }
            return maxId;
        }

        public UserModel GetUser(string userName,string password)//admin >> admin@123
        {
            UserModel user = new UserModel();
            SqlConnection connection = DbConnection.GetConnection();
            string sqlselectQuery = $"select * from [users] where userName='{userName}' and password='{password}'";
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

        public void SaveUser(UserModel user)
        {
            try
            {
                SqlConnection con = DbConnection.GetConnection();
                string sqlInsertQuery = $"insert into users values({user.Id},'{user.UserName}','{user.Email}','{user.Password}','{user.Role}')";
                SqlCommand sqlCommand = new SqlCommand(sqlInsertQuery, con);
                int result = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
