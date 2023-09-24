//
// Antony Gradillas 09/24/2023
// CIS262AD - Fall 2023
// Class 15677
//
namespace Agradillas_Assign15_3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statesComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // statesComboBox
            // 
            this.statesComboBox.FormattingEnabled = true;
            this.statesComboBox.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa"});
            this.statesComboBox.Location = new System.Drawing.Point(150, 52);
            this.statesComboBox.MaxDropDownItems = 15;
            this.statesComboBox.Name = "statesComboBox";
            this.statesComboBox.Size = new System.Drawing.Size(121, 21);
            this.statesComboBox.TabIndex = 0;
            this.statesComboBox.SelectedIndexChanged += new System.EventHandler(this.statesComboBox_SelectedIndexChanged);
            this.statesComboBox.TextUpdate += new System.EventHandler(this.statesComboBox_SelectedIndexChanged);
            this.statesComboBox.Click += new System.EventHandler(this.statesComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 210);
            this.Controls.Add(this.statesComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.statesComboBox_SelectedIndexChanged);
            this.Enter += new System.EventHandler(this.statesComboBox_SelectedIndexChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox statesComboBox;
    }
}

