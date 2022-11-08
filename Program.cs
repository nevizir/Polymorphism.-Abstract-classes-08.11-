using System;

namespace Polymorphism._Abstract_classes_08._11_
{
    internal class Program
    {
        abstract class Figure
        {
            public abstract void GetArea();
            public abstract void GetPerimeter();
        }

        class Square : Figure
        {       
            public int x { get; set; }

            public override void GetArea()
            {
                Console.WriteLine("Area ::" + x*x);
            }
            public override void GetPerimeter()
            {
                Console.WriteLine("Perimeter ::" + x*4);
            }
        }

        class Rectangle : Figure
        {
            public int x { get; set; }
            public int y { get; set; }

            public override void GetArea()
            {
                Console.WriteLine("Area ::" + x * y);
            }
            public override void GetPerimeter()
            {
                Console.WriteLine("Perimeter ::" + 2*(x+y));
            }
        }


        static void Main(string[] args)
        {
            
        }
    }
}
