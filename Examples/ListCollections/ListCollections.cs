using System.Diagnostics;

namespace LINQWithArrayOfObjects;

public class ListCollections
{
    static void Main()
    {
        // Create a new List of strings
        var items = new List<string>();
        
        // Display list;s Count and Capacity before adding elements
        Console.WriteLine($"Before adding to items: Count = {items.Count}; Capacity = {items.Capacity}");
        
        items.Add("red"); // append an item to the list
        items.Insert(0, "yellow"); // Insert the value at index 0
        
        // Display List's Count and Capacity after adding two elements
        Console.WriteLine($"After adding two elements to items: Count = {items.Count}; Capacity = {items.Capacity}");
        
        // Display the colors in the list
        Console.Write("\nDisplay list contents with counter-controlled loop:");
        for (var i = 0; i < items.Count; i++)
        {
            Console.Write($" {items[i]}");
        }
        
        // Display colors using foreach
        Console.Write("\nDisplay list contents with foreach statement:");
        foreach (var item in items)
        {
            Console.Write($" {item}");
        }
        
        items.Add("green"); // add "green" to the end of the List
        items.Add("yellow"); // add "yellow" to the end of the List
        
        // Display List's Count and Capacity after adding two more elements
        Console.WriteLine($"\nAfter adding two more elements to items: Count = {items.Count}; Capacity = {items.Capacity}");
        
        // Display the List
        Console.Write("\nRemove first instance of yellow:");
        foreach (var item in items)
        {
            Console.Write($" {item}");
        }
        
        items.RemoveAt(1); // remove item at index 1
        
        // Display the List
        Console.Write("\nRemove second list element (green)");
        foreach (var item in items)
        {
            Console.Write($" {item}");
        }
        
        // Display List's Count and Capacity after removing two elements
        Console.Write($"\nAfter removing to elements from items: Count = {items.Count}; Capacity = {items.Capacity}");
        
        // Check if a value is in the list
        Console.WriteLine($"\n\"red\" is {(items.Contains("red") ? string.Empty : "not ")}in the list");
        
        items.Add("orange"); // add "orange" to the end of the List
        items.Add("violet"); // add "violet" to the end of teh List
        items.Add("blue"); // add "blue" to the end of the List
        
        // Display List's Count and Capacity after adding three elements
        Console.WriteLine($"\nAfter adding three more elements to items: Count = {items.Count}; Capacity = {items.Capacity}");
        
        // Display the List
        Console.Write("List with three new elements");
        foreach (var item in items)
        {
            Console.Write($" {item}");
        }
        Console.WriteLine();
    }
}