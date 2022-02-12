using System;
class FindEvenNumbers{
    static void Main(){
        int i=1;
        Console.WriteLine("Total Even Numbers from 1 to 50");       
        
        while(i<=50){
           if(i % 2 == 0){
               Console.Write(i+",");
           }//end of if 
            i++;//2,3,4
        }//end of while 
        Console.WriteLine();//New Line 
        Console.WriteLine("Program finished");
    }//end Main
}//end of class 