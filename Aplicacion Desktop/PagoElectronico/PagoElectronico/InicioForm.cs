﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico
{
    public partial class InicioForm : Form
    {
        public string texto;

        public InicioForm()
        {
            InitializeComponent();

        }


        private void btn_alta_cliente_Click(object sender, EventArgs e)
        {
            Form f = new PagoElectronico.ABM_Cliente.AltaCliForm();
            f.ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Form f = new PagoElectronico.Login.LoginForm();
            f.ShowDialog();
        }

    }
}
