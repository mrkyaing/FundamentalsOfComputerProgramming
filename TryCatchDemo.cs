using System;
class TryCatchDemo{
    static void Main(){
         int[] nums = new int[num];
        double average, total = 0;
        try{
        Console.Write ("Enter number of Value:");
        int num = int.Parse (Console.ReadLine ());   
        for (int i = 0; i < num; i++) {
            Console.Write ("Enter value " + (i + 1) + ":");
            nums[i] = int.Parse(Console.ReadLine ());
        }
        Console.Write ("Your Enter value are:");
        for (int i = 0; i < num; i++) {
            total += nums[i];
            if (i == nums.Length - 1) //check it is last value of array get 
                Console.Write (nums[i]);
            else 
                Console.Write (nums[i] + ",");
        }
        Array.Sort(nums);//Sorting (Ascending Order )mean smaller to larger value of Array
        int min = nums[0];//get mininmum value(First Index 0 ) for ordering data .
        int max = nums[nums.Length-1];//get maxinum value(Last Index ) for ordering data .
        Console.WriteLine ();
        average = total / num;
        Console.WriteLine ("Minimun is " + min);
        Console.WriteLine ("Maxinum is " + max);
        Console.WriteLine ("Total is " + total);
        Console.WriteLine ("Average is " + average);
        }//end of try
        catch(FormatException fe){
        Console.WriteLine("Please only type Numeric value.");
        Console.WriteLine("Invalid Format Exception");
        }
        catch(ArrayOutOfBoundException aobeE){
        Console.WriteLine("Array Index out side the box.");
        } 
    }
}