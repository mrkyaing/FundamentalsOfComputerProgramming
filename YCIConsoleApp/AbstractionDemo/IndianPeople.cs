using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    public class IndianPeople : SayHello
    {
        public override void AboutMe()
        {
            Console.WriteLine("i am fine ");
        }

        public override void SayGreetingMessage()
        {
            Console.WriteLine("namaskaar, aapase milakar achchha laga");
        }
    }
}
