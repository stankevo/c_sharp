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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void button_log_in_Click(object sender, EventArgs e)
        {
            LibraryDBDataSetTableAdapters.CustomerTBLTableAdapter ada = new LibraryDBDataSetTableAdapters.CustomerTBLTableAdapter();

            DataTable dt = ada.GetDataBy(textBox_mail.Text, textBox_pwd.Text);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Log in successful.");
                this.Close();
            } else
            {
                MessageBox.Show("Access denied.");
            }
        }
    }
}
