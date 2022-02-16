<<<<<<< HEAD
using System;
class StringAPIDemo {
    static void Main () {
        string sms = "how are you?";
        string sms2 = (string) sms.Clone (); //(string) means type Convertion from Object Type to string type
        Console.WriteLine (sms2); //how are you?
        bool result = sms.Contains ("z");
        Console.WriteLine (result); //False
        //DateTime is also Object Type 
        //ToShortDateString() is method of DateType Object 
        Console.WriteLine (DateTime.Now.ToShortDateString ());
        string name = "Mg Mg";
        string name2 = "zaw zaw";
        int compareResult = string.Compare (name, name2);
        Console.WriteLine (compareResult); //-1
        bool equalResult = name.Equals (name2); //False
        Console.WriteLine (equalResult); //False
        string FullName = string.Concat (name, name2); //Mg Mgzaw zaw
        Console.WriteLine (FullName);
        string userName = "   Zin Min Oo  ";
        Console.WriteLine (userName.Trim ()); //Zin Min Oo
        string ok = "welcome to home"; //start positon 1 (position of w 1)
        string ok2 = ok.Substring (1);
        Console.WriteLine (ok2); //to home
    } //end of Main Method 
=======
using System;
class StringAPIDemo {
    static void Main () {
        string sms = "how are you?";
        string sms2 = (string) sms.Clone (); //(string) means type Convertion from Object Type to string type
        Console.WriteLine (sms2); //how are you?
        bool result = sms.Contains ("z");
        Console.WriteLine (result); //False
        //DateTime is also Object Type 
        //ToShortDateString() is method of DateType Object 
        Console.WriteLine (DateTime.Now.ToShortDateString ());
        string name = "Mg Mg";
        string name2 = "zaw zaw";
        int compareResult = string.Compare (name, name2);
        Console.WriteLine (compareResult); //-1
        bool equalResult = name.Equals (name2); //False
        Console.WriteLine (equalResult); //False
        string FullName = string.Concat (name, name2); //Mg Mgzaw zaw
        Console.WriteLine (FullName);
        string userName = "   Zin Min Oo  ";
        Console.WriteLine (userName.Trim ()); //Zin Min Oo
        string ok = "welcome to home"; //start positon 1 (position of w 1)
        string ok2 = ok.Substring (1);
        Console.WriteLine (ok2); //to home
    } //end of Main Method 
>>>>>>> f9be41793b5398067f40c0c63932a59e312d6aec
} //end of class