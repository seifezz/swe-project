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
            passwordTextBox.Text = user.password.ToString();
            PhonenumberTextBox.Text = user.phoneNumber.ToString();
            DateTime dateValue = DateTime.Parse(user.age);
            date.Value = dateValue;
            //card info section
            cards ReturnData = func.getCardInfoByemail(Program.globaleEmail);
            if (ReturnData != null)
            {
                availcredit = true;
                cardNumTextBox.Text = ReturnData.cardId.ToString();
                cardPassTextBox.Text = ReturnData.passNum.ToString();
                clientNameTextBox.Text = ReturnData.clientName.ToString();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            bool status = false;
            UserModel func = new UserModel();
            UserModel.dataToBeUpdated newData = new UserModel.dataToBeUpdated();
            UserModel.dataToBeUpdated.cardInfo cardInfo = new UserModel.dataToBeUpdated.cardInfo();
            //user info  section
            if (Validator.validateEmail(emailTextBox.Text.ToString()))
            { newData.email = emailTextBox.Text.ToString(); }
            else
            {
                MessageBox.Show("Not Valid Email");
                this.Refresh();

            }

            /*if (Convert.ToInt32(ageTextBox.Text.ToString()) > 18)
            {
                newData.age = ageTextBox.Text.ToString();
            }
            else
            {
                MessageBox.Show("Age must be over 18 ");
                this.Refresh();
            }*/
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
            if (availcredit)
            {
                // card info section
                cardInfo.cardId = Convert.ToInt32(cardNumTextBox.Text);
                cardInfo.clientName = clientNameTextBox.Text;
                cardInfo.passNum = Convert.ToInt32(cardPassTextBox.Text);
            }

            status = func.UpdateInfo(Program.globaleEmail, newData, cardInfo, availcredit);

            if (status)
            {
                MessageBox.Show(status.ToString());
            }
            else
                MessageBox.Show("false");
        }


        private void updateinfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

    }
}
