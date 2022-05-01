using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace CRUDDemoWithConsoleProram
{
   public class UserService
    {
        public List<UserModel> GetUsers()
        {
            List<UserModel> users = new List<UserModel>();
            SqlConnection sqlConnection = DatabaseConnection.GetConnection();
            string sqlcommand = "select * from users";
            SqlCommand sqlCommand = new SqlCommand(sqlcommand, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();//total 3 users
            while (reader.Read())//0,1,2
            {
                UserModel user = new UserModel()
                {
                    Id = Convert.ToInt32(reader["id"]),
                    UserName = reader["UserName"].ToString(),
                    Email=reader["Email"].ToString(),
                    IsDelete=Convert.ToBoolean(reader["IsDelete"]),
                    CreatedDate=Convert.ToDateTime(reader["CreatedDate"])
                };
                users.Add(user);
            }       
            return users;
        }
        public void SaveUser(UserModel user)
        {
            try
            {
                SqlConnection sqlConnection = DatabaseConnection.GetConnection();
                string sqlquery = $"insert into users values({user.Id},'{user.UserName}','{user.Email}','{user.Password}',0,'{user.CreatedDate.ToString("d")}')";
                SqlCommand sqlCommand = new SqlCommand(sqlquery, sqlConnection);
                int result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("1 record saved successfully");
                }
                else
                {
                    Console.WriteLine("failed when insert record.");
                }
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
        }
        public void DeleteByUserId(int Id)
        {
            try
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                string sqlDeleteQuery = $"Delete from Users where Id={Id}";
                SqlCommand sqlCommand = new SqlCommand(sqlDeleteQuery, connection);
                int result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                    Console.WriteLine("1 record deleted successfully.");
                else
                    Console.WriteLine("failed when record is deleted.");
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
        }

        public void UpdateUserById(UserModel user)//
        {
            try
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                string sqlUpdateQuery = $"update users set UserName='{user.UserName}' where id={user.Id}";
                SqlCommand sqlCommand = new SqlCommand(sqlUpdateQuery, connection);
                int result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                    Console.WriteLine("1 record updated successfully.");
                else
                    Console.WriteLine("failed when record is updated.");
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
        }
    }
}
