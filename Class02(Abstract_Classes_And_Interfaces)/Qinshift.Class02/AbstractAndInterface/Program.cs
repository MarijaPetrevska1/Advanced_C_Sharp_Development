using AbstractAndInterface.Entities;
using AbstractAndInterface.Interfaces;


#region Abstract classes


//Human human = new Human();  => This will not work.

Developer dev = new Developer("Marija Petrevska", 26, 070222555,
    new List<string> { "C#", "JavaScript", "Java" }, 1);

Tester tester = new Tester("Bob Bobsky", 32, 078234567, 100);


Console.WriteLine("The Developer:");
Console.WriteLine(dev.GetInfo());
dev.Greet("Students");
dev.Code();
dev.Debug();


Console.WriteLine("---------------------------");
Console.WriteLine("The tester:");
Console.WriteLine(tester.GetInfo());
tester.Greet("Students");
tester.TestFeature("Demo example feature");
tester.WriteTestCases();
tester.DocumentBugs();

if (tester.FoundBug())
{
    Console.WriteLine("The tester found a bug! Please fix it!");
}


#endregion


#region Interfaces


void DoSomething(IHuman human, string name)
{
    human.Greet(name);
    Console.WriteLine(human.SayGoodbye(name));
}


DoSomething(dev, "Marija");
DoSomething(tester, "Marija");



#endregion