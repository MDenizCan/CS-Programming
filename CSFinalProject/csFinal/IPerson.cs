using System;
namespace csFinal
{
    // Defines the basic structure for a person with ID and Name properties.
    interface IPerson
    {
        string PersonId { get; }
        string Name { get; }
    }
}
