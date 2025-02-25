namespace csFinal
{
    // Represents a book with attributes for title, author, ISBN, and more.
    class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string ISBN { get; private set; }
        public int AvailableCopies { get; set; }
        public string BookType { get; private set; }
        public Librarian AssignedLibrarian { get; set; }

        public Book(string title, string author, string isbn, int availableCopies, string bookType)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            AvailableCopies = availableCopies;
            BookType = bookType;
        }

        // Determines the cost of the book based on its type.
        public int GetCost()
        {
            switch (BookType)
            {
                case "Fiction":
                    return 2; // Fiction books cost $2
                case "Science":
                    return 3; // Science books cost $3
                case "History":
                    return 2; // History books cost $2
                case "Technology":
                    return 4; // Technology books cost $4
                default:
                    return 0; // Default cost if type is unrecognized
            }
        }

        // Displays book details.
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}, Available Copies: {AvailableCopies}, Type: {BookType}");
        }
    }
}
