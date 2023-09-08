namespace LINQQueryGenericList;

public class LINQWithListCollection
{
    static void Main()
    {
        // populate a List of strings
        var items = new List<string>();
        items.Add("aQua"); // add "aQua" to the end of the list
        items.Add("RusT"); // add "RusT" to the end of the list
        items.Add("yElLow"); // add "yElLow" to the end of the list
        items.Add("rEd"); // add "rEd" to the end of the list
        
        // display initial List
        Console.Write("items contains: ");
        foreach (var item in items)
        {
            Console.Write($" {item}");
        }
        Console.WriteLine(); // Output end of line
        
        // convert values to uppercase, select those with "R" and sort
        var startWithR =
            from item in items
            let upperCaseString = item.ToUpper()
            where upperCaseString.StartsWith("R")
            orderby upperCaseString
            select upperCaseString;
        
        // Display query results
        Console.Write("results of query startWithR:");
        foreach (var item in startWithR)
        {
            Console.Write($" {item}");
        }
        Console.WriteLine(); // Output end of line
        
        items.Add("rUbY"); // add "rUbY" to the end of the List
        items.Add("SaFfRon"); // add "SaFfRon" to the end of the List
        
        // display initial List
        Console.Write("items contains: ");
        foreach (var item in items)
        {
            Console.Write($" {item}");
        }
        Console.WriteLine(); // Output end of line
        
        // Display updated query results
        Console.Write("results of query startsWithR:");
        foreach (var item in startWithR)
        {
            Console.Write($" {item}");
        }
        Console.WriteLine(); // Output end of line
    }
}