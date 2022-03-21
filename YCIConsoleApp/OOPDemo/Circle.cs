using System;
namespace OOPDemo{
    public class Circle{
        public double Radius;
        public Circle()//Default Constructor
        {
            Radius = 0.02;
        }
        public Circle(double newRadius)//Constructor with 1 parameter
        {
            Radius = newRadius;
        }
        public double GetArea(){
            double area = 0;
            area = Math.PI * Radius * Radius;
            return area;
        }
        public double GetPrimeter(){
            double primeter = 0;
            primeter=2*Math.PI * Radius;
            return primeter;
        }
        public void SetRadius(double newRadius){
            Radius=newRadius;
        }
    }
}
