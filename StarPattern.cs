using System;
class StarPattern {
    static void Main () {
        for (int row = 1; row <= 10; row++) {
            for (int col = 1; col <= row; col++) {
                Console.Write ("*"); //print * 
            }//end of inner loop
            Console.WriteLine (); // new line 
        } //end of outter loop
    }
}