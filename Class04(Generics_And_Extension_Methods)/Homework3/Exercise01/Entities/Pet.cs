using System;

namespace PetStore.Entities
{
    // Abstract class Pet
    public abstract class Pet
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }

        public Pet(string name, string type, int age)
        {
            Name = name;
            Type = type;
            Age = age;
        }
        // Abstract PrintInfo()
        public abstract void PrintInfo();
    }
}
