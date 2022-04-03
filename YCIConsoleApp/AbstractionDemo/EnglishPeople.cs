using System;

namespace AbstractionDemo
{
    public class EnglishPeople : SayHello
    {
        public override void SayGreetingMessage()
        {
            Console.WriteLine("Hello,nice to see you");
        }
        public override void AboutMe()
        {
            Console.WriteLine("i am fine ");
        }

    }
}
