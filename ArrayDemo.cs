using System;
class ArrayDemo {
    static void Main () {
        int[] numbers = new int[10]; //declare array 
        numbers[0] = 70; //write data to array (by using index)
        int[] arr = { 10, 20, 41, 52, 100,12,5464,1313,4646,3131,3131,3131,6164,6131,6464,230 }; //create array with data initialization 
        Console.WriteLine ("value of data in number of first :" + numbers[0]); //70 (read from array (by using index))
        Console.WriteLine ("value of data in number of Last :" + numbers[9]); //0 (read from array (by using index))
        Console.WriteLine ("value of data in arr of Fourth value :" + arr[3]); //52
        Console.WriteLine ("value of data in arr of Fourth value :" + arr[5]); //52
        //reading and writing  from and to array is called accessing the array,then use index.
        //index always start from 0.
        Console.WriteLine("values from the array of arr is :");
        for(int i=0;i<16;i++){
            Console.WriteLine(arr[i]);//10
            //20
            //41
            //52
            //100
        }
         Console.WriteLine("values from the array of number is :");
         for(int j=0;j<10;j++){
             Console.Write(numbers[j]+" ");//70 0 0 0 0 0 0 0 0 0
         }
    }
}