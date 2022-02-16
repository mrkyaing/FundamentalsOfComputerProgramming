using System;
class ContinueDemo{
    static void Main(){
        Console.WriteLine("Program start.");
        for(int i=1;i<=50;i++){   
            if(i==8 || i==10){
                continue;
            }
            Console.Write(i+" ");
        }
        Console.WriteLine("Program finished.");
    }
}