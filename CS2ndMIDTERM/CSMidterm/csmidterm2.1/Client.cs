using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csmidterm2._1
{
    // Represents a customer in the system.
    class Client : Person
    {
        // Stores the items and quantities purchased by the client.
        public Dictionary<string, int> PurchasedItems = new Dictionary<string, int>();

        // The employee assigned to the client.
        public Employee AssignedEmployee; 

        // Constructor to create a new client with a name and ID.
        public Client(string name, int id) : base(name, id) { }

        // Adds an item and its quantity to the purchase list.
        public void AddItem(string item, int quantity)
        {
            if (PurchasedItems.ContainsKey(item))
                PurchasedItems[item] += quantity; // Update quantity if item exists.
            else
                PurchasedItems[item] = quantity; // Add new item.
        }

        // Assigns an employee to assist the client.
        public void AssignEmployee(Employee employee)
        {
            AssignedEmployee = employee;
        }

        // Calculates the total price of purchased items.
        public double CalculateTotalPrice()
        {
            double total = 0;

            // Adds price for each item based on its type.
            for (int i = 0; i < PurchasedItems.Count; i++)
            {
                var item = PurchasedItems.ElementAt(i);

                total += item.Key switch
                {
                    "Shirt" => 5 * item.Value,  // Shirt: $5 each
                    "Pants" => 10 * item.Value, // Pants: $10 each
                    "Shoes" => 30 * item.Value, // Shoes: $30 each
                    _ => 0 // Unrecognized items are free.
                };
            }

            return total;
        }

    }
}
