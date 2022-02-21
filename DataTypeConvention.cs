using System;
class DataTypeConvention{
    static void Main(){
        int i=10;
        double d=i;
        Console.WriteLine("int to double result is "+d);//10
        float f=20.1f;
        int y=(int)f;//using explicit type casting 
        Console.WriteLine("explicit type casting from float to int is "+y);//error
       int z=Convert.ToInt32(f);//by using Convert Method 
       Console.WriteLine("value of z is "+z);
       
       Console.WriteLine("Enter your age:") ;
       string ageInStr=Console.ReadLine();//10 string value 
       int age=Convert.ToInt32(ageInStr);//Convert String value to int
       //int age=int.Parse(ageInStr);
       if(age>20){
           Console.WriteLine("you are mature");
       }else{
           Console.WriteLine("you are not mature");
       }
    }
}