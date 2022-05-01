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
            Console.WriteLine("This Program is CRUD(Create,Reterive,Update,Delete) Process");
            string inputstatus = "";   
            programStart:
            Console.WriteLine("please choose 1(Insert),2(Show),3(Delete),4(Update)");
            UserService userService = new UserService();
            UserModel usermodel = new UserModel();
            inputstatus = Console.ReadLine();
            bool IsContinute = true;
            while (IsContinute)
            {
                switch (inputstatus)
                {
                    case "1":
                        {
                            Console.Write("Enter User Id");
                            usermodel.Id = int.Parse(Console.ReadLine());
                            Console.Write("Enter User Name");
                            usermodel.UserName = (Console.ReadLine());
                            Console.Write("Enter User Email");
                            usermodel.Email = (Console.ReadLine());
                            Console.Write("Enter User Passwrod");
                            usermodel.Password = (Console.ReadLine());
                            Console.Write("Enter CreatedDate");
                            usermodel.CreatedDate = Convert.ToDateTime(Console.ReadLine());
                            userService.SaveUser(usermodel);
                            bool result = DecisionForNextTime();
                            if (result)
                                goto programStart;
                            else IsContinute = false;
                        }
                        break;
                    case "2":
                        {
                            List<UserModel> users = userService.GetUsers();
                            Console.WriteLine("User Information ");
                            Console.WriteLine("Id\tUserName\t\tEmail\t\tIsDelete\t\tCreatedDate");
                            foreach (UserModel u in users)
                            {
                                Console.WriteLine(u.Id + "\t" + u.UserName + "\t\t" + u.Email + "\t\t" + u.IsDelete + "\t\t" + u.CreatedDate);
                            }
                            bool result = DecisionForNextTime();
                            if (result)
                                goto programStart;
                            else 
                                IsContinute = false;
                        }
                        break;
                    case "3":
                        {
                            Console.WriteLine("please type user id to delete");
                            int id = int.Parse(Console.ReadLine());
                            userService.DeleteByUserId(id);
                            goto case "2";
                        }
                    case "4":
                        {
                            Console.WriteLine("please type user id to update");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter your User Name");//Aung zaw
                            string username = Console.ReadLine();//Aung zaw
                            UserModel user = new UserModel();
                            user.Id = id;//7
                            user.UserName = username;//Aung zaw
                            userService.UpdateUserById(user);
                            goto case "2";
                        }
                    default: Console.WriteLine("Invalid User input(we Only accept 1,2,3,4 Numbers)");
                        goto programStart;
                }
            }
            
            Console.WriteLine("press any key to close this window");
            Console.ReadKey();
        }
        private static bool DecisionForNextTime()
        {
            Console.WriteLine("Do you want to do another process(y=yes,n=No)?");
            string ques = Console.ReadLine();
            if (ques.Equals("y")) 
                return true;
            else
                return false;
             
        }
    }
}
