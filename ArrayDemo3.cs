using System;
class ArrayDemo3{
    static void Main(){
         Console.WriteLine("Welcome");
        Console.WriteLine("program start ,plz type your student list");
        Console.Write("How many student do you want to store?:");
        int size=int.Parse(Console.ReadLine());//to create array (Dynamic array size)
        //value of size of array is always positive integer value(any programming).(10,12,-10,20.5)
        string[] students=new string[size];//create student array by using value of size variable 
        for(int i=0;i<students.Length;i++){
            Console.Write("Enter Name Of Student "+(i+1)+":");//to show Enter Name Of Student 1: 2: 3 : etc 
            students[i]=Console.ReadLine();//write data to array from user's input
        }
        Console.WriteLine("All Student List are :");
        for(int i=0;i<students.Length;i++){
            Console.WriteLine(students[i]);//reading data from array 
        }
        Console.WriteLine("Program finished");
        Console.WriteLine("Thanks");
    }
}