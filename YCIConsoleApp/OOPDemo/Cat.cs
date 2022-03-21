using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    public class Cat
    {
       public void Sound()
        {
           Console.WriteLine("Meow");
        }
        public void Sound(int time)
        {
            for (int i = 1; i < time; i++)
            {
                Console.WriteLine("Meow");
            }
           
        }
    }
}
