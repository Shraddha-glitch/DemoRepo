using System;
using System.Security.Cryptography.X509Certificates;
namespace AbstrationEncapsulationDemo{
    public abstract class Shape{
        //encapsulating by protecting fields encapsulated within the base class
        protected double Width{get; set;}
        protected double Height{get; set;}

        //constructor for initializing width and height
        public Shape(double width, double height){
                this.Width=width;
                this.Height=height;
        }
        public abstract double CalculateArea();

    }
    //inheriting rectangle class from shape
    public class Rectangle : Shape{
        public Rectangle(double width, double height) : base(width, height){

        }
        public override double CalculateArea()
        {
            return Width * Height;
            throw new NotImplementedException();
        }
    }

    public class Circle : Shape{
        public Circle(double radius) : base(radius, radius){
        

        }
        public override double CalculateArea()
        {
            return Math.PI * Width * Width;
            throw new NotImplementedException();
        }
    }

    public class Program{
        static void Main(string[] args){
            Rectangle rectangle = new(2,3);
            Circle circle=new(3);
            
            //polymorphism to calculate and display area
            DisplayArea(rectangle);
            DisplayArea(circle);
        
        }
        static void DisplayArea(Shape shape){
            System.Console.WriteLine($"Area of the shape: {shape.CalculateArea()}");
        }
    }
}