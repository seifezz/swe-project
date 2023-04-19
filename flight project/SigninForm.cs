using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            string email = txt_email.Text.ToString();
            string password = txt_pass.Text.ToString();
            string admincheck = "@admin.com";
            bool x = false;

            Auth login = new Auth();
            bool logged = login.LogIn(email, password);
            if (logged)
            {
                int index = email.IndexOf("@");
                string h = email.Substring(index);
                for (int i = 0; i < admincheck.Length; i++)
                {
                    if (h[i] == admincheck[i])
                    {
                        x = true;
                    }
                    else
                    {
                        x = false;
                        break;
                    }
                }

                if (x)
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    this.Hide();
                }
                else
                {
                    UserForm userForm = new UserForm();
                    userForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Wrong Email or Password");
            }
        }

        private void nav_signup_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.Show();
            this.Hide();
        }

        private void signinform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
