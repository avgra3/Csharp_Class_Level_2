using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayQueryResult
{
    public partial class TitleQueries : Form
    {
        public TitleQueries()
        {
            InitializeComponent();
        }

        // Entity Framework DbContext
        private BookExamples.BooksEntities dbcontext = new BookExamples.BooksEntities();

        // Load data from database into DataGridView
        private void TitleQueries_Load(object sender, EventArgs e)
        {
            dbcontext.Titles.Load(); // Load Titles table into memory

            // Set the ComboBox to show the default query that
            // selects all books from the Titles table
            queriesComboBox.SelectedIndex = 0;
        }

        // Loads data into titleBindingSource based on user-selected query
        private void queriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set the data displayed according to what is selected
            switch (queriesComboBox.SelectedIndex)
            {
                case 0: // All titles
                    // Use LINQ to order the books by title
                    titleBindingSource.DataSource = dbcontext.Titles.Local.OrderBy(book => book.Title1);
                break;

                case 1: // Titles with 2016 copyright
                    // Use LINQ to get titles with 2016
                    // copyright and sort them by title
                    titleBindingSource.DataSource = dbcontext.Titles.Local.Where(book => book.Copyright == "2016").OrderBy(book => book.Title1);
                break;

                case 2: // Titles ending with "How to Program"
                    // Use LINQ to get titles ending with
                    // "How to Program" and sort them by title
                    titleBindingSource.DataSource = dbcontext.Titles.Local.Where(book => book.Title1.EndsWith("How to Program")).OrderBy(book => book.Title1);
                break;
            }

            titleBindingSource.MoveFirst(); // Move to first entry.
        }
    }
}
