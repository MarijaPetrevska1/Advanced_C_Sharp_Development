using ShapeAreaCalculator.Interfaces;

namespace ShapeAreaCalculator.Entities
{
    // Class Triangle
    public class Triangle : IShape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double baseLength, double height)
        {
            if (baseLength <= 0 || height <= 0)
            {
                Console.WriteLine("Base and Height must be greater than zero.");
                return;  
            }
            Base = baseLength;
            Height = height;
        }

        // GetArea method
        public double GetArea()
        {
            return 0.5 * Base * Height; 
        }
    }
}

