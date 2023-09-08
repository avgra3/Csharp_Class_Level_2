namespace LINQ_Examples;

public class LINQWithSimpleTypeArray
{
    static void Main()
    {
        // Create an iteger array
        var values = new[] { 2, 9, 5, 0, 3, 7, 1, 4, 8, 5 };
        
        // Display original values
        Console.Write("Original Array: ");
        foreach (var element in values)
        {
            Console.Write($"{element} ");
        }
        
        // LINQ query that obtains values > 4 from the array
        var filtered =
            from value in values // data source is values, the array from above
            where value > 4
            select value;
        
        // Display the filtered results
        Console.Write("\nArray values > 4: ");
        foreach (var element in filtered)
        {
            Console.Write($"{element} ");
        }
        
        // Use order-by clause to sort original values in ascending order
        var sorted =
            from value in values // data source is values
            orderby value
            select value;
        
        // Display sorted results
        Console.Write("\nOriginal array, sorted: ");
        foreach (var element in sorted)
        {
            Console.Write($"{element}");
        }
        
        // Sort the filtered results in descending order
        var sortFilteredResults =
            from value in filtered // data source is LINQ query filtered
            orderby value descending
            select value;
        
        // Display sorted results
        Console.Write("\nValues > 4, descending order (two queries): ");
        foreach (var element in sortFilteredResults)
        {
            Console.Write($"{element} ");
        }
        
        // Filter original array and sort results in descending order
        var sortAndFilter =
            from value in values // data source is values
            where value > 4
            orderby value descending
            select value;
        
        // Display the filtered and sorted results
        Console.Write("\nValues > 4, descending order (one query):");
        foreach (var element in sortAndFilter)
        {
            Console.Write($" {element}");
        }
        Console.WriteLine();
    }
}