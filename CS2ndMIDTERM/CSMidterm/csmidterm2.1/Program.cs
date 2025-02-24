using System;

namespace csmidterm2._1
{
    class Program
    {
        // Arrays to store Clients and employees
        static Client[] Clients = new Client[100];
        static Employee[] employees = new Employee[100];
        static int clientCount = 0;
        static int employeeCount = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                // Menu options for the user
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add a new employee");
                Console.WriteLine("2. Add a new Client");
                Console.WriteLine("3. Calculate total price of items purchased by a Client");
                Console.WriteLine("4. Display all Clients");
                Console.WriteLine("5. Display all employees");
                Console.WriteLine("6. Exit");

                Console.Write("Choose an option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                // Handle user input
                switch (choice)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        AddClient();
                        break;
                    case 3:
                        CalculateClientTotal();
                        break;
                    case 4:
                        DisplayAllClients();
                        break;
                    case 5:
                        DisplayAllEmployees();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        // Method to add a new employee
        static void AddEmployee()
        {
            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();

            Console.Write("Enter employee ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter employee working hours: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            employees[employeeCount++] = new Employee(name, id, hours);
            Console.WriteLine("Employee added successfully.");
        }

        // Method to add a new Client
        static void AddClient()
        {
            Console.Write("Enter Client name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Client ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Client Client = new(name, id);

            Console.Write("Enter the number of items to purchase: ");
            int itemCount = Convert.ToInt32(Console.ReadLine());

            // Add items to the Client's purchased list
            for (int i = 0; i < itemCount; i++)
            {
                Console.Write("Enter item name (Shirt/Pants/Shoes): ");
                string item = Console.ReadLine();

                Console.Write("Enter quantity: ");
                int quantity = Convert.ToInt32(Console.ReadLine());

                Client.AddItem(item, quantity);
            }

            Console.Write("Enter employee ID to assign: ");
            int empId = Convert.ToInt32(Console.ReadLine());

            // Find and assign an employee to the Client
            Employee assignedEmployee = Array.Find(employees, e => e != null && e.GetID() == empId);

            if (assignedEmployee != null)
            {
                Client.AssignEmployee(assignedEmployee);

                // Calculate commission for the assigned employee
                foreach (var item in Client.PurchasedItems)
                {
                    double commission = 0; // Variable to store the commission for the current item
                    switch (item.Key) // Checks the item type to determine its commission rate
                    {
                        case "Shirt":
                            commission = 0.05 * (5 * item.Value); // Calculates commission for shirts
                            break;
                        case "Pants":
                            commission = 0.10 * (10 * item.Value); // Calculates commission for pants
                            break;
                        case "Shoes":
                            commission = 0.20 * (30 * item.Value); // Calculates commission for shoes
                            break;
                    }
                    assignedEmployee.AddCommission(commission);
                }

                Clients[clientCount++] = Client;
                Console.WriteLine("Client added successfully.");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        // Method to calculate the total price of items purchased by a Client
        static void CalculateClientTotal()
        {
            Console.Write("Enter Client ID: ");
            int clientId = Convert.ToInt32(Console.ReadLine());

            // Find the Client by ID
            Client Client = Array.Find(Clients, c => c != null && c.GetID() == clientId);

            if (Client != null)
            {
                Console.WriteLine($"Total price: {Client.CalculateTotalPrice()}$");
            }
            else
            {
                Console.WriteLine("Client not found.");
            }
        }

        // Method to display all Clients and their details
        static void DisplayAllClients()
        {
            foreach (var Client in Clients)
            {
                if (Client != null)
                {
                    Console.WriteLine($"\nClient Name: {Client.GetName()}, ID: {Client.GetID()}");
                    Console.WriteLine("Purchased Items:");

                    foreach (var item in Client.PurchasedItems)
                    {
                        Console.WriteLine($"{item.Key}: {item.Value}");
                    }

                    Console.WriteLine($"Assigned Employee: {Client.AssignedEmployee.GetName()}");
                }
            }
        }

        // Method to display all employees and their details
        static void DisplayAllEmployees()
        {
            foreach (var employee in employees)
            {
                if (employee != null)
                {
                    Console.WriteLine($"\nEmployee Name: {employee.GetName()}, ID: {employee.GetID()}");
                    Console.WriteLine($"Weekly Pay: {employee.CalculateWeeklyPay()}$");
                    Console.WriteLine($"Extra Earnings: {employee.GetExtraEarnings()}$");
                }
            }
        }
    }
}
