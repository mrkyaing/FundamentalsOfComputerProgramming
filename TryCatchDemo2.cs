using System;
class TryCatchDemo2{
    static void Main(){
        try{
        Console.Write("enter a first numer:");
        int n1=int.Parse(Console.ReadLine());//10
        Console.Write("enter a second numer:");
        int n2=int.Parse(Console.ReadLine());//0
       int finalresult= DivideInputvalue(n1,n2);//method call.
       Console.WriteLine("The Divided answer is "+finalresult);
        }
         catch(Exception e){
            Console.WriteLine("Sorry,we occur error in your input value");
            Console.WriteLine("because of "+e.Message);
        } 
    }
    static int DivideInputvalue(int n1,int n2){
        int result=n1/n2;
        return result;
    }
}