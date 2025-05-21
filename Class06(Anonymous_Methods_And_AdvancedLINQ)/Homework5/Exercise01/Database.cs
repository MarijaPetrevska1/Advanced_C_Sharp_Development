using Exercise01.Entities;
using Exercise01.Enums;
using System.Collections.Generic;

namespace Exercise01
{
    // Database
    public static class Database
    {
        // Full List of 20 dogs
        public static List<Dog> Dogs = new List<Dog>
        {
            new Dog("Buddy", "Brown", 3, Race.Bulldog),
            new Dog("Max", "Black", 5, Race.Boxer),
            new Dog("Bella", "White", 2, Race.Collie),
            new Dog("Rocky", "Gray", 4, Race.Dalmatian),
            new Dog("Lucy", "Golden", 1, Race.Mutt),
            new Dog("Charlie", "Tan", 6, Race.Mudi),
            new Dog("Daisy", "Black", 3, Race.Pointer),
            new Dog("Molly", "White", 2, Race.Pug),
            new Dog("Bailey", "Brown", 7, Race.Plott),
            new Dog("Lola", "Gray", 4, Race.Doberman),
            new Dog("Sadie", "Golden", 3, Race.Boxer),
            new Dog("Toby", "Black", 2, Race.Pug),
            new Dog("Chloe", "White", 5, Race.Collie),
            new Dog("Zoe", "Tan", 1, Race.Mutt),
            new Dog("Duke", "Gray", 6, Race.Dalmatian),
            new Dog("Roxy", "Brown", 4, Race.Bulldog),
            new Dog("Oscar", "Black", 2, Race.Pointer),
            new Dog("Maggie", "White", 5, Race.Mudi),
            new Dog("Jake", "Golden", 3, Race.Plott),
            new Dog("Ruby", "Gray", 4, Race.Doberman)
        };

        // Full List of 20 people 
        public static List<Person> People = new List<Person>
        {
            new Person("John", "Doe", 28, Job.Developer),
            new Person("Emma", "Smith", 32, Job.Dentist),
            new Person("Robert", "Johnson", 45, Job.Barber),
            new Person("Olivia", "Brown", 25, Job.Choreographer),
            new Person("James", "Davis", 38, Job.Archivist),
            new Person("Kayla", "Douglas", 28, Job.Developer),
            new Person("Richie", "Campbell", 19, Job.Waiter),
            new Person("Soren", "Velasquez", 33, Job.Interpreter),
            new Person("August", "Rubio", 21, Job.Developer),
            new Person("Rocky", "Mcgee", 57, Job.Barber),
            new Person("Emerson", "Rollins", 42, Job.Choreographer),
            new Person("Everett", "Parks", 39, Job.Sculptor),
            new Person("Amelia", "Moody", 24, Job.Waiter)
            {
                Dogs = new List<Dog> { Dogs[16], Dogs[18] }
            },
            new Person("Emilie", "Horn", 16, Job.Waiter),
            new Person("Leroy", "Baker", 44, Job.Interpreter),
            new Person("Nathen", "Higgins", 60, Job.Archivist)
            {
                Dogs = new List<Dog> { Dogs[6], Dogs[0] }
            },
            new Person("Erin", "Rocha", 37, Job.Developer)
            {
                Dogs = new List<Dog> { Dogs[2], Dogs[3], Dogs[19] }
            },
            new Person("Freddy", "Gordon", 26, Job.Sculptor)
            {
                Dogs = new List<Dog> { Dogs[4], Dogs[5], Dogs[10], Dogs[12], Dogs[13] }
            },
            new Person("Valeria", "Reynolds", 26, Job.Dentist),
            new Person("Cristofer", "Stanley", 28, Job.Dentist)
            {
                Dogs = new List<Dog> { Dogs[9], Dogs[14], Dogs[15] }
            }
        };
    }
}
