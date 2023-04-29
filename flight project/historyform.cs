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
    public partial class historyform : Form
    {
        CrystalReport2 cr;
        UserModel userr = new UserModel();
        public historyform()
        {
            InitializeComponent();
        }

        private void historyform_Load(object sender, EventArgs e)
        {
            userr.movetohistory();
            cr = new CrystalReport2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();
            string nationalid = user.getnationalidbyemail(Program.globaleEmail);

            cr.SetParameterValue(0, nationalid);
            crystalReportViewer1.ReportSource = cr;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserForm form = new UserForm();
            form.Show();
            this.Hide();
        }

        private void historyform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
