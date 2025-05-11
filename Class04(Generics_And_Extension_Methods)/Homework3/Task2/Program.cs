using System;
using Task2.Models;
using Task2.Helpers; 


Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\nTask 2 - Homework 3\n");
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

// Calling the new methods

((Car)car).Drive();        
((MotorBike)motorBike).Wheelie();  
((Boat)boat).Sail();         
((Airplane)plane).Fly();     


Console.WriteLine();
Console.ReadLine();