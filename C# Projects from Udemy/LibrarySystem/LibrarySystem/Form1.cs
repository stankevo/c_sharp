using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            
            // TODO: This line of code loads data into the 'libraryDBDataSet.CustomerTBL' table. You can move, or remove it, as needed.
            this.customerTBLTableAdapter.Fill(this.libraryDBDataSet.CustomerTBL);

        }
    }
}
