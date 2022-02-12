using System;
class IfDemo {
    static void Main () {
        int grade = 20;
        if (grade > 40) {
            Console.WriteLine ("Passed in exam.");
        } else {
            Console.WriteLine ("Failed in exam.");
        }
        string username = "admin1";
        string password = "admin@123";
        
        if (username == "admin" && password == "admin@123") {
            Console.WriteLine ("you are logined as Admin");
        }
        else{
            Console.WriteLine ("user name or password is wrong");
        }

        if(username=="admin"){
            Console.WriteLine("you are admin");
        }
    }
}