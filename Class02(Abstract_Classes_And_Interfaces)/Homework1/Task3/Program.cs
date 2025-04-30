// CLASS 02 - Task3
// Write a program to create an abstract class Shape with abstract methods CalculateArea() and CalculatePerimeter(). 
// Create subclasses Circle and Triangle that extend the Shape class and implement the respective methods to calculate the area and perimeter of each shape.

using System;
using ShapeCalculationApp.Entities;

namespace ShapeCalculationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n   ===== Homework 1 - Task 3 =====\n");
            Console.ResetColor();

            // Circle
            Shape circle = new Circle(8);
            // Triangle
            Shape triangle = new Triangle(7,6,8);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=== Circle ===");
            Console.ResetColor();

            Console.WriteLine("The area of the circle is: " + Math.Round(circle.CalculateArea(), 2) + " cm2.");
            Console.WriteLine("The perimeter of the circle is: " + Math.Round(circle.CalculatePerimeter(), 2)+ " cm.");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=== Triangle ===");
            Console.ResetColor();

            Console.WriteLine("The area of the triangle is: " + Math.Round(triangle.CalculateArea(), 2)+ " cm2.");
            Console.WriteLine("The perimeter of the triangle is: " + Math.Round(triangle.CalculatePerimeter(), 2) + " cm.");

            Console.ReadLine();
        }
    }
}
