using System;
class OperatorsDemo{
    //start Main Method
    static void Main(){
    int x=10;
    int y=20;
    Console.WriteLine(x>y);//Output will be False
    Console.WriteLine(x<y && x>=10);//True
    Console.WriteLine(x>y || x>8);//True
    Console.WriteLine(3>2 || 50>100);//True
    Console.WriteLine(3>2 && 50>100);//False
    Console.WriteLine(!(3>2 && 50>100));//True
    int z=200;
    Console.WriteLine(z>=200);//True
    Console.WriteLine(z!=100);//True
    bool isOk=true;
    Console.WriteLine(!isOk);//False  
    char myvalue='A';
    Console.WriteLine((int)myvalue);//65 (int) means data type convertion   
    }
}