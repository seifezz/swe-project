using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace flight_project
{
    public partial class cancelflight : Form
    {
        public cancelflight()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            bool cancelled = false;
            UserModel user = new UserModel();
            id = Convert.ToInt32(textBox1.Text);
            cancelled = user.cancelflight(id);
            if (cancelled)
            {
                textBox1.Text = "";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserForm form = new UserForm();
            form.Show();
            this.Hide();
        }

        private void cancelflight_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
