﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGEAS_iteration1
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Productsbtn_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            this.Hide();
            f.Show();
        }

        private void Customersbtn_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            this.Hide();
            f.Show();
        }

        private void Suppliersbtn_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            this.Hide();
            f.Show();
        }

        private void Transactionsbtn_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            this.Hide();
            f.Show();
        }

        private void Reportsbtn_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            this.Hide();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
    }
}