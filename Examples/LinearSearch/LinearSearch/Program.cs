using System;

public class LinearSearchTest
{
    static void Main()
    {
        var generator = new Random();
        var data = new int[10]; // Creates space for array
        
        // Fill array with random ints in range 0-99
        for (var i = 0; i < data.Length; ++i)
        {
            data[i] = generator.Next(10, 100);
        }
        
        Console.WriteLine(string.Join(" ", data) + "\n"); // Displays the array
        
        // Input first int from user
        Console.Write("Enter an integer value (-1 to quit): ");
        var searchInt = int.Parse(Console.ReadLine());
        
        // repeatedly input an integer; -1 terminates the app
        while (searchInt != -1)
        {
            // perform linear search
            int position = LinearSearch(data, searchInt);

            if (position != -1) // integer was found
            {
                Console.WriteLine($"The integer {searchInt} was found in position {position}.\n");
            }
            else // integer was not found
            {
                Console.WriteLine($"The integer value {searchInt} was not found.\n");
            }
            
            // Input next int from user
            Console.Write("Enter an integer value (-1 to quit): ");
            searchInt = int.Parse(Console.ReadLine());
        }
    }
    
    // Perform the linear search on the data
    public static int LinearSearch(int[] values, int searchKey)
    {
        // loop through the array sequentially
        for (var index = 0; index < values.Length; ++index)
        {
            if (values[index] == searchKey)
            {
                return index; // returns the index of the element
            }
        }

        return -1; // If the integer is not found.
    }
}