public class InsertionSortTest
{
    static void Main()
    {
        var generator = new Random();
        var data = new int[10]; // Create space for array
        
        // Fill array with random ints in range 10-99
        for (var i = 0; i < data.Length; ++i)
        {
            data[i] = generator.Next(10, 100);
        }
        
        Console.WriteLine("Unsorted array:");
        Console.WriteLine(string.Join(" ", data) + "\n"); // Display the array

        InsertionSort(data); // Sort array
        
        Console.WriteLine("Sorted array");
        Console.WriteLine(string.Join(" ", data) + "\n"); // Display the array
    }
    
    // Sort the array using Insertion Sort
    public static void InsertionSort(int[] values)
    {
        // Loop over data.Length - 1 elements
        for (var next = 1; next < values.Length; ++next)
        {
            // Store value in current element
            var insert = values[next];
            
            // Initialize location to place element
            var moveItem = next;
            
            // Search for place to put current element
            while (moveItem > 0 && values[moveItem - 1] > insert)
            {
                // Shift element right one slot
                values[moveItem] = values[moveItem - 1];
                moveItem--;
            }

            values[moveItem] = insert; // Place inserted element
            PrintPass(values, next, moveItem); // Output pass of algorithm
        }
    }
    
    // Display a pass of the algorithms
    public static void PrintPass(int[] values, int pass, int index)
    {
        Console.Write($"after pass {pass}: ");
        
        // Output elements till swapped item
        for (var i = 0; i < index; ++i)
        {
            Console.Write($"{values[i]}  ");
        }
        
        Console.Write($"{values[index]}*  "); // Indicate swap
        
        // Finish outputting array
        for (var i = index + 1; i < values.Length; ++i)
        {
            Console.Write($"{values[i]}  ");
        }
        
        Console.Write("\n\t   "); // For alignment
        
        // Indicate amount of array that is sorted
        for (var i = 0; i <= pass; ++i)
        {
            Console.Write($"--  ");
        }
        
        Console.WriteLine("\n"); // Skip a line in output
    }
}