﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Tracking_System
{
    public partial class Kar_Zarar : Form
    {
        public Kar_Zarar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FinansAnasayfa finans = new FinansAnasayfa();
            finans.Show();
            this.Hide();
        }
    }
}
