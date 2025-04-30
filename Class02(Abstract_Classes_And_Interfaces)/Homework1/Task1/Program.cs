// CLASS 02 Homework (Task 1)
// Write a program to create an interface Searchable with a method Search(string word) that searches for a given keyword in a text document. 
// Create two classes Document and WebPage that implement the Searchable interface and provide their own implementations of the Search() method.

using SearchableDocuments.Entities;

namespace SearchableDocuments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n   ===== Homework 1 (Abstract Classes And Interfaces) =====\n");
            Console.WriteLine("   ===== Task 1 =====");
            Console.WriteLine();
            Console.ResetColor();

            // Instances of Document and WebPage
            Document doc = new Document("This is a tutorial document on how to build a mobile application");
            WebPage webPage = new WebPage("<html><body>This is a webpage containing various articles on programming tutorials.</body></html>");

            // Searching for a word in the Document
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\nDocument search:\n");
            Console.ResetColor();
            doc.Search("tutorial");
            doc.Search("content");
            doc.Search("webpage");
            doc.Search("programming");
            doc.Search("code");
            doc.Search("application");
            doc.Search("APPLICATION");

            // Searching for a word in the WebPage
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\nWebPage search:\n");
            Console.ResetColor();
            webPage.Search("html");
            webPage.Search("HTML");
            webPage.Search("document");
            webPage.Search("inside");
            webPage.Search("text");
            webPage.Search("TEXT");
            Console.ReadLine();
        }
    }
}



