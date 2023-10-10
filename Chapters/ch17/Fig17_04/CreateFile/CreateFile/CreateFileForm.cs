//
// Antony Gradillas 10/10/2023
// CIS262AD - Fall 2023
// Class 15677
//
namespace CreateFile
{
    partial class CreateFileForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Size = new System.Drawing.Size(153, 23);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(150, 151);
            this.lastNameTextBox.Size = new System.Drawing.Size(153, 23);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Size = new System.Drawing.Size(153, 23);
            // 
            // accountTextBox
            // 
            this.accountTextBox.Size = new System.Drawing.Size(153, 23);
            // 
            // label4
            // 
            this.label4.Size = new System.Drawing.Size(48, 15);
            // 
            // label3
            // 
            this.label3.Size = new System.Drawing.Size(63, 15);
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(64, 15);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(52, 15);
            // 
            // label5
            // 
            this.label5.Size = new System.Drawing.Size(79, 15);
            // 
            // middleNameTextBox
            // 
            // this.middleNameTextBox.Size = new System.Drawing.Size(153, 23);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(228, 234);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(86, 31);
            this.exitButton.TabIndex = 18;
            this.exitButton.Text = "Exit";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.Enabled = false;
            this.enterButton.Location = new System.Drawing.Point(132, 234);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(86, 31);
            this.enterButton.TabIndex = 17;
            this.enterButton.Text = "Enter";
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(33, 234);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(86, 31);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save As";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton2
            // 
            this.exitButton2.Location = new System.Drawing.Point(228, 271);
            this.exitButton2.Name = "exitButton2";
            this.exitButton2.Size = new System.Drawing.Size(86, 31);
            this.exitButton2.TabIndex = 19;
            this.exitButton2.Text = "Exit2";
            this.exitButton2.UseVisualStyleBackColor = true;
            this.exitButton2.Click += new System.EventHandler(this.exitButton2_Click);
            // 
            // CreateFileForm
            // 
            this.ClientSize = new System.Drawing.Size(354, 351);
            this.Controls.Add(this.exitButton2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.saveButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CreateFileForm";
            this.Text = "Creating a Sequential File";
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.middleNameTextBox, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.accountTextBox, 0);
            this.Controls.SetChildIndex(this.firstNameTextBox, 0);
            this.Controls.SetChildIndex(this.lastNameTextBox, 0);
            this.Controls.SetChildIndex(this.balanceTextBox, 0);
            this.Controls.SetChildIndex(this.saveButton, 0);
            this.Controls.SetChildIndex(this.enterButton, 0);
            this.Controls.SetChildIndex(this.exitButton, 0);
            this.Controls.SetChildIndex(this.exitButton2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exitButton2;
    }
}