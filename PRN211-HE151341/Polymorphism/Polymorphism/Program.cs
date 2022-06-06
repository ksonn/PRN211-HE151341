using System;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape p = new Circle();
            p.Display();
            p.Draw();
            p = new Rectangle();
            p.Display();
            p.Draw();
            p.Print();
            Console.ReadLine();
        }
    }
    public abstract class Shape{

        public int Height { get; set; }
        public int Width { get; set; }
        // Virtual method
        public virtual void Draw()
        {
            Console.WriteLine("Performing Base class Drawing tasks");
        }
        public void Print()
        {
            Console.WriteLine("Performing Base class Printing tasks");
        }
        // Abstract method
        public abstract void Display();
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
        public override void Display()
        {
            Console.WriteLine("Display Circle");
        }
    }

    public class Rectangle : Shape
    { 
        public new void Print()
        {
            Console.WriteLine("Printing Rectangle");
        }
        public override void Draw()
        {
        Console.WriteLine("Drawing a rectangle");
        }


        public override void Display()
        {
           Console.WriteLine("Display a Rectangle");
        }
    }
}
