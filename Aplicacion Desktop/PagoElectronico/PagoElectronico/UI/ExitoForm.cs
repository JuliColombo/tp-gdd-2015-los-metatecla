﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.UI
{
    public partial class ExitoForm : Form
    {
        public ExitoForm(string mensaje)
        {
            InitializeComponent();
            label1.Text = mensaje;
        }

        private void CuentaCreadaExitoForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
