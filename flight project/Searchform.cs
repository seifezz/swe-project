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
        UserModel um = new UserModel();
        public Searchform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = um.search(comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());
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
            Bookform bookform = new Bookform(dataGridView1.SelectedRows[0].Cells["flightid"].Value.ToString());
            bookform.Show();
            this.Hide();
        }

        private void Searchform_Load(object sender, EventArgs e)
        {
            List<Tuple<string, string>> Data = um.loadcombo();
            for (int i = 0; i < Data.Count; i++)
            {
                comboBox1.Items.Add(Data[i].Item1);
                comboBox2.Items.Add(Data[i].Item2);
            }
        }
    }
}
