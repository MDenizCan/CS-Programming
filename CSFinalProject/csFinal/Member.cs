namespace csFinal
{
    // Represents a library member with attributes for membership type and borrowed books.
    class Member : PersonBase
    {
        public string MembershipType { get; private set; }
        public Dictionary<string, string> BooksBorrowed { get; private set; } = new Dictionary<string, string>();
        public int Balance { get; private set; } = 0;

        public Member(string personId, string name, string membershipType)
            : base(personId, name)
        {
            MembershipType = membershipType;
        }

        // Allows the member to borrow a book, updates balance, and reduces available copies.
        public void BorrowBook(Book book)
        {
            if (!BooksBorrowed.ContainsKey(book.ISBN) && book.AvailableCopies > 0)
            {
                BooksBorrowed[book.ISBN] = book.Title;
                book.AvailableCopies--;
                Balance += book.GetCost();
                Console.WriteLine($"Book '{book.Title}' borrowed successfully.");
            }
            else
            {
                Console.WriteLine("Book not available or already borrowed.");
            }
        }

        // Allows the member to return a book and clears the balance.
        public void ReturnBook(Book book)
        {
            if (BooksBorrowed.ContainsKey(book.ISBN))
            {
                BooksBorrowed.Remove(book.ISBN);
                book.AvailableCopies++;
                Console.WriteLine($"Book '{book.Title}' returned successfully. Total fee: ${Balance}");
                Balance = 0;
            }
            else
            {
                Console.WriteLine("This book was not borrowed.");
            }
        }
        
        // Displays member details.
        public void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {PersonId}, Name: {Name}, Membership Type: {MembershipType}, Balance: ${Balance}");
        }
    }
}
