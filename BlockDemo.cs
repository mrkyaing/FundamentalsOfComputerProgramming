using System;
class BlockDemo{
   static double d=200.5;//Global variable 
    static void Main()
    {
        int x=100;//declare variable (eg of simple statement ) >>Local variable 
        int y=20;//declare variable 
        if(x>y)//check condition statement(if)
        {
            int z=20;
            d++;
            Console.WriteLine("x > y is ok");
            Console.WriteLine("Hi,It is me");
            Console.WriteLine("Nice to see you");
            Console.WriteLine(z);
        }//end of if statement
        Console.WriteLine("program finished");
       //Console.WriteLine(z);//error will occur because z variable is out of scope in if block
       Console.WriteLine(x);
       d++;
       Console.WriteLine(d);//200.7
    }
}