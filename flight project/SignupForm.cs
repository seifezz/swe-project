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

namespace flight_project
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            string userName = txt_name.Text.ToString();
            string userEmail = txt_email.Text.ToString();
            string userPassword = txt_password.Text.ToString();
            string userBirthDate = date.Value.ToString();
            string userNatId = txt_natid.Text.ToString();
            string userPhone = txt_phone.Text.ToString();



            User myUser = new User(userEmail, userName, userPhone, userNatId, userBirthDate, userPassword);

            Auth auth = new Auth();
            int signUpResult = auth.SignUp(myUser);



            if (signUpResult == 0)
            {
                MessageBox.Show("You signed up successfully");
                signinform signinform = new signinform();
                signinform.Show();
                this.Hide();
            }
            else
            {
                if (signUpResult == 1)
                {
                    MessageBox.Show("You are not signed up, Your email is not valid");
                }
                else if (signUpResult == 2)
                {
                    MessageBox.Show("You are not signed up, You are using week password");

                }
                else if (signUpResult == 3)
                {
                    MessageBox.Show("You are not signed up, Please Fill All Values");

                }
                else if (signUpResult == 4)
                {
                    MessageBox.Show("You are not signed up, You are under 18");

                }
                else
                {
                    MessageBox.Show("You are not signed up, Error occured");

                }


            }

        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }

        private void SignupForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void nav_signup_Click(object sender, EventArgs e)
        {
            signinform form = new signinform();
            form.Show();
            this.Hide();
        }
    }
}
