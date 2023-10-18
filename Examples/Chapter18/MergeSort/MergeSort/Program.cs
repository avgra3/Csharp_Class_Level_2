public class MergeSortTest
{
    public static void Main()
    {
        var generator = new Random();
        var data = new int[10]; // Create space for array
        
        // Fill array with random ints in range 10-99
        for (var i = 0; i < data.Length; ++i)
        {
            data[i] = generator.Next(10, 100);
        }
        
        Console.WriteLine("Unsorted array:");
        Console.WriteLine(string.Join(" ", data) + "\n"); // Display array

        MergeSort(data); // Sort the array
        
        Console.WriteLine("Sorted array:");
        Console.WriteLine(string.Join(" ", data) + "\n"); // Display array
    }
    
    // Calls recursive SortArray method to begin merge sorting
    public static void MergeSort(int[] values)
    {
        SortArray(values, 0, values.Length - 1); // Sort entire array
    }
    
    // Splits the array, sorts subarrays and merges into sorted array
    private static void SortArray(int[] values, int low, int high)
    {
        // test base case; size of array equals 1
        if ((high - low) >= 1) // If not base case
        {
            int middle1 = (low + high) / 2; // Calculate the middle of the array
            int middle2 = middle1 + 1; // Calculate next element over
            
            // Output split step
            Console.WriteLine($"split:    {Subarray(values, low, high)}");
            Console.WriteLine($"          {Subarray(values, low, middle1)}");
            Console.WriteLine($"          {Subarray(values, middle2, high)}");
            Console.WriteLine();
            
            // Split array in half; sort each half (recursive calls)
            SortArray(values, low, middle1); // First half of array
            SortArray(values, middle2, high); // Second half of array
            
            // Merge two sorted array after split calls return
            Merge(values, low, middle1, middle2, high);
        }
    }
    
    // Merge two sorted sub-arrays into one sorted subarray
    private static void Merge(int[] values, int left, int middle1, int middle2, int right)
    {
        int leftIndex = left; // Index into left subarray
        int rightIndex = middle2; // Index into right subarray
        int combinedIndex = left; // Index into temporary working array
        int[] combined = new int[values.Length]; // Working array
        
        // Output two sub-arrays before merging
        Console.WriteLine($"merge:  {Subarray(values, left, middle1)}");
        Console.WriteLine($"        {Subarray(values, middle2, right)}");
        
        // Merge arrays until reaching end of either
        while (leftIndex <= middle1 && rightIndex <= right)
        {
            // Place smaller of two current elements into result
            // and move to next space in arrays
            if (values[leftIndex] <= values[rightIndex])
            {
                combined[combinedIndex++] = values[leftIndex++];
            }
            else
            {
                combined[combinedIndex++] = values[rightIndex++];
            }
        }
        
        // If left array is empty
        if (leftIndex == middle2)
        {
            // Copy in rest of right array
            while (rightIndex <= right)
            {
                combined[combinedIndex++] = values[rightIndex++];
            }
        }
        else // right array is empty
        {
            // Copy in rest of left array
            while (leftIndex <= middle1)
            {
                combined[combinedIndex++] = values[leftIndex++];
            }
        }
        
        // Copy values back into original array
        for (int i = left; i <= right; ++i)
        {
            values[i] = combined[i];
        }
        
        // Output merged array
        Console.WriteLine($"        {Subarray(values, left, right)}");
    }
    
    // Method to output certain values in array
    public static string Subarray(int[] values, int low, int high)
    {
        string temporary = string.Empty.PadLeft(low * 3);
        
        // Output elements left in array
        for (int i = low; i <= high; ++i)
        {
            temporary += $" {values[i]}";
        }

        return temporary;
    }
}