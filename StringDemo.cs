using System;
class StringDemo{
    static void Main(){
        char value1='H';
        char value2='E';
        string value3="Hello,Nice to See you";
        string value4="H";
        Console.WriteLine(value1);
        Console.WriteLine(value2);
        Console.WriteLine(value3);
        Console.WriteLine(value4);
        Console.WriteLine(value1.GetType());//Char type will be show
        Console.WriteLine(value3.GetType());//String object type
        int i=10;
        long l=200;
        float f=200.8f;
        Console.WriteLine(i.GetType());//output will be System.Int32
        Console.WriteLine(l.GetType());
        Console.WriteLine(f.GetType());
        Console.WriteLine(value3.ToUpper());//HELLO,NICE TO SEE YOU 
    }
}