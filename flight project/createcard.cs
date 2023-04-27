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
    public partial class createcard : Form
    {
        public createcard()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void createCard_Load(object sender, EventArgs e)
        {
            CardNameTextBox.Text = "enter Card holder Name...";
            CardNumberTextBox.Text = "enter Card number";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UserModel func = new UserModel();


            cards newCard = new cards(Convert.ToInt32(CardNumberTextBox.Text), CardNameTextBox.Text, date.Value.ToString());
            bool isAdded = func.createCardInfo(newCard, Program.globaleEmail);
            if (isAdded)
            {
                MessageBox.Show("successfully added...!");
                
            }
            else
            {
                MessageBox.Show("Failed to Add !");
                this.Refresh();
            }
        }

        private void createcard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserForm form = new UserForm();
            form.Show();
            this.Hide();
        }
    }
}
