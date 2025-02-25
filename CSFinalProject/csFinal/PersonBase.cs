namespace csFinal
{
    // Abstract class providing a base for all person types, implementing IPerson.
    abstract class PersonBase : IPerson
    {
        public string PersonId { get; private set; }
        public string Name { get; private set; }

        public PersonBase(string personId, string name)
        {
            PersonId = personId;
            Name = name;
        }
    }
}
