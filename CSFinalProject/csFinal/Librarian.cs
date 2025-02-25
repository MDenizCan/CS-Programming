namespace csFinal
{
    // Represents a librarian with additional attributes like Salary and Specialty.
    class Librarian : PersonBase
    {
        public int Salary { get; private set; }
        public string Specialty { get; private set; }

        public Librarian(string personId, string name, int salary, string specialty)
            : base(personId, name)
        {
            Salary = salary;
            Specialty = specialty;
        }

        // Displays librarian details.
        public void DisplayInfo()
        {
            Console.WriteLine($"Librarian ID: {PersonId}, Name: {Name}, Salary: ${Salary}, Specialty: {Specialty}");
        }
    }

}
