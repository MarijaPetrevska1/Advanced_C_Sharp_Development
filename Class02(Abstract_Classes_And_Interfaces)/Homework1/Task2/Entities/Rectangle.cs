using ShapeAreaCalculator.Interfaces;

namespace ShapeAreaCalculator.Entities
{
    // Class Rectangle
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            if (width <= 0 || height <= 0)
            {
                Console.WriteLine("Width and Height should be greater than zero.");
                return;  
            }
            Width = width;
            Height = height;
        }

        // Implementing GetArea method
        public double GetArea()
        {
            return Width * Height;
        }
    }
}

