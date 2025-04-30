using SearchableDocuments.Interfaces;

namespace SearchableDocuments.Entities
{
    // The WebPage Class
    public class WebPage : ISearchable
    {
        // Property to hold the text content of the webpage
        public string Text { get; set; }

        // Constructor
        public WebPage(string text)
        {
            Text = text;
        }
        // Implementation of the Search method from the ISearchable interface.
        public void Search(string word)
        {
            if (Text.ToLower().Contains(word.ToLower()))
            {
                Console.WriteLine($" Found the word '{word}' on the webpage!");
            }
            else
            {
                Console.WriteLine($" The word '{word}' was not found on the webpage.");
            }
        }
    }
}
