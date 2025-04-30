// CLASS 02 - Task4
// Write a program to create an abstract class Employee with abstract methods CalculateSalary() and DisplayInfo(). 
// Create subclasses Manager and Programmer that extend the Employee class and implement the respective methods to calculate salary and display information for each role.

using TeamManagementSystem.Entities;

namespace TeamManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n   ===== Homework 1 - Task 4 =====\n");
            Console.WriteLine("\n   Employee Salary Calculation System  \n");
            Console.ResetColor();

            // Manager
            Employee manager = new Manager("Bob Bobsky", 3500, 2000);
            // Programmers
            Employee programmer1 = new Programmer("Emily Robinson", 25, 180);
            Employee programmer2 = new Programmer("Boba Bobsky", 25, 150);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==> Manager ");
            Console.ResetColor();
            manager.DisplayInfo();

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==> Programmer ");
            Console.ResetColor();
            programmer1.DisplayInfo();
            programmer2.DisplayInfo();


            Console.ReadLine();
        }
    }
}
