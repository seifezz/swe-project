using Oracle.DataAccess.Client;
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
    public partial class Bookform : Form
    {
        string idtobebooked;
        int x;
        UserModel um = new UserModel();
        OracleDataReader dr = null;
        public Bookform()
        {
            InitializeComponent();
        }
        public Bookform(string id)
        {
            idtobebooked = id;
            InitializeComponent();
        }

        private void Bookform_Load(object sender, EventArgs e)
        {
            dr = um.loadbookdata(idtobebooked);
            textBox1.Text = dr[1].ToString();
            textBox2.Text = dr[2].ToString();
            textBox3.Text = dr[3].ToString();
            textBox4.Text = dr[4].ToString();
            textBox5.Text = dr[5].ToString();
            if (float.Parse(dr[3].ToString()) > 0)
            {
                textBox6.Text = um.priceafterdisc(idtobebooked);
            }
            else
            {
                textBox6.Text = dr[6].ToString();
            }
            dateTimePicker1.Text = dr[7].ToString();
            x = Convert.ToInt32(dr[4].ToString());
        }

        private void Bookform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = um.getUserByEmail(Program.globaleEmail);
            um.Bookflight(idtobebooked, user.nationalID, x);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Searchform searchform = new Searchform();
            searchform.Show();
            this.Hide();
        }
    }
}
