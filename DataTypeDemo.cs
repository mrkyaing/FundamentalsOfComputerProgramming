using System;
class DataTypeDemo{
    static void Main(){
        Console.WriteLine("Today Program start.");
        int myvalue1=1000;
        byte myvalue2=127;
        short myvalue3=3000;
        long myvalue4=456789;
        long finalresult=myvalue1+myvalue2+myvalue3+myvalue4;
        float f=20.5f;
        double d=600.705;
        decimal d2=600.84m;
        Console.WriteLine(f);
        Console.WriteLine(d);
        Console.WriteLine(d2);
        bool isOk=true;
        char mychar='H'; 
        Console.WriteLine(finalresult); 
        Console.WriteLine(isOk);
        Console.WriteLine(mychar);
        mychar='Z';
        Console.WriteLine(mychar);
        Console.WriteLine("Program Finished.");     
    }
}