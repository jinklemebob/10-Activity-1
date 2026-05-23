using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _10_Activity_1
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        public abstract class User : Form1
        {
            String connectionString = "Data Source=ANNEX-PC00;Initial Catalog=TestDB;Persist Security Info=True;User ID=guantero.290593;Trust Server Certificate=True";
            private String user_id;
            protected String user_password;
            public int isExisting;

            public User(String id, String pass)
            {
                this.user_id = id;
                this.user_password = pass;
            }
            public Boolean verifyLogin(String id, String pass)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    String query = @"SELECT COUNT(*) FROM Users WHERE UserID = @UserID AND Password = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@UserID", id);
                        cmd.Parameters.AddWithValue("@Password", pass);
                        this.isExisting = Convert.ToInt32(cmd.ExecuteScalar());
                       
                        
                    }
                    conn.Close();

                }
                if (isExisting == 1)
                {
                    return true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
