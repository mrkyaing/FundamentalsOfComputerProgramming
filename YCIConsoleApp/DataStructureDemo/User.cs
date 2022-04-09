using System;
namespace DataStructureDemo
{
  public  class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public void DisplayUserInfo()
        {
            Console.WriteLine("user information here");
            Console.WriteLine("User Name :" + Name);
            Console.WriteLine("User Email :" + Email);
            Console.Write("User Password :");
            ShowPasswordInStarFormat(Password.Length);//Method Invoke 
        }
        //Method Defination 
        private void ShowPasswordInStarFormat(int passwordCount)
        {
            for(int i = 1; i <= passwordCount; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
