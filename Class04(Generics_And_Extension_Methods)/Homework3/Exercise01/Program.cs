using System;
using PetStore.Entities;
using PetStore.Helpers;

namespace PetStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n Exercise 01 - Homework 3\n");
            Console.ResetColor();
            // Dog Store
            PetStore<Dog> dogStore = new PetStore<Dog>();
            Dog dog1 = new Dog("Dora", 3, true, "Tuna");
            Dog dog2 = new Dog("Max", 5, false, "Chicken");
            dogStore.AddPet(dog1);
            dogStore.AddPet(dog2);

            // Cat Store
            PetStore<Cat> catStore = new PetStore<Cat>();
            Cat cat1 = new Cat("Daisy", 2, true, 9);
            Cat cat2 = new Cat("Lucy", 4, false, 8);
            catStore.AddPet(cat1);
            catStore.AddPet(cat2);

            // Fish Store
            PetStore<Fish> fishStore = new PetStore<Fish>();
            Fish fish1 = new Fish("Pearl", 1, "White", "Small");
            Fish fish2 = new Fish("Sunny", 2, "Yellow", "Medium");
            fishStore.AddPet(fish1);
            fishStore.AddPet(fish2);

            // Buy pets
            dogStore.BuyPet("Dora");
            catStore.BuyPet("Lucy");

            // Print pets
            dogStore.PrintPets();
            catStore.PrintPets();
            fishStore.PrintPets();

            Console.ReadLine();
        }
    }
}

