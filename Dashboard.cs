using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Library_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Are you sure you want to Exit?","Confirm",MessageBoxButtons.YesNo ,MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    Application.Exit();
                }  
            
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_book abs = new Add_book();
            abs.Show();
        }

        private void viewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook vb = new ViewBook();
            vb.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Add Student
            Form1 ast = new Form1();  
            ast.Show();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBook IB = new IssueBook();
            IB.Show();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBook IB = new IssueBook();
            IB.Show();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReturnBook rb = new ReturnBook();
            rb.Show();
        }

        private void completeBooksDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Complete_Book_Details cbd = new Complete_Book_Details();
            cbd.Show();
             
        }
    }
}
