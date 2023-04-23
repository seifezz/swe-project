using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flight_project
{
    public partial class updateinfo : Form
    {
        public updateinfo()
        {
            InitializeComponent();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void UpdateInfo_Load(object sender, EventArgs e)
        {
            UserModel func = new UserModel();
            //user info section
            User user = func.getUserByEmail(Program.globaleEmail);
            nameTextBox.Text = user.name.ToString();
            emailTextBox.Text = user.email.ToString();
            passwordTextBox.Text = user.password.ToString();
            PhonenumberTextBox.Text = user.phoneNumber.ToString();
            ageTextBox.Text = user.age.ToString();
            //card info section
            cards ReturnData = func.getCardInfoByemail(Program.globaleEmail);
            cardNumTextBox.Text = ReturnData.cardId.ToString();
            cardPassTextBox.Text = ReturnData.passNum.ToString();
            clientNameTextBox.Text = ReturnData.clientName.ToString();


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool status = false;
            UserModel func = new UserModel();
            UserModel.dataToBeUpdated newData = new UserModel.dataToBeUpdated();
            UserModel.dataToBeUpdated.cardInfo cardInfo = new UserModel.dataToBeUpdated.cardInfo();
            //user info  section
            if (Validator.validateEmail(emailTextBox.Text))
            { newData.email = emailTextBox.Text; }
            else
            {
                MessageBox.Show("Not Valid Email");
                this.Refresh();

            }
            if (Convert.ToInt32(ageTextBox.Text) > 18)
            { newData.age = ageTextBox.Text; }
            else
            {
                MessageBox.Show("Age must be over 18 ");
                this.Refresh();
            }
            newData.name = nameTextBox.Text;
            newData.phoneNumber = PhonenumberTextBox.Text;
            // validating password
            if (Validator.validatePassowrd(passwordTextBox.Text))
            { newData.password = passwordTextBox.Text; }
            else
            {
                MessageBox.Show("Not Valid Password");
                this.Refresh();
            }

            // card info section
            cardInfo.cardId = Convert.ToInt32(cardNumTextBox.Text);
            cardInfo.clientName = clientNameTextBox.Text;
            cardInfo.passNum = Convert.ToInt32(cardPassTextBox.Text);

            status = func.UpdateInfo(Program.globaleEmail, newData, cardInfo);

            if (status)
            {
                MessageBox.Show(status.ToString());
            }
            else
                MessageBox.Show("false");



        }
    }
}
