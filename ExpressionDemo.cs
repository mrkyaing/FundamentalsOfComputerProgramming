using System;
class ExpressionDemo{
    static void Main(){
        Console.WriteLine("Program start");
        Console.WriteLine(1+2);
        Console.WriteLine("1+2");
        int result=1 * 2 + 3 * 5 / 4;
        Console.WriteLine(1 * 2 + 3 * 5 / 4);
        int result2=1 + 2 / 3 * 5 - 4;
        Console.WriteLine(result2);
        double result3=1.5 * 2.4 + 3.3 * 4.25 / 5.5;
        Console.WriteLine(result3);
        Console.WriteLine(1>2);
        Console.WriteLine(123<200);
        Console.WriteLine(result+result2+result3);
    }
}