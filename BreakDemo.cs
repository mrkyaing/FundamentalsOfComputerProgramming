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
}