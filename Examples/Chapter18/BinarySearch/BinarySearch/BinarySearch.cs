public class BinarySearch
{
    static void Main()
    {
        var generator = new Random();
        var data = new int[15]; // Create space for array

        // fill array with random ints in range 10-99
        for (var i = 0; i < data.Length; ++i)
        {
            data[i] = generator.Next(10, 100);
        }

        Array.Sort(data); // elements must be sorted in ascending order
        DisplayElements(data, 0, data.Length - 1); // Display array

        // Input first int from user
        Console.Write("\nPlease enter an integer value (-1 to quit): ");
        int searchInt = int.Parse(Console.ReadLine());

        // Repeatedly input an integer; -1 terminates the app
        while (searchInt != -1)
        {
            // Perform binary search
            int position = BinarySearchTest(data, searchInt);
            if (position != -1) // Integer was found
            {
                Console.WriteLine($"The integer {searchInt} was found in position {position}.\n");
            }
            else
            {
                Console.WriteLine($"The integer {searchInt} was not found.\n");
            }

            // Input next int from user
            Console.Write("Please enter an integer value (-1 to quit): ");
            searchInt = int.Parse(Console.ReadLine());
        }
    }

    private static int BinarySearchTest(int[] values, int searchElement)
    {
        int low = 0; // low end of the search area
        int high = values.Length - 1; // high end of the search area
        int middle = (high + 1) / 2; // Middle Element

        do // loop to search for element
        {
            // Display remaining elements of array
            DisplayElements(values, low, high);

            // Indicate current middle; pad left with spaces for alignment
            Console.WriteLine("-- ".PadLeft((middle + 1) * 3));

            // If element is found at the middle
            if (searchElement == values[middle])
            {
                return middle; // Search key found, so return its index
            }
            // Middle element too high
            else if (searchElement < values[middle])
            {
                high = middle - 1; // Eliminate the higher half
            }
            else // Middle element too low
            {
                low = middle + 1; // Eliminate the lower half
            }

            middle = (low + high + 1) / 2; // Recalculate the middle
        } while (low <= high);

        return -1; // Search key was not found.
    }

    // Method to output certain values in the array
    private static void DisplayElements(int[] values, int low, int high)
    {
        // Output three spaces for each element up to low for alignment
        Console.WriteLine(string.Empty.PadLeft(low * 3));

        // Output elements left in array
        for (var i = low; i <= high; ++i)
        {
            Console.Write($"{values[i]} ");
        }

        Console.WriteLine();
    }
}