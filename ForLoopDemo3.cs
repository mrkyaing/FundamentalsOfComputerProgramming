using System;
class ForLoopDemo3 {
    static void Main () {
        for (int i = 0, j = 10; i <= j; i++, j--) {
            Console.WriteLine (i + "," + j);
        }
    }
}