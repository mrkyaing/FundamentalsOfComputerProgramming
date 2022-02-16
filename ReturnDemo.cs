using System;
class ReturnDemo{
    static void Main(){
        int i=10;
        Console.WriteLine("Program start.");
        if(i>=10){
            Console.WriteLine("i is greater than 10");
            Console.WriteLine("come from before return statement.");
            return;
        }
        Console.WriteLine("1 statement after return .");
        Console.WriteLine("Hello");
    }
}