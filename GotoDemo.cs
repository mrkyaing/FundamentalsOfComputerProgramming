using System;
class GotoDemo {
    static void Main () {
        int number = 20;
        switch (number) {
            case 5:
                Console.WriteLine ("case 5 worked");
                goto hi;
            case 10:
                Console.WriteLine ("case 10 worked");
                break;
            case 20:
                Console.WriteLine ("case 20 worked ");
                goto case 5;
            default:
                Console.WriteLine ("none of them");
                break;
        }
        hi://define label you can call with goto statement
        Console.WriteLine("hi");
      
      Hello:
      {
        Console.WriteLine("Nice to see you");
        Console.WriteLine("You and I");
    }
    
    }
}