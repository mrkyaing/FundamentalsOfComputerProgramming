using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
  public  class Cat:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow Meow Meow");
        }
        public override void Eat()
        {
            Console.WriteLine("cat eat meal");
        }

        public override void Walk()
        {
            Console.WriteLine("cat is walking as cat manner.");
        }
    }
}
