using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace flight_project
{
    public partial class updatecardinfo : Form
    {
        public updatecardinfo()
        {
            InitializeComponent();
        }

        private void updatecardinfo_Load(object sender, EventArgs e)
        {

            UserModel func = new UserModel();
            cards ReturnData = func.getCardInfoByemail(Program.globaleEmail);
            if (ReturnData != null)
            {
                cardNumTextBox.Text = ReturnData.cardId.ToString();
                clientNameTextBox.Text = ReturnData.clientName.ToString();
                DateTime dateValue = DateTime.Parse(ReturnData.expirydate);
                date.Value = dateValue;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            bool updated = false;
            UserModel.dataToBeUpdated.cardInfo cardInfo = new UserModel.dataToBeUpdated.cardInfo();
            UserModel func = new UserModel();

            cardInfo.cardId = Convert.ToInt32(cardNumTextBox.Text);
            cardInfo.clientName = clientNameTextBox.Text;
            cardInfo.expiredate = date.Value.ToString();

            updated = func.updatecardinfo(Program.globaleEmail, cardInfo);

            if (updated)
            {
                MessageBox.Show("updated successfly");
            }
            else
            {
                MessageBox.Show("please try again ");
            }
        }



        private void updatecardinfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
