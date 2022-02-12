using System;
class NestedIfDemo{
    static void Main(){
        int grade=70;
        if(grade>90){
            Console.WriteLine("grade A");
        }
        else if(grade>80){
             Console.WriteLine("grade B");
        }
        else if(grade>60){
             Console.WriteLine("grade C");
        }
        else if(grade>=40){
        Console.WriteLine("grade D");
        }
        else{
       Console.WriteLine("grade E you failed in exam.");
        }
    }
}