using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n Task 4 Part 2- Homework 7\n");
        Console.ResetColor();

        string folderPath = @"..\..\..\Files";
        string sourceFile = Path.Combine(folderPath, "names.txt");

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

        // Read all names from names.txt
        List<string> allNames = File.ReadAllLines(sourceFile)
            .Where(n => !string.IsNullOrWhiteSpace(n))
            .Select(n => n.Trim())
            .ToList();

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

        // Filter by letters A-Z and append/update files
        for (char letter = 'A'; letter <= 'Z'; letter++)
        {
            var filteredNames = allNames
                .Where(name => name.StartsWith(letter.ToString(), StringComparison.OrdinalIgnoreCase))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToList();

            if (filteredNames.Count > 0)
            {
                string newFileName = $"namesStartingWith_{letter}.txt";
                string newFilePath = Path.Combine(folderPath, newFileName);

                if (File.Exists(newFilePath))
                {
                    // Reading the existing names in the filtered file
                    var existingNames = File.ReadAllLines(newFilePath)
                        .Where(n => !string.IsNullOrWhiteSpace(n))
                        .Select(n => n.Trim())
                        .ToList();

                    // Combine the existing names with new filtered names
                    var combinedNames = existingNames
                        .Concat(filteredNames)
                        .Distinct(StringComparer.OrdinalIgnoreCase)
                        .OrderBy(n => n, StringComparer.OrdinalIgnoreCase)
                        .ToList();

                    File.WriteAllLines(newFilePath, combinedNames);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Updated '{newFileName}' with {filteredNames.Count} new name(s). Total names now: {combinedNames.Count}");
                    Console.ResetColor();
                }
                else
                {
                    File.WriteAllLines(newFilePath, filteredNames);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"File '{newFileName}' created with {filteredNames.Count} name(s).");
                    Console.ResetColor();
                }
            }
            else
            {
                
            }
        }

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\nDone filtering and updating files for letters A to Z.");
        Console.ResetColor();
        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }
}
