
// Homework 7 - Task 1
// Reading and Writing on File System
// Create a folder named "Files". Create a file name "names.txt"

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n Task 1 - Homework 7\n");
Console.ResetColor();

string folderPath = @"..\..\..\Files";
string filePath = Path.Combine(folderPath, "names.txt");

// Creating a folder named "Files"
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

// Creating a file name "names.txt"
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

Console.ReadLine();
