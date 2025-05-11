using System;
using Task2.Models;

namespace Task2.Helpers  
{
    public static class VehicleExtensions
    {
        //Car class
        public static void Drive(this Car car)
        {
            Console.WriteLine("Driving");
        }

        // MotorBike class
        public static void Wheelie(this MotorBike motorBike)
        {
            Console.WriteLine("Driving on one wheel");
        }

        // Boat class
        public static void Sail(this Boat boat)
        {
            Console.WriteLine("Sailing");
        }

        // Airplane class
        public static void Fly(this Airplane airplane)
        {
            Console.WriteLine("Flying");
        }
    }
}
