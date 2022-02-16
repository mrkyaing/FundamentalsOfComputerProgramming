using System;
class UserInputDemo {
    static void Main () {
        Console.Write ("What is your name?");
        string username = Console.ReadLine (); //Get user's keyboard input value 
        Console.WriteLine ("Hi," + username + "\nWelcome to my app");
    }
}