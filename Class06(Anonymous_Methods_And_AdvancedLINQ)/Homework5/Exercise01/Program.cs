using Exercise01;
using Exercise01.Entities;
using Exercise01.Enums;
using Exercise01.Helpers;


// Homework 5 - Exercise01
// Anonymous methods and Advanced LINQ

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\n Exercise 01 - Homework 5\n");
Console.ResetColor();

//1) Find and print all persons first names starting with 'R', ordered by Age - DESCENDING ORDER

Console.WriteLine("\n=== Find and print all people - First Names Starting with 'R' - Ordered By Age DESC ===\n");

// SQL like
List<string> namesR_SQL = (from person in Database.People
                           where person.FirstName.StartsWith("R")
                           orderby person.Age descending
                           select person.FirstName).ToList();

// Lambda LINQ Syntax
List<string> firstNamesR_Lambda = Database.People
    .Where(p => p.FirstName.StartsWith("R"))
    .OrderByDescending(p => p.Age)
    .Select(p => p.FirstName)
    .ToList();

namesR_SQL.PrintSimple();
firstNamesR_Lambda.PrintSimple();

//2) Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER

Console.WriteLine("\n=== Find and print all brown dogs older than 3, ordered by age - ASC ===\n");

// SQL-like
List<Dog> brownDogs_SQL = (from dog in Database.Dogs
                           where dog.Color == "Brown" && dog.Age > 3
                           orderby dog.Age
                           select dog).ToList();

// Lambda LINQ syntax
List<Dog> brownDogs_Lambda = Database.Dogs
    .Where(d => d.Color == "Brown" && d.Age > 3)
    .OrderBy(d => d.Age)
    .ToList();

brownDogs_SQL.PrintEntities();
brownDogs_Lambda.PrintEntities();

//3) Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER

Console.WriteLine("\n=== Find and print all people With More Than 2 Dogs - ordered by name - DESC ===\n");

// SQL-like
List<Person> DogOwners_SQL = (from person in Database.People
                                   where person.Dogs.Count > 2
                                   orderby person.FirstName descending
                                   select person).ToList();

// Lambda LINQ syntax
List<Person> DogOwners_Lambda = Database.People
    .Where(p => p.Dogs.Count > 2)
    .OrderByDescending(p => p.FirstName)
    .ToList();

DogOwners_SQL.PrintEntities();
DogOwners_Lambda.PrintEntities();

//4) Find and print all Freddy`s dogs names older than 1 year

Console.WriteLine("\n=== Find and print all Freddy`s dogs names older than 1 year ===\n");

// SQL like
List<string> freddyDogsSQL = (from person in Database.People
                               where person.FirstName == "Freddy"
                               from dog in person.Dogs
                               where dog.Age > 1
                               select dog.Name).ToList();

// Lambda LINQ Syntax
List<string> freddyDogsLambda = Database.People
    .Where(p => p.FirstName == "Freddy")
    .SelectMany(p => p.Dogs)
    .Where(d => d.Age > 1)
    .Select(d => d.Name)
    .ToList();

freddyDogsSQL.PrintSimple();
freddyDogsLambda.PrintSimple();

//5) Find and print Nathen`s first dog

Console.WriteLine("\n=== Find and print Nathen`s first dog ===\n");

// SQL like
Dog? nathensFirstDog_SQL = (from person in Database.People
                            where person.FirstName == "Nathen"
                            select person.Dogs.FirstOrDefault()).FirstOrDefault();

// Lambda LINQ syntax
Dog? nathensFirstDog_Lambda = Database.People
    .FirstOrDefault(p => p.FirstName == "Nathen")?
    .Dogs.FirstOrDefault();

Console.WriteLine(nathensFirstDog_SQL != null ? nathensFirstDog_SQL.ToString() : "No dog found");
Console.WriteLine(nathensFirstDog_Lambda != null ? nathensFirstDog_Lambda.ToString() : "No dog found");

//6) Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER

Console.WriteLine("\n=== Find and print all White Dogs from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER ===\n");

string[] names = { "Cristofer", "Freddy", "Erin", "Amelia" };

// SQL like
List<string> whiteDogsSQL = (from person in Database.People
                              where names.Contains(person.FirstName)
                              from dog in person.Dogs
                              where dog.Color == "White"
                              orderby dog.Name
                              select dog.Name).ToList();

// Lambda LINQ syntax
List<string> whiteDogsLambda = Database.People
    .Where(p => names.Contains(p.FirstName))
    .SelectMany(p => p.Dogs)
    .Where(d => d.Color == "White")
    .OrderBy(d => d.Name)
    .Select(d => d.Name)
    .ToList();

whiteDogsSQL.PrintSimple();
whiteDogsLambda.PrintSimple();

Console.ReadLine();

