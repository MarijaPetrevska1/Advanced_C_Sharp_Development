using System;
using ShapeCalculationApp.Entities;

namespace ShapeCalculationApp.Entities
{
    // Class Triangle
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public override double CalculateArea()
        {
            double s = (SideA + SideB + SideC) / 2; 
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC)); 
        }

        public override double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }
    }
}
