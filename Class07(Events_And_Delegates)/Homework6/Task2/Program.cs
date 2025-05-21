using System;
using Task2.Services;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Homework 6 - Task 2
            // Delegates and events

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n Task 2 - Homework 5\n");
            Console.ResetColor();

            OnlineClass onlineClass = new OnlineClass();

            // Subscribe to the event
            onlineClass.OnUnauthorizedAccess += RespondToUnauthorizedUser;

            // Asking the user for name
            Console.Write("Enter your name: ");
            string inputName = Console.ReadLine();

            onlineClass.EnterClass(inputName);
            Console.ReadLine();
        }

        static void RespondToUnauthorizedUser(string name)
        {
            Console.WriteLine($"{name} Users Found.");
            Console.WriteLine("Sending Email to Administration.");
            Console.WriteLine("Email Sent.");
            Console.WriteLine("Warning Alarm Started.");
            Console.WriteLine("Logging out.");

        }
    }
}