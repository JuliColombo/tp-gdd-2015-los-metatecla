using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.ABM_Cuenta
{
    public partial class CuentaCreadaExitoForm : Form
    {
        public CuentaCreadaExitoForm()
        {
            InitializeComponent();
            label1.Text = "Cuenta creada con éxito" + '\n' + "Se envió solicitud de activación al administrador";
        }

        private void CuentaCreadaExitoForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
