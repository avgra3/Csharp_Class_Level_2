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

namespace JoinQueries
{
    public partial class JoiningTableData : Form
    {
        public JoiningTableData()
        {
            InitializeComponent();
        }

        private void JoiningTablesData_Load(object sender, EventArgs e)
        {
            // Entity Framework DbContext
            var dbcontext = new BookExamples.BooksEntities();

            // get authors and ISBNS of eah book they co-authored
            var authorsAndISBNs =
                from author in dbcontext.Authors
                from book in author.Titles
                orderby author.LastName, author.FirstName
                select new { author.FirstName, author.LastName, book.ISBN };

            outputTextBox.AppendText("Authors and ISBNs:");

            foreach (var element in authorsAndISBNs)
            {
                outputTextBox.AppendText($"\r\n\t{element.FirstName,-10} {element.LastName,-10} {element.ISBN,-10}");

            }

            // Get authors and titles of each book
            // they co-authored; group by author
            var titlesByAuthor =
                from author in dbcontext.Authors
                orderby author.LastName, author.FirstName
                select new { Name = author.FirstName + " " + author.LastName,
                Titles =
                    from book in author.Titles
                    orderby book.Title1
                    select book.Title1};

            outputTextBox.AppendText($"\r\n\r\nTitles grouped by author:");

            // Display titles written by each author, grouped by author
            foreach (var author in titlesByAuthor)
            {
                // Display author's name
                outputTextBox.AppendText($"\r\n\t{author.Name}");

                // Display titles written by that author
                foreach (var title in author.Titles)
                {
                    outputTextBox.AppendText($"\r\n\t\t{title}");
                }
            }
        }


    }
}
