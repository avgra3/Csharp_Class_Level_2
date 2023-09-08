using LINQ_Examples;

namespace LINQWithArrayOfObjects;

class LINQWithArrayOfObjects
{
    static void Main()
    {
        // initialize array of employees
        var employees = new[] {
            new Employee("Jason", "Red", 5000M),
            new Employee("Ashley", "Green", 7600M),
            new Employee("Matthew", "Indigo", 3587.5M),
            new Employee("James", "Indigo", 4700.77M),
            new Employee("Luke", "Indigo", 6200M),
            new Employee("Jason", "Blue", 3200M),
            new Employee("Wendy", "Brown", 4236.4M)};
        
        // Display all employees
        Console.WriteLine("Original array:");
        foreach (var element in employees)
        {
            Console.WriteLine(element);
        }
        
        // Filter a range of salaries using && in a LINQ query
        var between4k6k =
            from e in employees
            where (e.MonthlySalary >= 4000M) && (e.MonthlySalary <= 6000M)
            select e;
        
        // Display employees making between 4,000 and 6,000 per month
        Console.WriteLine($"\nEmployees earning in the range {4000:C}-{6000:C} per month:");
        foreach (var element in between4k6k)
        {
            Console.WriteLine(element);
        }
        
        // Order the employees by last name, then first name with LINQ
        var nameSorted =
            from e in employees
            orderby e.LastName, e.FirstName
            select e;
        
        // Header
        Console.WriteLine("\nFirst employee when sorted by name:");
        // Attempt to display the first result of the above LINQ query
        if (nameSorted.Any())
        {
            Console.WriteLine(nameSorted.First());
        }
        else
        {
            Console.WriteLine("not found");
        }
        
        // Use LINQ to select employee last name
        var lastNames =
            from e in employees
            select e.LastName;
        
        // Use method distinct to select unique last names
        Console.WriteLine("\nUnique employee last names:");
        foreach (var element in lastNames.Distinct())
        {
            Console.WriteLine(element);
        }
        
        // Use LINQ to select first and last names
        // Changes property names
        var names =
            from e in employees
            select new { FirstName = e.FirstName, LastName = e.LastName };
        
        // display full names
        Console.WriteLine("\nNames only");
        foreach (var element in names)
        {
            Console.WriteLine(element);
        }
        
        Console.WriteLine();
    }
}