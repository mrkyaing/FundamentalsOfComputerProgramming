using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Dog:Animal
    {
        public void Bark()
        {
            Console.WriteLine("Woak Woak Woak");
        }

        public override void Eat()
        {
            Console.WriteLine("dog eat meal");
        }

        public override void Walk()
        {
            Console.WriteLine("dog is walking as dog manner.");
        }

        public void Walk(int count)
        {
            Console.WriteLine("waking time " + count);
        }
    }
}
