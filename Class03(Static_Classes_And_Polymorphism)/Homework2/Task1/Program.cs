using System;
using System.Collections.Generic;
using Task1.Models;
using Task1.Helpers;

        
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("\nTask 1 - Homework 2\n");
Console.ResetColor();
List<User> usersById = UserDatabase.Search(1);
List<User> usersByName = UserDatabase.Search("George");
List<User> usersByAge = UserDatabase.SearchByAge(26);

// Search by ID
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Search by ID:");
Console.ResetColor();

foreach (User user in usersById)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(user.Id + " - " + user.Name + " - " + user.Age);
    Console.ResetColor();
}

Console.WriteLine();


// Search by Name
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Search by Name:");
Console.ResetColor();

foreach (User user in usersByName)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(user.Id + " - " + user.Name + " - " + user.Age);
    Console.ResetColor();
}

Console.WriteLine();


// Search by Age
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Search by Age:");
Console.ResetColor();

foreach (User user in usersByAge)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine(user.Id + " - " + user.Name + " - " + user.Age);
    Console.ResetColor();
}

Console.WriteLine();
Console.ReadLine();
