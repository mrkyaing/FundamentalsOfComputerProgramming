using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.Add(1, 1);//2
            calculator.Add(2.2, 2.3, 1);//5.5
            calculator.Add(2, 2, 2);//6
            //calculator.Add("helo");//sematic error .
            Console.WriteLine("press any key to close this window");
            Console.ReadKey();
        }
    }
}
