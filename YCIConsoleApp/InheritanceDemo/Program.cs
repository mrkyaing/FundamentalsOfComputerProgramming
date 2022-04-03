using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog mydog = new Dog();
            mydog.Name = "Pukky";
            mydog.Eat();
            mydog.Sleep();
            mydog.Bark();
            mydog.Walk(2);

            Dog yourDog = new Dog();
            yourDog.Name = "jucky";
            yourDog.MakeSound();

            Console.WriteLine("================================");
            Cat mycat = new Cat();
            mycat.Name = "Puccy";
            mycat.Eat();
            mycat.Sleep();
            mycat.MakeSound();
            Console.WriteLine("================================");
            Lion l = new Lion();
            l.Name = "Jaka";
            l.Eat();
            l.Sleep();
            l.MakeSound();
           
            Console.WriteLine("================================");
            Console.WriteLine("Hello,World.");
            Console.WriteLine("Press Any Key to exists");
            Console.ReadKey();
        }
    }
}
