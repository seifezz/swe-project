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
    public partial class createcard : Form
    {
        public createcard()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserForm home = new UserForm();
            UserModel func = new UserModel();
            cards newCard = new cards(Convert.ToInt32(CardNumberTextBox.Text), Convert.ToInt32(cardPassTextBox.Text), CardNameTextBox.Text);
            bool isAdded = func.createCardInfo(newCard, Program.globaleEmail);
            if (isAdded)
            {
                MessageBox.Show("successfully added...!");
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed to Add !");
                this.Refresh();
            }
        }

        private void createCard_Load(object sender, EventArgs e)
        {
            cardPassTextBox.Text = "enter your Password...";
            CardNameTextBox.Text = "enter Card holder Name...";
            CardNumberTextBox.Text = "enter Card number";
        }
    }
}
