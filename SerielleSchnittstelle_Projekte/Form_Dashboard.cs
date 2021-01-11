﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerielleSchnittstelle_Projekte
{
    public partial class Form_Dashboard : Form
    {
        public Form_Dashboard()
        {
            InitializeComponent();
        }

        private void btn_zeitdiagramm_Click(object sender, EventArgs e)
        {
            Form_Zeitdiagramm zeitdiagramm = new Form_Zeitdiagramm();
            this.Hide();
            zeitdiagramm.ShowDialog();
            this.Close();
        }
    }
}