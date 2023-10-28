//
// Antony Gradillas 10/28/2023
// CIS262AD - Fall 2023
// Class 15677
//
namespace MenuTest
{
   partial class MenuTestForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose( bool disposing )
      {
         if ( disposing && ( components != null ) )
         {
            components.Dispose();
         }
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
            this.RestaurantLabel = new System.Windows.Forms.Label();
            this.waiterInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.waitersNameTextBox = new System.Windows.Forms.TextBox();
            this.tableNumberTextBox = new System.Windows.Forms.TextBox();
            this.waiterNameLabel = new System.Windows.Forms.Label();
            this.tableNumberlabel = new System.Windows.Forms.Label();
            this.menuitemsBox1 = new System.Windows.Forms.GroupBox();
            this.dessertComboBox = new System.Windows.Forms.ComboBox();
            this.mainCourseComboBox = new System.Windows.Forms.ComboBox();
            this.appetizerComboBox = new System.Windows.Forms.ComboBox();
            this.beverageComboBox = new System.Windows.Forms.ComboBox();
            this.dessertLabel = new System.Windows.Forms.Label();
            this.mainCourseLabel = new System.Windows.Forms.Label();
            this.beverageLabel = new System.Windows.Forms.Label();
            this.appetizerLabel = new System.Windows.Forms.Label();
            this.clearBillbutton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subtotalTextBox = new System.Windows.Forms.TextBox();
            this.taxTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.waiterInformationGroupBox.SuspendLayout();
            this.menuitemsBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RestaurantLabel
            // 
            this.RestaurantLabel.AutoSize = true;
            this.RestaurantLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantLabel.Location = new System.Drawing.Point(128, 9);
            this.RestaurantLabel.Name = "RestaurantLabel";
            this.RestaurantLabel.Size = new System.Drawing.Size(108, 25);
            this.RestaurantLabel.TabIndex = 0;
            this.RestaurantLabel.Text = "Restaurant";
            // 
            // waiterInformationGroupBox
            // 
            this.waiterInformationGroupBox.Controls.Add(this.waitersNameTextBox);
            this.waiterInformationGroupBox.Controls.Add(this.tableNumberTextBox);
            this.waiterInformationGroupBox.Controls.Add(this.waiterNameLabel);
            this.waiterInformationGroupBox.Controls.Add(this.tableNumberlabel);
            this.waiterInformationGroupBox.Location = new System.Drawing.Point(46, 59);
            this.waiterInformationGroupBox.Name = "waiterInformationGroupBox";
            this.waiterInformationGroupBox.Size = new System.Drawing.Size(304, 72);
            this.waiterInformationGroupBox.TabIndex = 1;
            this.waiterInformationGroupBox.TabStop = false;
            this.waiterInformationGroupBox.Text = "Waiter Information";
            // 
            // waitersNameTextBox
            // 
            this.waitersNameTextBox.Location = new System.Drawing.Point(175, 40);
            this.waitersNameTextBox.Name = "waitersNameTextBox";
            this.waitersNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.waitersNameTextBox.TabIndex = 12;
            // 
            // tableNumberTextBox
            // 
            this.tableNumberTextBox.Location = new System.Drawing.Point(220, 16);
            this.tableNumberTextBox.Name = "tableNumberTextBox";
            this.tableNumberTextBox.Size = new System.Drawing.Size(55, 23);
            this.tableNumberTextBox.TabIndex = 10;
            // 
            // waiterNameLabel
            // 
            this.waiterNameLabel.AutoSize = true;
            this.waiterNameLabel.Location = new System.Drawing.Point(17, 43);
            this.waiterNameLabel.Name = "waiterNameLabel";
            this.waiterNameLabel.Size = new System.Drawing.Size(84, 15);
            this.waiterNameLabel.TabIndex = 11;
            this.waiterNameLabel.Text = "Waiter\'s Name";
            // 
            // tableNumberlabel
            // 
            this.tableNumberlabel.AutoSize = true;
            this.tableNumberlabel.Location = new System.Drawing.Point(17, 19);
            this.tableNumberlabel.Name = "tableNumberlabel";
            this.tableNumberlabel.Size = new System.Drawing.Size(84, 15);
            this.tableNumberlabel.TabIndex = 10;
            this.tableNumberlabel.Text = "Table Number:";
            // 
            // menuitemsBox1
            // 
            this.menuitemsBox1.Controls.Add(this.dessertComboBox);
            this.menuitemsBox1.Controls.Add(this.mainCourseComboBox);
            this.menuitemsBox1.Controls.Add(this.appetizerComboBox);
            this.menuitemsBox1.Controls.Add(this.beverageComboBox);
            this.menuitemsBox1.Controls.Add(this.dessertLabel);
            this.menuitemsBox1.Controls.Add(this.mainCourseLabel);
            this.menuitemsBox1.Controls.Add(this.beverageLabel);
            this.menuitemsBox1.Controls.Add(this.appetizerLabel);
            this.menuitemsBox1.Location = new System.Drawing.Point(46, 137);
            this.menuitemsBox1.Name = "menuitemsBox1";
            this.menuitemsBox1.Size = new System.Drawing.Size(304, 121);
            this.menuitemsBox1.TabIndex = 2;
            this.menuitemsBox1.TabStop = false;
            this.menuitemsBox1.Text = "Menu Items";
            // 
            // dessertComboBox
            // 
            this.dessertComboBox.FormattingEnabled = true;
            this.dessertComboBox.Items.AddRange(new object[] {
            "Apple Pie",
            "Sundae",
            "Carrot Cake",
            "Mud Pie",
            "Apple Crisp"});
            this.dessertComboBox.Location = new System.Drawing.Point(120, 91);
            this.dessertComboBox.Name = "dessertComboBox";
            this.dessertComboBox.Size = new System.Drawing.Size(121, 23);
            this.dessertComboBox.TabIndex = 18;
            this.dessertComboBox.SelectedIndexChanged += new System.EventHandler(this.dessertComboBox_SelectedIndexChanged);
            // 
            // mainCourseComboBox
            // 
            this.mainCourseComboBox.FormattingEnabled = true;
            this.mainCourseComboBox.Items.AddRange(new object[] {
            "Seafood Alfredo",
            "Chicken Alfredo",
            "Chicken Picatta",
            "Turkey Club",
            "Lobster Pie",
            "Prime Rib",
            "Shrimp Scampi",
            "Turkey Dinner",
            "Stuffed Chicken"});
            this.mainCourseComboBox.Location = new System.Drawing.Point(120, 67);
            this.mainCourseComboBox.Name = "mainCourseComboBox";
            this.mainCourseComboBox.Size = new System.Drawing.Size(121, 23);
            this.mainCourseComboBox.TabIndex = 17;
            this.mainCourseComboBox.SelectedIndexChanged += new System.EventHandler(this.mainCourseComboBox_SelectedIndexChanged);
            // 
            // appetizerComboBox
            // 
            this.appetizerComboBox.FormattingEnabled = true;
            this.appetizerComboBox.Items.AddRange(new object[] {
            "Buffalo Wings",
            "Buffalo Fingers",
            "Potato Skins",
            "Nachos",
            "Mushroom Caps",
            "Shrimp Cocktail",
            "Chips and Salsa"});
            this.appetizerComboBox.Location = new System.Drawing.Point(120, 41);
            this.appetizerComboBox.Name = "appetizerComboBox";
            this.appetizerComboBox.Size = new System.Drawing.Size(121, 23);
            this.appetizerComboBox.TabIndex = 16;
            this.appetizerComboBox.SelectedIndexChanged += new System.EventHandler(this.appetizerComboBox_SelectedIndexChanged);
            // 
            // beverageComboBox
            // 
            this.beverageComboBox.FormattingEnabled = true;
            this.beverageComboBox.Items.AddRange(new object[] {
            "Soda",
            "Tea",
            "Coffee",
            "Mineral Water",
            "Juice",
            "Milk"});
            this.beverageComboBox.Location = new System.Drawing.Point(120, 16);
            this.beverageComboBox.Name = "beverageComboBox";
            this.beverageComboBox.Size = new System.Drawing.Size(121, 23);
            this.beverageComboBox.TabIndex = 15;
            this.beverageComboBox.SelectedIndexChanged += new System.EventHandler(this.beverageComboBox_SelectedIndexChanged);
            // 
            // dessertLabel
            // 
            this.dessertLabel.AutoSize = true;
            this.dessertLabel.Location = new System.Drawing.Point(17, 94);
            this.dessertLabel.Name = "dessertLabel";
            this.dessertLabel.Size = new System.Drawing.Size(48, 15);
            this.dessertLabel.TabIndex = 14;
            this.dessertLabel.Text = "Dessert:";
            // 
            // mainCourseLabel
            // 
            this.mainCourseLabel.AutoSize = true;
            this.mainCourseLabel.Location = new System.Drawing.Point(17, 70);
            this.mainCourseLabel.Name = "mainCourseLabel";
            this.mainCourseLabel.Size = new System.Drawing.Size(77, 15);
            this.mainCourseLabel.TabIndex = 13;
            this.mainCourseLabel.Text = "Main Course:";
            // 
            // beverageLabel
            // 
            this.beverageLabel.AutoSize = true;
            this.beverageLabel.Location = new System.Drawing.Point(17, 19);
            this.beverageLabel.Name = "beverageLabel";
            this.beverageLabel.Size = new System.Drawing.Size(58, 15);
            this.beverageLabel.TabIndex = 12;
            this.beverageLabel.Text = "Beverage:";
            // 
            // appetizerLabel
            // 
            this.appetizerLabel.AutoSize = true;
            this.appetizerLabel.Location = new System.Drawing.Point(17, 44);
            this.appetizerLabel.Name = "appetizerLabel";
            this.appetizerLabel.Size = new System.Drawing.Size(60, 15);
            this.appetizerLabel.TabIndex = 11;
            this.appetizerLabel.Text = "Appetizer:";
            // 
            // clearBillbutton
            // 
            this.clearBillbutton.Location = new System.Drawing.Point(133, 264);
            this.clearBillbutton.Name = "clearBillbutton";
            this.clearBillbutton.Size = new System.Drawing.Size(103, 23);
            this.clearBillbutton.TabIndex = 3;
            this.clearBillbutton.Text = "Clear Bill";
            this.clearBillbutton.UseVisualStyleBackColor = true;
            this.clearBillbutton.Click += new System.EventHandler(this.clearBillbutton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(74, 301);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(54, 15);
            this.subtotalLabel.TabIndex = 4;
            this.subtotalLabel.Text = "Subtotal:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(74, 330);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(27, 15);
            this.taxLabel.TabIndex = 5;
            this.taxLabel.Text = "Tax:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(74, 359);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(35, 15);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "Total:";
            // 
            // subtotalTextBox
            // 
            this.subtotalTextBox.Location = new System.Drawing.Point(187, 293);
            this.subtotalTextBox.Name = "subtotalTextBox";
            this.subtotalTextBox.ReadOnly = true;
            this.subtotalTextBox.Size = new System.Drawing.Size(100, 23);
            this.subtotalTextBox.TabIndex = 7;
            this.subtotalTextBox.Text = "$0.00";
            this.subtotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.subtotalTextBox.TextChanged += new System.EventHandler(this.subtotalTextBox_TextChanged);
            // 
            // taxTextBox
            // 
            this.taxTextBox.Location = new System.Drawing.Point(187, 322);
            this.taxTextBox.Name = "taxTextBox";
            this.taxTextBox.ReadOnly = true;
            this.taxTextBox.Size = new System.Drawing.Size(100, 23);
            this.taxTextBox.TabIndex = 8;
            this.taxTextBox.Text = "$0.00";
            this.taxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(187, 351);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(100, 23);
            this.totalTextBox.TabIndex = 9;
            this.totalTextBox.Text = "$0.00";
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MenuTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 393);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.taxTextBox);
            this.Controls.Add(this.subtotalTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.clearBillbutton);
            this.Controls.Add(this.menuitemsBox1);
            this.Controls.Add(this.waiterInformationGroupBox);
            this.Controls.Add(this.RestaurantLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MenuTestForm";
            this.Text = "Restaurant Bill Calculator";
            this.waiterInformationGroupBox.ResumeLayout(false);
            this.waiterInformationGroupBox.PerformLayout();
            this.menuitemsBox1.ResumeLayout(false);
            this.menuitemsBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

        #endregion

        private System.Windows.Forms.Label RestaurantLabel;
        private System.Windows.Forms.GroupBox waiterInformationGroupBox;
        private System.Windows.Forms.GroupBox menuitemsBox1;
        private System.Windows.Forms.Button clearBillbutton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox subtotalTextBox;
        private System.Windows.Forms.TextBox taxTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label waiterNameLabel;
        private System.Windows.Forms.Label tableNumberlabel;
        private System.Windows.Forms.Label dessertLabel;
        private System.Windows.Forms.Label mainCourseLabel;
        private System.Windows.Forms.Label beverageLabel;
        private System.Windows.Forms.Label appetizerLabel;
        private System.Windows.Forms.ComboBox dessertComboBox;
        private System.Windows.Forms.ComboBox mainCourseComboBox;
        private System.Windows.Forms.ComboBox appetizerComboBox;
        private System.Windows.Forms.ComboBox beverageComboBox;
        private System.Windows.Forms.TextBox waitersNameTextBox;
        private System.Windows.Forms.TextBox tableNumberTextBox;
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
