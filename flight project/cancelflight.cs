using System;
using System.Windows.Forms;

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
    }
}
