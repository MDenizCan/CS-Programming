// Name: Mehmet Deniz  
// Surname: Can
// Number: 225060053
using System;

namespace ParkingManagementSystem
{
    // Car class
    class Car
    {
        // License plate of the car
        private string LicensePlate;

        // Entry time of the car to the parking lot
        private DateTime EntryTime;

        // Initializes the car with its license plate and the current time
        public Car(string licensePlate)
        {
            LicensePlate = licensePlate;
            EntryTime = DateTime.Now; // Set the entry time to the current time
        }

        // Method to get the license plate of the car
        public string GetLicensePlate()
        {
            return LicensePlate;
        }

        // Method to get the entry time of the car
        public DateTime GetEntryTime()
        {
            return EntryTime;
        }

        // Method to get car information
        public string GetCarInfo()
        {
            return $"License Plate: {LicensePlate}, Entry Time: {EntryTime}";
        }
    }

    // ParkingLot class manages the parking lot functionality
    class ParkingLot
    {
        private const int Capacity = 20; // Maximum capacity of the parking lot
        private Car[] parkedCars = new Car[Capacity]; // Array to hold parked cars
        private int currentCarCount = 0; // Counter for the number of parked cars
        public const int HourlyRate = 5; // Hourly parking fee

        // Method to add a car to the parking lot
        public void AddCar(string LicensePlate)
        {
            
            if (currentCarCount >= Capacity) // Check if the parking lot is full
            {
                Console.WriteLine("Parking lot is full. Cannot add more cars.");

            }
            else if (FindCarIndex(LicensePlate) != -1) // Check if the license plate already exists
            {
                Console.WriteLine("A car with this license plate is already parked.");

            }
            else // Add the car to the array and increment the counter
            {
                parkedCars[currentCarCount] = new Car(LicensePlate);
                currentCarCount++;
                Console.WriteLine("Car added successfully.");
            }
        }

        // Method to remove a car from the parking lot
        public void RemoveCar(string LicensePlate)
        {
            // Find the index of the car in the array
            int carIndex = FindCarIndex(LicensePlate);

            // If the car is not found, display an error message
            if (carIndex == -1)
            {
                Console.WriteLine("Car not found in the parking lot.");
            }
            else
            {
                // Calculate the parking fee
                DateTime EntryTime = parkedCars[carIndex].GetEntryTime();
                DateTime exitTime = DateTime.Now;
                int hoursParked = (int)Math.Ceiling((exitTime - EntryTime).TotalHours);
                int fee = hoursParked * HourlyRate;

                Console.WriteLine($"Car removed successfully. Parking fee: ${fee}");

                // Shift the remaining cars to fill the gap
                for (int i = carIndex; i < currentCarCount - 1; i++)
                {
                    parkedCars[i] = parkedCars[i + 1];
                }

                // Set the last car to null and decrement the counter
                parkedCars[currentCarCount - 1] = null; 
                currentCarCount--;
            }
        }

        // Method to view all currently parked cars
        public void ViewCars()
        {
            if (currentCarCount == 0) // If no cars are parked, display a message
            {
                Console.WriteLine("No cars are currently parked.");
            }
            else
            {
                Console.WriteLine("Parked Cars:");// Display the list of parked cars
                for (int i = 0; i < currentCarCount; i++)
                {
                    Console.WriteLine(parkedCars[i].GetCarInfo());
                }
            }

        }

        // Helper method to find the index of a car based on its license plate
        private int FindCarIndex(string LicensePlate)
        {
            for (int i = 0; i < currentCarCount; i++)
            {
                // Compare license plates ignoring case sensitivity
                if (parkedCars[i].GetLicensePlate() == LicensePlate)
                {
                    return i; // Return the index if found
                }
            }
            return -1; // Return -1 if the car is not found
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            ParkingLot parkingLot = new ParkingLot(); // Create an instance of ParkingLot
            bool exit = false; // Flag to exit the program

            while (!exit)
            {
                // Display menu options
                Console.WriteLine("\nParking Lot Menu:");
                Console.WriteLine("1. Add a car");
                Console.WriteLine("2. Remove a car");
                Console.WriteLine("3. View parked cars");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                // Read user input
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the license plate of the car: ");
                        string LicensePlate = Console.ReadLine();
                        parkingLot.AddCar(LicensePlate);
                        break;

                    case "2":
                        Console.Write("Enter the license plate of the car to remove: ");
                        string plateToRemove = Console.ReadLine();
                        parkingLot.RemoveCar(plateToRemove);
                        break;

                    case "3":
                        parkingLot.ViewCars();
                        break;

                    case "4":
                        exit = true; // to exit set the exit flag to true 
                        Console.WriteLine("Exiting the program.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
