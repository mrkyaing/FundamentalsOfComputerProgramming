using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;
namespace LibraryManagementSystem.DAO
{
   public interface IUserDAO
    {
        UserModel GetUser(string userName, string password);
    }
}
