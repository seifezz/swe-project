using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace flight_project
{
    public partial class signinform : Form
    {
        
        public signinform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txt_email.ToString();
            string password = txt_pass.ToString();

            Auth login = new Auth();
            bool logged = login.LogIn(email , password);
            if (logged)
            {
                //if ()
                //{
                //    if admin go to admin
                //}
                //else
                //{
                //    // go to user
                //}

            }
            else
            {
                 // again tani log in 
            }
        }

        private void nav_signup_Click(object sender, EventArgs e)
        {
            // go to the sign up 
        }
    }
}
