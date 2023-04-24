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
    public partial class updateinfo : Form
    {
        bool availcredit = false;
        public updateinfo()
        {
            InitializeComponent();
        }

        private void updateinfo_Load(object sender, EventArgs e)
        {
            UserModel func = new UserModel();
            //user info section
            User user = func.getUserByEmail(Program.globaleEmail);
            nameTextBox.Text = user.name.ToString();
            emailTextBox.Text = user.email.ToString();
            //passwordTextBox.Text = user.password.ToString();
            PhonenumberTextBox.Text = user.phoneNumber.ToString();
            DateTime dateValue = DateTime.Parse(user.age);
            date.Value = dateValue;


           
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            bool status = false;
            UserModel func = new UserModel();
            UserModel.dataToBeUpdated newData = new UserModel.dataToBeUpdated();
            Auth ageauth = new Auth();
            //user info  section

            if (Validator.validateEmail(emailTextBox.Text.ToString()))
            { newData.email = emailTextBox.Text.ToString(); }
            else
            {
                MessageBox.Show("Not Valid Email");
                this.Refresh();

            }


            string updateuser = date.Value.ToString();
            if (ageauth.validage(updateuser))
            {
                newData.age = updateuser;
            }
            else
            {
                MessageBox.Show("Not valid age ");
            }

           
            newData.name = nameTextBox.Text.ToString();
            newData.phoneNumber = PhonenumberTextBox.Text.ToString();
            // validating password
       
            if (Validator.validatePassowrd(passwordTextBox.Text.ToString()))
            { newData.password = passwordTextBox.Text.ToString(); }
            else
            {
                MessageBox.Show("Not Valid Password");
                this.Refresh();
            }

            status = func.UpdateInfo(Program.globaleEmail, newData);

            if (status)
            {
                MessageBox.Show("data updated successfly");
            }
            else
                MessageBox.Show("can't update please try again ");
        }


        private void updateinfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void cardPassTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
