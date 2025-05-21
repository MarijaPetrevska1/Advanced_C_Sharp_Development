using System;
using TeacherNotificator.Models;

namespace TeacherNotificator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Homework 5 - Task 1 - TeacherNotificator
            // Delegates and events

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Task1 - Homework 6\n");
            Console.ResetColor();
            // A teacher and three students
            Teacher professor = new Teacher { Name = "John", Age = 45, Email = "john@gmail.com", Subject = "Advanced C#" };
            Student alice = new Student { Name = "Alice", Age = 20, Email = "alice@yahoo.com", Subject = "Html and CSS" };
            Student bob = new Student { Name = "Bob", Age = 22, Email = "bob123@gmail.com", Subject = "Javascript basic" };
            Student charlie = new Student { Name = "Charlie", Age = 21, Email = "charlie@yahoo.com", Subject = "SQL" };

            // Subscribe students to professor's notifications
            professor.Subscribe(alice);
            professor.Subscribe(bob);
            professor.Subscribe(charlie);

            // Sending notifications to all subscribed students
            professor.SendNotification();

            Console.WriteLine();  

            // Unsubscribe Alice and Charlie
            professor.Unsubscribe(alice);
            professor.Unsubscribe(charlie);

            // Sending notifications again to see the change
            professor.SendNotification();
            Console.ReadLine();

        }
    }

}


