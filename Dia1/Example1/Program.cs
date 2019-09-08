using System;

namespace Dia1.Example1
{
    class Program
    {
        static void Outro()
        {
            Shape shape1 = new Circle(10);
            Shape shape2 = new Square(20);

            Console.WriteLine("{0}cm² - {1}", shape1.GetArea(), shape1.Draw());
            Console.WriteLine("{0}cm² - {1}", shape2.GetArea(), shape2.Draw());

            Circle circle = new Circle(5);
            Square square = new Square(5);
            circle.Radius = 20;
            square.Size   = 30;

            Console.WriteLine("Circle w/ Radius = {0}cm -> Area: {1}cm²", circle.Radius, circle.GetArea());
            Console.WriteLine("Square w/ Size   = {0}cm -> Area: {1}cm²", square.Size,   square.GetArea());
        }
    }
}
