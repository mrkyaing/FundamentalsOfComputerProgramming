using System;
class MinFindProgram {
    static void Main () {
        int value1 = 100, value2 = 10, value3 = 101;
        int min=0;//global variable 
        if (value1 > value2) {
         min = value2;
        } 
        else {
            min = value1;
        }
        if (min > value3) {
            Console.WriteLine ("Mininmun value is " + value3);
        } else {
            Console.WriteLine ("Mininmun value is " + min);
        }
    }
}