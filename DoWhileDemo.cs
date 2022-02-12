using System;
class DoWhileDemo {
    static void Main () {
        int i = 1;
        Console.WriteLine("loop with do-while");
        do {
            Console.WriteLine ("#" + i);
            i++;
        } while (i<=0);
        
        Console.WriteLine("loop with while");
        int y=1;
        while (y <=0) {
            Console.WriteLine ("#" + y);
            y++;
        }
    }

}