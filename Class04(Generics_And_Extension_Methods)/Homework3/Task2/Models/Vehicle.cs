using System;

namespace Task2.Models
{
    // Base class Vehicle - Abstract Class
    public abstract class Vehicle
    {
        public virtual void DisplayInfo()
        {
            Console.WriteLine("I'm a generic vehicle.");
        }
    }
}