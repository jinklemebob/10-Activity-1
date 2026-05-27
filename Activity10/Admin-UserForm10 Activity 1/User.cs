using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity10
{
    internal class User
    {

        protected string user_password;
        public string user_id {get; set; }
        
         
        public User(string id, string pass)
        {
            this.user_id = id;
            this.user_password = pass;
        }
        public bool verifyLogin(string userid, string password) {


            if (String.Equals(userid, user_id) && String.Equals(password, user_password))
            {
                MessageBox.Show("Login successful!");
                return true;
            }
            else
            {
                MessageBox.Show("Invalid credentials");
                return false;
            }

           

        }
        public virtual void updatepassword(string newpassword)
        {

        }



    }
}
