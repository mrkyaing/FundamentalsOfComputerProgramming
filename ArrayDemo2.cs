using System;
class ArrayDemo2{
    static void Main(){
        string[] Days=new string[7];// 0 to 6
        //Days[10]="HiDay";//ArrayIndexOutOfBound Error 
        Days[0]="Mon";
        Days[1]="Tue";
        Console.WriteLine("Days of Week is ");
        for(int i=0;i<Days.Length;i++){//Days.Length >>7
         Console.WriteLine(Days[i]);//Mon
        }
        double[] myarray={10.2,30.5,123.7,70.5,50.3};
        //to get array 's length/Size  >>arrayName.Length 
        for(int j=0;j<myarray.Length;j++){
          Console.WriteLine(myarray[j]);//10.2    
        }
    }
}