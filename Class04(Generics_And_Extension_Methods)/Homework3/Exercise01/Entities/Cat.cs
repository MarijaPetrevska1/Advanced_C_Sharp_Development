namespace PetStore.Entities
{
    // Class Cat
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }

        public Cat(string name, int age, bool lazy, int livesLeft)
            : base(name, "Cat", age)
        {
            Lazy = lazy;
            LivesLeft = livesLeft;
        }

        // PrintInfo()
        public override void PrintInfo()
        {
            Console.WriteLine($"Cat: {Name}, Age: {Age}, Lazy: {Lazy}, Lives Left: {LivesLeft}");
        }
    }
}
