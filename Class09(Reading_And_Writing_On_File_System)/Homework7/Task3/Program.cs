using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Homework 7 - Task3
        // Read the file created in the previous task name "names.txt".
        // Go thru the file content and filter out all the names that start with A.
        // If there are any names create a new file named "namesStartingWith_A.txt"
        // that will contains the filtered content and if there is no names that start with A do nothing.
        // Do this for  the letters 'A', 'M', 'I', 'J', 'K', 'L', 'P', 'D', 'S' in the alphabet.

        Console.ForegroundColor = ConsoleColor.Yellow; 
        Console.WriteLine("\n Task 3 - Homework 7\n");
        Console.ResetColor();

        string folderPath = @"..\..\..\Files";
        string sourceFile = Path.Combine(folderPath, "names.txt");

        // Creating folder if missing
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
        if (!File.Exists(sourceFile))
        {
            File.Create(sourceFile).Close();
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

        // Reading existing names
        List<string> allNames = File.ReadAllLines(sourceFile).Where(n => !string.IsNullOrWhiteSpace(n)).Select(n => n.Trim()).ToList();

        // If there are no names in file, ask the user to add some names
        if (allNames.Count == 0)
        {
            Console.WriteLine("\nThe 'names.txt' file is empty. Please enter names to add (type 'done' to finish):");
            while (true)
            {
                Console.Write("Enter name: ");
                string input = Console.ReadLine();

                if (string.Equals(input, "done", StringComparison.OrdinalIgnoreCase))
                    break;

                if (!string.IsNullOrWhiteSpace(input))
                {
                    allNames.Add(input.Trim());
                }
            }

            if (allNames.Count > 0)
            {
                File.WriteAllLines(sourceFile, allNames);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n{allNames.Count} name(s) were added to 'names.txt'.");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("No names were added. Exiting...");
                return;
            }
        }
        else
        {
            Console.WriteLine("\nExisting names in 'names.txt':");
            foreach (var name in allNames)
            {
                Console.WriteLine("- " + name);
            }
        }

        // Letters to filter by
        char[] letters = { 'A', 'M', 'I', 'J', 'K', 'L', 'P', 'D', 'S' };

        // Filter and create files
        foreach (char letter in letters)
        {
            var filteredNames = allNames
                .Where(name => name.StartsWith(letter.ToString(), StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (filteredNames.Count > 0)
            {
                string newFileName = $"namesStartingWith_{letter}.txt";
                string newFilePath = Path.Combine(folderPath, newFileName);

                File.WriteAllLines(newFilePath, filteredNames);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"File '{newFileName}' created with {filteredNames.Count} name(s).");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"No names starting with '{letter}'. No file created.");
                Console.ResetColor();
            }
        }

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\nDone filtering names for specified letters.");
        Console.ResetColor();
        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }
}
