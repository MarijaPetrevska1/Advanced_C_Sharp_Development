using System;
using Task2.Models;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\nTask 2 - Homework 2\n");
Console.ResetColor();

Vehicle car = new Car();
Vehicle motorBike = new MotorBike();
Vehicle boat = new Boat();
Vehicle plane = new Airplane();

Console.WriteLine();

car.DisplayInfo();
motorBike.DisplayInfo();
boat.DisplayInfo();
plane.DisplayInfo();

Console.WriteLine();
Console.ReadLine();