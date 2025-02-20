using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csmidterm2._1
{
    class Employee : Person // Declares a public class 'Employee' that inherits from the 'Person' class
    {
        private int workingHours; // Private field to store the number of working hours
        private double extraEarnings; // Private field to store extra earnings (e.g., commissions)
        public Employee(string _name, int _id, int _workingHours) : base(_name, _id) // Constructor to initialize the 'Employee' object with name, ID, and working hours; calls the base class constructor
        {
            workingHours = _workingHours;
            extraEarnings = 0;
        }
        public double CalculateWeeklyPay() 
        { 
            return workingHours * 5;  // Calculates weekly pay based on working hours and a rate of $5 per hour
        }
        public void AddCommission(double amount) 
        { 
            extraEarnings += amount; // Adds the specified amount to 'extraEarnings'
        } 
        public double GetExtraEarnings() 
        {
            return extraEarnings; // Public method to retrieve the value of 'extraEarnings'
        }
        public override string ToString() // Overrides the base class 'ToString' method to provide a custom string representation of the object
        {
            return $"Employee: {GetName()}, ID: {GetID()}, Weekly Pay: {CalculateWeeklyPay()}, Extra Earnings: {extraEarnings}"; // Returns a formatted string with employee details
        }
    }
}
