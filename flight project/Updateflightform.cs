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
    public partial class Updateflightform : Form
    {
        AdminModel adminModel = new AdminModel();
        public Updateflightform()
        {
            InitializeComponent();
        }


        private void Updateflightform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void Updateflightform_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = adminModel.loadinfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                dataTable.Columns.Add(column.Name, column.ValueType);
            }

            dataTable = (DataTable)dataGridView1.DataSource;
            adminModel.saveinfo(dataTable);
            MessageBox.Show("Updated Successfully!");
        }
    }
}
