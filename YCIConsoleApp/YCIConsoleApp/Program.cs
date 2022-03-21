using System;
using System.Collections.Generic;
using System.Linq;

namespace YCIConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Start program");
             Console.Write("Enter Frist number:");
             int num1 = int.Parse(Console.ReadLine());
             Console.Write("Enter Second number:");
             int num2 = int.Parse(Console.ReadLine());
             int addResult = AddTwoValues(num1, num2);//Method call/invocation
             Console.WriteLine("The sum value of " + num1 + " and " + num2 + " is " + addResult);
             string voteResult = SayCanVoteWhenAgeIsGraterThan18("Mg Kyaing", 30);//method called that you defined .
             Console.WriteLine("Status of Result" + voteResult);
             Console.WriteLine("Stop program");
             Console.WriteLine("press any key to close this window");
             Console.ReadKey();*/
            List<int> me = new List<int>(new int[] { 1, 2, 3, 5, 6, 7, 8, 9, 11, 12, 13, 14, 15, 16, 17 });
            var data = me.Skip(4).Take(me.Count).ToList();
            foreach (int i in data)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("==================================");
            List<int> me2 = new List<int>(new int[] { 1, 2, 3, 5, 6, 7, 8, 9, 11, 12, 13, 14, 15, 16, 17 });
            me2.Reverse();
            data = me.Skip(16).Take(me.Count).ToList();
            foreach (int i in data)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("press any key to close this window");
            Console.ReadKey();
        }
        static int AddTwoValues(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        static double DivideTwoValues(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }
        static string SayCanVoteWhenAgeIsGraterThan18(string name, int age)
        {
            if (age > 18)
            {
                return "Hi," + name + " you can vote.";
            }
            else
            {
                return "Sorry ,+" + name + " you can't vote.";
            }
        }
    }
}
