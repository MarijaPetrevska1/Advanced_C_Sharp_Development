using SearchableDocuments.Interfaces;

namespace SearchableDocuments.Entities
{
    // The Document Class
    public class Document : ISearchable
    {
        // Property to hold the text content of the document
        public string Text { get; set; }

        // Constructor 
        public Document(string text)
        {
            Text = text;
        }

        // Implementation of the Search method from the ISearchable interface
        public void Search(string word)
        {

            // Checking if the word is null or empty
            if (string.IsNullOrWhiteSpace(word))
            {
                Console.WriteLine("Please provide a valid search term.");
                return;
            }

            // Checking if the document's text is null or empty
            if (string.IsNullOrWhiteSpace(Text))
            {
                Console.WriteLine("The document is empty.");
                return;
            }
            if (Text.ToLower().Contains(word.ToLower()))
            {
                Console.WriteLine($" Found the word '{word}' in the document!");
            }
            else
            {
                Console.WriteLine($" The word '{word}' was not found in the document.");
            }
        }
    }
}
