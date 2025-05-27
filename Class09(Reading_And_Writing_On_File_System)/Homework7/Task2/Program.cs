// Homework 7 - Task 2
// Reading and Writing on File System

using System;
using System.Collections.Generic;
using System.IO;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n Task 2 - Homework 7\n");
Console.ResetColor();

// Read the file created in the previous task named "names.txt".
// Ask the user to enter some names and save these names in the file that we previously created.

string folderPath = @"..\..\..\Files";
string filePath = Path.Combine(folderPath, "names.txt");
// The folder
if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Folder 'Files' was created.");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Folder 'Files' already exists.");
    Console.ResetColor();
}
// Checking if the file exists
if (!File.Exists(filePath))
{
    File.Create(filePath).Close(); 
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("File 'names.txt' was created.");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("File 'names.txt' already exists.");
    Console.ResetColor();
}
// Checking if there are already saved names in the file
Console.WriteLine("\nHere are the names already saved in 'names.txt':");
string[] existingNames = File.ReadAllLines(filePath);
if (existingNames.Length > 0)
{
    foreach (string name in existingNames)
    {
        Console.WriteLine("- " + name);
    }
}
else
{
    Console.WriteLine("(The file is currently empty)");
}
// Adding the names to the file 
Console.WriteLine("\n Please enter names to add to the file (type 'done' to finish):");
List<string> newNames = new List<string>();
string input;

while (true)
{
    Console.Write("Enter name: ");
    input = Console.ReadLine();

    if (string.Equals(input, "done", StringComparison.OrdinalIgnoreCase))
        break;

    if (!string.IsNullOrWhiteSpace(input))
        newNames.Add(input.Trim());
}

if (newNames.Count > 0)
{
    File.AppendAllLines(filePath, newNames);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{newNames.Count} name(s) were added to the file 'names.txt'.");
    Console.ResetColor();
}
else
{
    Console.WriteLine("No names were added.");
}

Console.WriteLine("\n Press Enter to exit!");
Console.ReadLine();
