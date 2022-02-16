using System;
class BreakDemo2{
    static void Main(){
        int i=1;
        while(i<=50){
            Console.WriteLine("# "+i);
            if(i==8){
                break;
            }
            i++;
        }
        Console.WriteLine("Program finished.")
    }
}