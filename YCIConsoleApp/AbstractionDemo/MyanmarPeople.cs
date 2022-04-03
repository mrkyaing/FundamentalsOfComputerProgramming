using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    public class MyanmarPeople : SayHello
    {
        public override void SayGreetingMessage()
        {
            Console.WriteLine("Hoke Kae,MinGa Larpar");
        }
        public override void AboutMe()
        {
            Console.WriteLine("Kya Naw nay kaung par taw.");
        }

    }
}
