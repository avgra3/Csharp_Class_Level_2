//
// Antony Gradillas 10/28/2023
// CIS262AD - Fall 2023
// Class 15677
//
// Fig. 15.7: MenuTestForm.cs
// Using Menus to change font colors and styles.
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MenuTest
{
   // our Form contains a Menu that changes the font color
   // and style of the text displayed in Label
   public partial class MenuTestForm : Form
   {
      // constructor
      public MenuTestForm()
      {
         InitializeComponent();
      }

        private void beverageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Values with corresponding prices
            Dictionary<string, double> beveragePrices = new Dictionary<string, double>();
            beveragePrices.Add("Soda", 1.95);
            beveragePrices.Add("Tea", 1.50);
            beveragePrices.Add("Coffee", 1.25);
            beveragePrices.Add("Mineral Water", 2.95);
            beveragePrices.Add("Juice", 2.50);
            beveragePrices.Add("Milk", 1.50);

            // Get price of the beverage
            string selectedBeverage = beverageComboBox.Text.ToString();
            double beveragePrice = beveragePrices[selectedBeverage];

            // Update Subtotal value
            subtotalTextBox.Text = $"{(double.Parse(subtotalTextBox.Text.ToString().Replace("$", "")) + beveragePrice):C2}";
        }

        private void appetizerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Values with corresponding prices
            Dictionary<string, double> appetizerPrices = new Dictionary<string, double>();
            appetizerPrices.Add("Buffalo Wings", 5.95);
            appetizerPrices.Add("Buffalo Fingers", 6.95);
            appetizerPrices.Add("Potato Skins", 8.95);
            appetizerPrices.Add("Nachos", 8.95);
            appetizerPrices.Add("Mushroom Caps", 10.95);
            appetizerPrices.Add("Shrimp Cocktail", 12.95);
            appetizerPrices.Add("Chips and Salsa", 6.95);

            // Get price of the appetizers
            string selectedAppetizer = appetizerComboBox.Text.ToString();
            double appetizerPrice = appetizerPrices[selectedAppetizer];

            // Update Subtotal value
            subtotalTextBox.Text = $"{(double.Parse(subtotalTextBox.Text.ToString().Replace("$", "")) + appetizerPrice):C2}";
        }

        private void mainCourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Values with corresponding prices
            Dictionary<string, double> mainCoursePrices = new Dictionary<string, double>();
            mainCoursePrices.Add("Seafood Alfredo", 15.95);
            mainCoursePrices.Add("Chicken Alfredo", 13.95);
            mainCoursePrices.Add("Chicken Picatta", 13.95);
            mainCoursePrices.Add("Turkey Club", 11.95);
            mainCoursePrices.Add("Lobster Pie", 19.95);
            mainCoursePrices.Add("Prime Rib", 20.95);
            mainCoursePrices.Add("Shrimp Scampi", 18.95);
            mainCoursePrices.Add("Turkey Dinner", 13.95);
            mainCoursePrices.Add("Stuffed Chicken", 14.95);

            // Get price of the appetizers
            string selectedMainCourse = mainCourseComboBox.Text.ToString();
            double mainCoursePrice = mainCoursePrices[selectedMainCourse];

            // Update Subtotal value
            subtotalTextBox.Text = $"{(double.Parse(subtotalTextBox.Text.ToString().Replace("$", "")) + mainCoursePrice):C2}";
        }

        private void dessertComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Values with corresponding prices
            Dictionary<string, double> dessertPrices = new Dictionary<string, double>();
            dessertPrices.Add("Apple Pie", 5.95);
            dessertPrices.Add("Sundae", 3.95);
            dessertPrices.Add("Carrot Cake", 5.95);
            dessertPrices.Add("Mud Pie", 4.95);
            dessertPrices.Add("Apple Crisp", 5.95);

            // Get price of the appetizers
            string selectedDessert = dessertComboBox.Text.ToString();
            double dessertPrice = dessertPrices[selectedDessert];

            // Update Subtotal value
            subtotalTextBox.Text = $"{(double.Parse(subtotalTextBox.Text.ToString().Replace("$", "")) + dessertPrice):C2}";
        }

        private void subtotalTextBox_TextChanged(object sender, EventArgs e)
        {
            double taxRate = (8 / 100.0);
            taxTextBox.Text = $"{(double.Parse(subtotalTextBox.Text.ToString().Replace("$", "")) * taxRate):C2}";
            totalTextBox.Text = $"{(double.Parse(subtotalTextBox.Text.ToString().Replace("$", "")) + double.Parse(taxTextBox.Text.ToString().Replace("$", ""))):C2}";
        }

        private void clearBillbutton_Click(object sender, EventArgs e)
        {
            subtotalTextBox.Text = $"{0:C2}";
        }
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
