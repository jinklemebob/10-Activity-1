using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity10
{
    public partial class Form1 : Form
    {
        string connectionstring = "Data Source=ANNEX-PC00;Initial Catalog=dbdemo;Persist Security Info=True;User ID=Guantero.290593;Encrypt=True;Trust Server Certificate=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user1 = new User(idbox.Text, passwordbox.Text);
            user1.verifyLogin(idcomp.Text,passcomp.Text );
            adminname.Text = namebox.Text;
            adminname.Visible = true;
        }

        private void createaccbtn_Click(object sender, EventArgs e)
        {
            User user1 = new User(idbox.Text, passwordbox.Text);
            Administrator administrator = new Administrator(idbox.Text, passwordbox.Text, namebox.Text);
            MessageBox.Show("Process successful");
        }

        private void Admin_CheckedChanged(object sender, EventArgs e)
        {
            namebox.Visible = true;
            Username.Visible = true;
        }

        private void User_CheckedChanged(object sender, EventArgs e)
        {
            namebox.Visible = false;
            Username.Visible = false;
            adminname.Visible = false;

        }

        private void adminname_Click(object sender, EventArgs e)
        {

        }
    }
}
