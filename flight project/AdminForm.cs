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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void addflightbtn_Click(object sender, EventArgs e)
        {
            Addflightform addflightform = new Addflightform();
            addflightform.Show();
            this.Hide();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void editflightinfo_Click(object sender, EventArgs e)
        {
            Updateflightform updateflightform = new Updateflightform();
            updateflightform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            signinform signin = new signinform();
            signin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminreport form = new adminreport();
            form.Show();
            this.Hide();
        }
    }
}
