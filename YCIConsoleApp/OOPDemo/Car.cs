using System;

namespace OOPDemo
{
    public class Car
    {
        //3 members
        public string Color, LicenceNo, Speed;

        //define and set default value of Members by Overriding default Constructor 
        public Car()
        {
            Color = "No Color Define";
            LicenceNo = "No Licence";
            Speed = "No Speed";
        }
        public void StartEngine()
        {
            Console.WriteLine("Engine Start");
        }
        public void StopEngine()
        {
            Console.WriteLine("Engine Stop");
        }
        public void TurnOnLight()
        {
            Console.WriteLine("Light is On.");
        }
        public void PlayHorn(int playTime)
        {
            Console.WriteLine("Play Honrn");
            for (int i = 1; i <= playTime; i++)
            {
                Console.Beep();
            }
        }
        public void GetInfo()
        {
            Console.WriteLine("Color :"+Color);
            Console.WriteLine("Speed  :" + Speed);
            Console.WriteLine("Licence NO :" + LicenceNo);
        }
    }
}
