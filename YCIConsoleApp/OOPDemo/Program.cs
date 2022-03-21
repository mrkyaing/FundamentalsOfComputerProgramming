using System;

namespace OOPDemo
{
     class Program
    {
        static void Main(string[] args)
        {
            Car MyCar=new Car(); //Create Car Object (it can called instance of Car Class)
            MyCar.Color = "Black";
            MyCar.LicenceNo = "YGN-66123";
            MyCar.Speed = "2000HP";
            MyCar.StartEngine();
            MyCar.PlayHorn(2);
            MyCar.TurnOnLight();
            MyCar.StopEngine();
            MyCar.GetInfo();
            Console.WriteLine("========================");
            Car yourCar = new Car(); //Create Car Object (it can called instance of Car Class)
            yourCar.Color = "Red";
            yourCar.LicenceNo = "YGN-963741";
            yourCar.Speed = "1000HP";
            yourCar.StartEngine();
            yourCar.PlayHorn(1);
            yourCar.TurnOnLight();
            yourCar.StopEngine();
            yourCar.GetInfo();

            Car c1 = new Car();
            c1.GetInfo();

            Circle circle1= new Circle();//create object by using default constructor 
            circle1.Radius = 2.5;
            Console.WriteLine(circle1.GetArea());//
            Console.WriteLine(circle1.GetPrimeter());//

            Circle circle2= new Circle(7.5);//craete object by using 1 parameter constructor
            Console.WriteLine(circle2.GetArea());//
            Console.WriteLine(circle2.GetPrimeter());//
            circle2.SetRadius(50.5);
            Console.WriteLine(circle2.GetArea());//
            Console.WriteLine(circle2.GetPrimeter());//
            Cat cat1 = new Cat();
            cat1.Sound();
            cat1.Sound(5);
            
            Utilitity.TellMeTodayName();
            Utilitity.TellMeWhatTimeIsIt();

            Student s1 = new Student();
            s1.SetRollNo(1);
            s1.SetName("su su");
            s1.SetAge( 10);
            s1.SetPhone("09256275319");
            s1.GetInfo();

            Student s2 = new Student();
            s2.SetRollNo(-10);//Sensitive Data here 
            s2.SetName("Khin Khin");
            s2.SetAge(-10);//Sensitive Data here 
            s2.SetPhone("09256275319123");
            s2.GetInfo();

            Console.WriteLine("Press any key to close this windows");
            Console.ReadKey();
        }
    }
}
