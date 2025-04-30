using ShapeAreaCalculator.Interfaces;

namespace ShapeAreaCalculator.Entities
{
    // Class Circle
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                Console.WriteLine("Radius must be greater than zero.");
                return;  
            }
            Radius = radius;
        }

        // Implementing GetArea method
        public double GetArea()
        {
            return Math.PI * Radius * Radius; 
        }
    }
}

