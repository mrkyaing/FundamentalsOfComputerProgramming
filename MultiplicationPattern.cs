using System;
class MultiplicationPattern {
    static void Main () {
        for (int row = 1; row <= 5; row++) {
            for (int col = 1; col <= 12; col++) {
                Console.Write (row * col + " ");
            }
            Console.WriteLine();
        }
    }
}