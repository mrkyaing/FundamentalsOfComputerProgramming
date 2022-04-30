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
    }
}
