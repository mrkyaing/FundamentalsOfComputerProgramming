using System;

namespace AbstractionDemo
{
   public abstract class SayHello
    {
        public string Name { get; set; }
        public string Address { get; set; }
        //abstract method with No-body of code and no implementation code .
        public abstract void SayGreetingMessage();
        public abstract void AboutMe();
        //non-abstract method 
        public void DisplayInfo()
        {
            Console.WriteLine($"Hi,My name is {Name} and i live in {Address}");
        }
    }
}
