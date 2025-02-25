namespace csFinal
{
    // Entry point for the Library Management System.
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Library class.
            Library library = new Library();

            // Infinite loop for displaying the menu until the user exits.
            while (true)
            {
                // Display menu options.
                Console.WriteLine("\nLibrary Management System");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Register Member");
                Console.WriteLine("3. Register Librarian");
                Console.WriteLine("4. View All Books");
                Console.WriteLine("5. View All Members");
                Console.WriteLine("6. Borrow Book");
                Console.WriteLine("7. Return Book");
                Console.WriteLine("8. Exit");
                Console.Write("Enter your choice: ");

                // Read user's choice and convert it to an integer.
                int choice = Convert.ToInt32(Console.ReadLine());

                // Handle each menu option using a switch statement.
                switch (choice)
                {
                    case 1:
                        // Add a new book to the library.
                        Console.Write("Enter book title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter author: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter ISBN: ");
                        string isbn = Console.ReadLine();
                        Console.Write("Enter available copies: ");
                        int availableCopies = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter book type (Fiction, Science, History, Technology): ");
                        string bookType = Console.ReadLine();

                        // Create a new Book instance and add it to the library.
                        Book book = new Book(title, author, isbn, availableCopies, bookType);
                        library.AddBook(book);
                        break;

                    case 2:
                        // Register a new member in the library.
                        Console.Write("Enter Member ID: ");
                        string memberId = Console.ReadLine();
                        Console.Write("Enter Member Name: ");
                        string memberName = Console.ReadLine();
                        Console.Write("Enter Membership Type (Basic, Premium): ");
                        string membershipType = Console.ReadLine();

                        // Create a new Member instance and register it.
                        Member member = new Member(memberId, memberName, membershipType);
                        library.RegisterMember(member);
                        break;

                    case 3:
                        // Register a new librarian in the library.
                        Console.Write("Enter Librarian ID: ");
                        string librarianId = Console.ReadLine();
                        Console.Write("Enter Librarian Name: ");
                        string librarianName = Console.ReadLine();
                        Console.Write("Enter Salary: ");
                        int salary = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Specialty (Fiction, Science, History, Technology): ");
                        string specialty = Console.ReadLine();

                        // Create a new Librarian instance and register it.
                        Librarian librarian = new Librarian(librarianId, librarianName, salary, specialty);
                        library.RegisterLibrarian(librarian);
                        break;

                    case 4:
                        // Display all books in the library.
                        library.DisplayAllBooks();
                        break;

                    case 5:
                        // Display all registered members in the library.
                        library.DisplayAllMembers();
                        break;

                    case 6:
                        // Borrow a book by a member.
                        Console.Write("Enter Member ID: ");
                        string borrowMemberId = Console.ReadLine();
                        Console.Write("Enter ISBN of the book: ");
                        string borrowIsbn = Console.ReadLine();

                        // Find the member by ID.
                        Member borrowingMember = null;
                        for (int i = 0; i < library.Members.Length; i++)
                        {
                            if (library.Members[i] != null && library.Members[i].PersonId == borrowMemberId)
                            {
                                borrowingMember = library.Members[i];
                            }
                        }

                        // Find the book by ISBN.
                        Book borrowingBook = null;
                        for (int i = 0; i < library.Books.Length; i++)
                        {
                            if (library.Books[i] != null && library.Books[i].ISBN == borrowIsbn)
                            {
                                borrowingBook = library.Books[i];
                            }
                        }

                        // Borrow the book if both the member and book are found.
                        if (borrowingMember != null && borrowingBook != null)
                        {
                            borrowingMember.BorrowBook(borrowingBook);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Member ID or ISBN.");
                        }
                        break;

                    case 7:
                        // Return a book by a member.
                        Console.Write("Enter Member ID: ");
                        string returnMemberId = Console.ReadLine();
                        Console.Write("Enter ISBN of the book: ");
                        string returnIsbn = Console.ReadLine();

                        // Find the member by ID.
                        Member returningMember = null;
                        for (int i = 0; i < library.Members.Length; i++)
                        {
                            if (library.Members[i] != null && library.Members[i].PersonId == returnMemberId)
                            {
                                returningMember = library.Members[i];
                            }
                        }

                        // Find the book by ISBN.
                        Book returningBook = null;
                        for (int i = 0; i < library.Books.Length; i++)
                        {
                            if (library.Books[i] != null && library.Books[i].ISBN == returnIsbn)
                            {
                                returningBook = library.Books[i];
                            }
                        }

                        // Return the book if both the member and book are found.
                        if (returningMember != null && returningBook != null)
                        {
                            returningMember.ReturnBook(returningBook);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Member ID or ISBN.");
                        }
                        break;

                    case 8:
                        // Exit the program.
                        Console.WriteLine("Exiting the system. Goodbye!");
                        return;

                    default:
                        // Handle invalid menu options.
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
