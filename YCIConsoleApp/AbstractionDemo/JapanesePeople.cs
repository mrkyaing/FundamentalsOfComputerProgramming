using System;


namespace AbstractionDemo
{
    public class JapanesePeople : SayHello
    {
        public override void SayGreetingMessage()
        {
            Console.WriteLine("HiKon'nichiwa, hajimemashite");
        }
        public override void AboutMe()
        {
            Console.WriteLine("i am fine ");
        }
    }
}
