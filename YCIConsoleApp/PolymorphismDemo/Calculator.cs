using System;

namespace PolymorphismDemo
{
  public  class Calculator
    {
        public void Add(int n1,int n2)
        {
            int result = n1 + n2;
            //Console.WriteLine("Adding result is " + result);
            Console.WriteLine($"Adding result is {result}");//syntax of string interpolation $
        }
        public void Add(int n1,int n2,int n3)
        {
            int result = n1 + n2 + n3; 
            //Console.WriteLine("Adding result is " + result);
            Console.WriteLine($"Adding result is {result}");//syntax of string interpolation $
        }
        public void Add(double n1,double n2,int n3)
        {
            double result = n1 + n2 + n3; 
            //Console.WriteLine("Adding result is " + result);
            Console.WriteLine($"Adding result is {result}");//syntax of string interpolation $
        }
    }
}
