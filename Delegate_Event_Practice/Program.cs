using System;
using static Delegate_Event_Practice.Validation;

namespace Delegate_Event_Practice
{
    class Program
    {
        static void GetArea() 
            => Console.WriteLine("Getting area");

        static void Main(string[] args)
        {
            var points = new Point[4]
            {
                new Point(2, 4),
                new Point(4, 4),
                new Point(4, 2),
                new Point(2, 2)
            };

            if (IsSquare(points))
            {
                var square = new Square(points);
                square.GetArea += (sender, args) => Console.WriteLine("Getting square area"); 

                Console.WriteLine("\nThis is a square:");
                Console.WriteLine($"Width: {square.Width()}");
                Console.WriteLine($"Area: {square.Area()}");
            }
            else
            {
                Console.WriteLine("\nThis is not a square.");
            }

            if (IsRectangle(points))
            {
                var rectangle = new Rectangle(points);
                rectangle.GetArea += GetArea;
                rectangle.GetWidth += () => Console.WriteLine("Getting rectangle width");

                Console.WriteLine("\nThis is a rectangle:");
                Console.WriteLine($"Width: {rectangle.Width()}");
                Console.WriteLine($"Height: {rectangle.Height()}");
                Console.WriteLine($"Area: {rectangle.Area()}");
            }
            else
            {
                Console.WriteLine("\nThis is not a rectangle.");
            }

            if (IsTriangle(points))
            {
                var triangle = new Triangle(points);
                triangle.GetArea += GetArea;

                Console.WriteLine("\nThis is a triangle:");
                Console.WriteLine($"Area: {triangle.Area()}");
            }
            else
            {
                Console.WriteLine("\nThis is not a triangle");
            }

        }
    }
}
