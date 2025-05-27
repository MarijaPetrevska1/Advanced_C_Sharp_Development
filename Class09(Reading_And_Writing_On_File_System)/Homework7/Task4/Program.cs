using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Homework 7 - Task 4
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n Task 4 - Homework 7\n");
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

        if (!File.Exists(sourceFile))
        {
            File.Create(sourceFile).Close();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("File 'names.txt' was created.");
            Console.ResetColor();
        }

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

        char[] letters = { 'A', 'M', 'I', 'J', 'K', 'L', 'P', 'D', 'S' };

        foreach (char letter in letters)
        {
            var filteredNames = allNames
                .Where(name => name.StartsWith(letter.ToString(), StringComparison.OrdinalIgnoreCase))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToList();

            if (filteredNames.Count > 0)
            {
                string newFileName = $"namesStartingWith_{letter}.txt";
                string newFilePath = Path.Combine(folderPath, newFileName);

                HashSet<string> existingNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

                if (File.Exists(newFilePath))
                {
                    using (StreamReader sr = new StreamReader(newFilePath))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (!string.IsNullOrWhiteSpace(line))
                                existingNames.Add(line.Trim());
                        }
                    }
                }

                var namesToAdd = filteredNames.Where(n => !existingNames.Contains(n)).ToList();

                if (namesToAdd.Count > 0)
                {
                    using (StreamWriter sw = new StreamWriter(newFilePath, append: true))
                    {
                        foreach (var name in namesToAdd)
                        {
                            sw.WriteLine(name);
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"File '{newFileName}' updated with {namesToAdd.Count} new name(s).");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"File '{newFileName}' already contains all names. No new names added.");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"No names starting with '{letter}'. No file created or updated.");
                Console.ResetColor();
            }
        }

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\nDone filtering and updating names for specified letters.");
        Console.ResetColor();
        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }
}
