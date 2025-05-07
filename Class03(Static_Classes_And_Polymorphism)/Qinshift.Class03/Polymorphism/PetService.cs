using Polymorphism.Models;

namespace Polymorphism
{
    public class PetService
    {
        public void PrintPetInfo()
        {
            Console.WriteLine("Some info");
        }

        public void PrintPetInfo(Cat cat)
        {
            Console.WriteLine($"This cat is {(cat.IsLazy ? "lazy" : "not lazy")}");
        }

        public void PrintPetInfo(string ownerName, Cat cat)
        {
            Console.WriteLine($"The owner {ownerName} has cat named {cat.Name}");
        }

        public void PrintPetInfo(Cat cat, string ownerName)
        {
            Console.WriteLine($"The owner {ownerName} has cat named {cat.Name}");
        }

        public void PrintPetInfo(Dog dog, string ownerName)
        {
            Console.WriteLine($"The owner {ownerName} has dog named {dog.Name}");
        }
    }
}
