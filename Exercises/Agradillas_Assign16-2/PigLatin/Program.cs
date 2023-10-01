//
// Antony Gradillas 10/01/2023
// CIS262AD - Fall 2023
// Class 15677
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
   static void Main(string[] args)
   {
      Console.WriteLine("Please enter a sentence");
      string sentence = Console.ReadLine();

      // split the sentence into individual words
      char[] separator = {' '};
      string[] words = sentence.Split(separator);
      string pigLatin = string.Empty;

      // translate each word into pig latin
      foreach (var word in words)
      {
         pigLatin += GetPigLatin(word) + " ";
      }

      // display the translation
      Console.WriteLine($"\nThe Pig Latin sentence is:\n{pigLatin}");

        // Pause logic
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
   }

   // translate the word
   private static string GetPigLatin(string word)
   {
      StringBuilder latin = new StringBuilder(word);
      char firstLetter = latin[0];

        // this code removes the first letter and appends it to the end
        //
        // add the code below this comment line to remove the first letter
        latin.Remove(0, 1);

	  // leave this line intact to append the first letter
      latin.Append(firstLetter);

        //
        // add the code below this comment line to add "ay" to the end of the word
        latin.Append("ay");

        return latin.ToString();
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

