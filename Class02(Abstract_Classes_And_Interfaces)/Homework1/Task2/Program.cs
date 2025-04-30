// CLASS 02 Homework (Task 2)
// Write a program to create an interface Shape with the GetArea() method.
// Create three classes Rectangle, Circle, and Triangle that implement the Shape interface.
// Implement the GetArea() method for each of the three classes.

using ShapeAreaCalculator.Entities;
using ShapeAreaCalculator.Interfaces;

namespace ShapeAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n   ===== Task 2 =====\n");
            Console.WriteLine("   ===== Calculating Areas =====");
            Console.WriteLine();
            Console.ResetColor();

            // Instances of Rectangle, Circle, and Triangle
            IShape circle1 = new Circle(7.0);
            IShape circle2 = new Circle(0);
            IShape circle3 = new Circle(2.5);

            IShape rectangle1 = new Rectangle(8.0, 4.0);
            IShape rectangle2 = new Rectangle(9, 5);

            IShape triangle = new Triangle(8.0, 6.0);

            // Calculating and displaying areas
            Console.WriteLine($" Circle Area: {Math.Round(circle1.GetArea(), 2)}");
            Console.WriteLine($" Circle Area: {Math.Round(circle2.GetArea(), 2)}");
            Console.WriteLine($" Circle Area: {Math.Round(circle3.GetArea(), 2)}");

            Console.WriteLine($" Rectangle Area: {Math.Round(rectangle1.GetArea(), 2)}");
            Console.WriteLine($" Rectangle Area: {Math.Round(rectangle2.GetArea(), 2)}");

            Console.WriteLine($" Triangle Area: {Math.Round(triangle.GetArea(), 2)}");


            Console.ReadLine();
        }
    }
}
