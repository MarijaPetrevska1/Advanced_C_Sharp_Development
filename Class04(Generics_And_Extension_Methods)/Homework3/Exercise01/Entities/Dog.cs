namespace PetStore.Entities
{
    // Class Dog
    public class Dog : Pet
    {
        public bool GoodBoy { get; set; }
        public string FavoriteFood { get; set; }

        public Dog(string name, int age, bool goodBoy, string favoriteFood)
            : base(name, "Dog", age)
        {
            GoodBoy = goodBoy;
            FavoriteFood = favoriteFood;
        }
        // PrintInfo()
        public override void PrintInfo()
        {
            Console.WriteLine($"Dog: {Name}, Age: {Age}, GoodBoy: {GoodBoy}, Favorite Food: {FavoriteFood}");
        }
    }
}

