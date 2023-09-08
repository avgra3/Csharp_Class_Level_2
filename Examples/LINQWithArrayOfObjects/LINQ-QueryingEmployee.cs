using System;
using System.Linq;

namespace LINQ_Examples;

public class Employee
{
    public string FirstName { get; } // read-only auto-implemented property
    public string LastName { get; } // read-only auto-implemented property
    private decimal monthlySalary; // monthly salary of employee
    
    // Constructor intializes first name, last name and monthly salary
    public Employee(string firstName, string lastName, decimal monthlySalary)
    {
        FirstName = firstName;
        LastName = lastName;
        MonthlySalary = monthlySalary;
    }
    
    // Property that gets and sets the employee's monthly salary
    public decimal MonthlySalary
    {
        get
        {
            return monthlySalary;
        }
        set
        {
            if (value >= 0M) // validate that the salary is non-negative
            {
                monthlySalary = value;
            }
        }
    }
    // return a string containing the employee's information
    public override string ToString() =>
        $"{FirstName,-10} {LastName,-10} {MonthlySalary,10:C}";
}