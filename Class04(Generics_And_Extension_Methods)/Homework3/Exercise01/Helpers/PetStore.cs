using System;
using System.Collections.Generic;
using System.Linq;
using PetStore.Entities;

namespace PetStore.Helpers
{
    public class PetStore<T> where T : Pet
    {
        private List<T> pets = new List<T>();

        public void AddPet(T pet)
        {
            pets.Add(pet);
        }

        public void PrintPets()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{typeof(T).Name} Store Pets: \n");
            Console.ResetColor();
            foreach (T pet in pets) 
            {
                pet.PrintInfo();
            }
            Console.WriteLine();
        }

        public void BuyPet(string name)
        {
            T pet = pets.FirstOrDefault(p => p.Name.ToLower() == name.ToLower());
            if (pet != null)
            {
                pets.Remove(pet);
                Console.WriteLine($" Success! You've adopted {pet.Name}, the {pet.Type}.\n");
            }
            else
            {
                Console.WriteLine($"Sorry, no pet named '{name}' found in our {typeof(T).Name} store.\n");
            }
        }
    }
}

