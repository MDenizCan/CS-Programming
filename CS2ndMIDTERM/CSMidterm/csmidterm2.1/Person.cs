using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csmidterm2._1
{
    // Represents a person with a name and ID.
    class Person
    {
        // Name of the person.
        private string Name { get; set; }

        // ID of the person.
        private int ID { get; set; }

        // Constructor to create a new person with a name and ID.
        public Person(string name, int id)
        {
            Name = name;
            ID = id;
        }

        // Returns the name of the person.
        public string GetName()
        {
            return Name;
        }

        // Returns the ID of the person.
        public int GetID()
        {
            return ID;
        }
    }
}
