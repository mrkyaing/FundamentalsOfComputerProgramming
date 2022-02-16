<<<<<<< HEAD
using System;
class BreakDemo {
    static void Main () {
        int result = 100;
        for (int i = 10; i <50; i++) {
            if (i > 20) {
                Console.WriteLine ("result is 20");
                Console.WriteLine ("result is 20"); //sematic error 
                Console.WriteLine ("result is 20"); //sematic error 
                Console.WriteLine ("result is 20"); //sematic error 
                break;
                //break ,continue,goto (Jump Statements)
                //break can be used in switch,if,loop (for),while,dow-while
            }
        }

        if (result < 10) {
            Console.WriteLine ("hi");
        }
    }
=======
using System;
class BreakDemo {
    static void Main () {
        int result = 100;
        for (int i = 10; i <50; i++) {
            if (i > 20) {
                Console.WriteLine ("result is 20");
                Console.WriteLine ("result is 20"); //sematic error 
                Console.WriteLine ("result is 20"); //sematic error 
                Console.WriteLine ("result is 20"); //sematic error 
                break;
                //break ,continue,goto (Jump Statements)
                //break can be used in switch,if,loop (for),while,dow-while
            }
        }

        if (result < 10) {
            Console.WriteLine ("hi");
        }
    }
>>>>>>> f9be41793b5398067f40c0c63932a59e312d6aec
}