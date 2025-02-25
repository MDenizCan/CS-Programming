namespace csFinal
{
    // Represents the library containing collections of books, members, and librarians.
    class Library
    {
        public Book[] Books { get; private set; } = new Book[100]; // Array to store up to 100 books.
        public Member[] Members { get; private set; } = new Member[100]; // Array to store up to 100 members.
        public Librarian[] Librarians { get; private set; } = new Librarian[10]; // Array to store up to 10 librarians.

        private int bookCount = 0;
        private int memberCount = 0;
        private int librarianCount = 0;

        // Adds a book to the library and assigns it to an appropriate librarian.
        public void AddBook(Book book)
        {
            for (int i = 0; i < librarianCount; i++)
            {
                if (Librarians[i] != null && Librarians[i].Specialty == book.BookType)
                {
                    book.AssignedLibrarian = Librarians[i];
                    Books[bookCount++] = book;
                    Console.WriteLine($"Book '{book.Title}' added and assigned to Librarian {Librarians[i].Name}.");
                    return;
                }
            }
            Console.WriteLine("No librarian available for this book type.");
        }

        // Registers a new member in the library.
        public void RegisterMember(Member member)
        {
            if (memberCount >= Members.Length)
            {
                Console.WriteLine("Member storage is full.");
                return;
            }

            Members[memberCount++] = member;
            Console.WriteLine($"Member '{member.Name}' registered successfully.");
        }

        // Registers a new librarian in the library.
        public void RegisterLibrarian(Librarian librarian)
        {
            if (librarianCount >= Librarians.Length)
            {
                Console.WriteLine("Librarian storage is full.");
                return;
            }

            Librarians[librarianCount++] = librarian;
            Console.WriteLine($"Librarian '{librarian.Name}' registered successfully.");
        }

        // Displays all books in the library.
        public void DisplayAllBooks()
        {
            for (int i = 0; i < bookCount; i++)
            {
                Books[i].DisplayBookInfo();
            }
        }

        // Displays all members in the library.
        public void DisplayAllMembers()
        {
            for (int i = 0; i < memberCount; i++)
            {
                Members[i].DisplayInfo();
            }
        }
    }
}

