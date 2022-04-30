using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDDemoWithConsoleProram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("proram started");

            UserService userService = new UserService();
            List<UserModel> users= userService.GetUsers();
            Console.WriteLine("User Information ");
            Console.WriteLine("Id\tUserName\t\tEmail\t\tIsDelete\t\tCreatedDate");
            foreach (UserModel u in users)
            {
                Console.WriteLine(u.Id + "\t" + u.UserName + "\t\t" + u.Email + "\t\t" + u.IsDelete + "\t\t" + u.CreatedDate);
            }
            Console.WriteLine("press any key to close this window");
            Console.ReadKey();
        }
    }
}
