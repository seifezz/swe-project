﻿using System;
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
    }
}