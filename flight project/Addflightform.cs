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
    public partial class Addflightform : Form
    {
        AdminModel adminModel = new AdminModel();
        public Addflightform()
        {
            InitializeComponent();
        }


        private void backbtn_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }

        private void Addflightform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            string userBirthDateArr = dateTimePicker1.Value.ToString().Split(' ')[0];
            string userBirthDate = Convert.ToDateTime(userBirthDateArr).ToString("dd-MM-yyyy");

            bool x = adminModel.InsertFlight(textBox1.Text.ToString(), textBox2.Text.ToString(), float.Parse(textBox3.Text.ToString()),
             Convert.ToInt32(textBox4.Text.ToString()), Convert.ToChar(textBox5.Text.ToString()), float.Parse(textBox6.Text.ToString()),
             userBirthDate);
            if (x)
            {
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox)
                    {
                        ((TextBox)control).Text = "";
                    }
                }
                dateTimePicker1.Value = DateTime.Today;
            }
        }
    }
}
