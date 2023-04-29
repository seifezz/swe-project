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
    public partial class Searchform : Form
    {
        public Searchform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserModel um = new UserModel();
            dataGridView1.DataSource = um.search(textBox1.Text.ToString(), textBox2.Text.ToString());
        }

        private void Searchform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dataGridView1.SelectedRows[0].Cells["flightid"].Value.ToString());
            Bookform bookform = new Bookform(dataGridView1.SelectedRows[0].Cells["flightid"].Value.ToString());
            bookform.Show();
            this.Hide();
        }
    }
}
