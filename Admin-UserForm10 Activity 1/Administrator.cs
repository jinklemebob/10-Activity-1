using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity10
{
    internal class Administrator : User
    {
        private string admin_name;
        public string Admin_name
        {
            get { return admin_name; }
            set { admin_name = value; }
        }
        public Administrator(string name, string id, string pass) : base(id, pass)
        {
            this.admin_name = name;
            this.user_id = id;
            this.user_password = pass;

        }
        public override void updatepassword(string password)
        {
            this.user_password = password;
        }
        public string updateAdminName(string name)
        {
            return Admin_name = name;
        }

    }
}
