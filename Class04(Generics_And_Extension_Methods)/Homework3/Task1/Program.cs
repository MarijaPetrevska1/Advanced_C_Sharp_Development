using System.Collections.Generic;
using Task1.Entities;
using Task1.Models;

PrintInConsole consoleWriter = new PrintInConsole();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n Task 1 - Homework 3\n");
Console.ResetColor();
// Print a single book
Book singleBook = new Book { Title = "A Game of Thrones", Author = "George R. R. Martin" };
consoleWriter.Print(singleBook);

// Print a collection of books
List<Book> library = new List<Book>
{
    new Book { Title = "Gone Girl", Author = "Gillian Flynn" },
    new Book { Title = "Don Quixote", Author = "Miguel de Cervantes" },
    new Book { Title = "Harry Potter and the Sorcerer's Stone", Author = "J.K. Rowling" }
};

consoleWriter.PrintCollection(library);

// Print some other types 
consoleWriter.Print(3.14);
consoleWriter.PrintCollection(new List<string> { "First", "Second", "Third" });
Console.ReadLine();
        