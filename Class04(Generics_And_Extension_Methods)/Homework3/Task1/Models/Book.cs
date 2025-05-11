namespace Task1.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return "\"" + Title + "\" by " + Author;
        }
    }
}



