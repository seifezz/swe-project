using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace flight_project
{
    public partial class adminreport : Form
    {
        CrystalReport1 cr;
        public adminreport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0, flightid_text.Text);
            crystalReportViewer1.ReportSource = cr;
            flightid_text.Text = "";
        }

        private void adminreport_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport1();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm();
            form.Show();
            this.Hide();
        }

        private void adminreport_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
