using System;
class TestMethod {
    static void Main () {
        Console.WriteLine ("Hello");
        DrawLine (); //method call/invoke the method (that you define)
        DrawLine ();
        DrawStar ();
        Console.WriteLine("enter you name");
        string inputname=Console.ReadLine();
        //SayHello();//Sematic Error because SayHello Method accept 1 paremeter(string name)
        SayHello(inputname);//welcome ,susu 
        SayHello("Ko Ko");//welcome,Ko Ko
       // SayHello(1); Sematic Error because SayHello accept string data Type Parameter.
    }
    //define your method 
    static void DrawLine () {
        Console.WriteLine ("======================");
    }
    static void DrawStar () {
        Console.WriteLine ("******************************");
    }
    static void SayHello(string yourname){
        Console.WriteLine("Welcome,"+yourname);
    }
}