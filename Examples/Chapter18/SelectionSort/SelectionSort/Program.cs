using System.Runtime.InteropServices;

public class SelectionSortTest
{
    static void Main()
    {
        var generator = new Random();
        var data = new int[10]; // Create space for array
        
        // fill array with random ints in range 10-99
        for (var i = 0; i < data.Length; ++i)
        {
            data[i] = generator.Next(10, 100);
        }
        
        Console.WriteLine("Unsorted array:");
        Console.WriteLine(string.Join(" ", data) + "\n"); // Display array

        SelectionSort(data); // Sort the array
        
        Console.WriteLine("Sorted array:");
        Console.WriteLine(string.Join(" ", data) + "\n"); // Display array
    }
    
    // Sort array using selection sort
    public static void SelectionSort(int[] values)
    {
        // Loop over data.Length - 1 elements
        for (var i = 0; i < values.Length - 1; ++i)
        {
            var smallest = i; // First index of remaining array
            
            // Loop to find index of smallest element
            for (var index = i + 1; index < values.Length; ++index)
            {
                if (values[index] < values[smallest])
                {
                    smallest = index;
                }
            }

            Swap(ref values[i], ref values[smallest]); // Swap elements
            PrintPass(values, i + 1, smallest); // Output pass of algorithm
        }
    }
    
    // Helper method to swap values in two elements
    private static void Swap(ref int first, ref int second)
    {
        var temporary = first; // Store first in temporary
        first = second; // Replace first with second
        second = temporary; // Put temporary in second
    }
    
    // Display a pass of the algorithm
    public static void PrintPass(int[] values, int pass, int index)
    {
        Console.Write($"after pass {pass}: ");
        
        // Output elements through the selected item
        for (var i = 0; i < index; ++i)
        {
            Console.Write($"{values[i]} ");
        }
        
        Console.Write($"{values[index]}* "); // Indicate a swap
        
        // Finish outputting array
        for (var i = index + 1; i < values.Length; ++i)
        {
            Console.Write($"{values[i]} ");
        }
        
        Console.Write("\n\t"); // For alignment
        
        // Indicate amount of array that is sorted
        for (var j = 0; j < pass; ++j)
        {
            Console.Write("-- ");
        }
        
        Console.WriteLine("\n"); // Skip a line in the output
    }
}