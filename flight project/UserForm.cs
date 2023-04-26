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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            createcard createcard = new createcard();
            createcard.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateinfo update = new updateinfo();
            update.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updatecardinfo update = new updatecardinfo();
            update.Show();
            this.Hide();
        }
    }
}