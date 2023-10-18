//
// Antony Gradillas 10/17/2023
// CIS262AD - Fall 2023
// Class 15677
//
// Exercise 18.5 Solution: BubbleSortTest.cs
// Test the bubble sort class.
using System;

public class BubbleSortTest
{
   public static void Main()
   {
      Random generator = new Random();
      int[] data = new int[10]; // create space for array

      // fill array with random ints in range 10-99
      for (int i = 0; i < data.Length; i++)
      {
         data[i] = generator.Next(10, 100);
      }

      Console.Write("Before: ");
      DisplayArray(data); // display unsorted array

      BubbleSort(data); // sort array

      Console.Write("After: ");
      DisplayArray(data); // display sorted array

        // End Lines
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }

   // sort elements of array with bubble sort                
   public static void BubbleSort(int[] data)
   {
      // loop for SOMETHINGOESHERE - 1 passes
      for (int pass = 1; pass < data.Length; pass++)
      {
         // loop over elements in array
         for (int index = 0; index < data.Length - 1; index++)
         {
            // swap adjacent elements if first is greater than second
            if (data[index] > data[index + 1])
            {
               Swap(ref data[index], ref data[index + 1]); // swap adjacent elements
            }
         }
      }
   }

   // helper method to swap values in two elements
   public static void Swap(ref int first, ref int second)
   {
      var temporary = first; // store first in temporary  
      first = second; // replace first with second
      second = temporary; // put temporary in second      
   }

   // method to output values in array
   private static void DisplayArray(int[] data)
   {
      // iterate through array
      foreach (var element in data)
      {
         Console.Write($"{element} ");
      }

      Console.WriteLine();
   }
} 


/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/