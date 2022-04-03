using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
  public  class Animal
    {
        private string name;
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

       public virtual void Eat()
        {
            Console.WriteLine(name + " is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine(name + " is Sleeping.");
        }

        public virtual void Walk()
        {
            Console.WriteLine("animal is walking.");
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("animal is making sound.");
        }
       
    }
}
