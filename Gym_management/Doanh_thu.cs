﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_management
{
    public partial class Doanh_thu : Form
    {
        public Doanh_thu()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Doanh_thu_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(" Thong ke theo ngay");
            comboBox1.Items.Add(" Thong ke theo thang");
            comboBox1.Items.Add(" Thong ke theo dich vu");
        }
    }
}
