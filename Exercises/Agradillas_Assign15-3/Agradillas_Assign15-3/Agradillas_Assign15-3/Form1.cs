//
// Antony Gradillas 09/24/2023
// CIS262AD - Fall 2023
// Class 15677
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agradillas_Assign15_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void statesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if item is seleceted
            if (statesComboBox.SelectedIndex != -1)
            {
                // Remove from combo-box
                statesComboBox.Items.RemoveAt(statesComboBox.SelectedIndex);
            }
        }
    }
}
