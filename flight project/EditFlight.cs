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

using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace flight_project
{
    public partial class EditFlight : Form
    {

        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;

        public EditFlight()
        {
            InitializeComponent();
        }

        private void EditFlight_Load(object sender, EventArgs e)
        {
            string connstr = "Data Source=orcl; User Id=Scott; Password=tiger;";
            string cmdstr = "select * from flightinfo";

            adapter = new OracleDataAdapter(cmdstr, connstr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Data Saved");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm();
            form.Show();
            this.Hide();
        }

        private void EditFlight_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
