using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.ABM_Cliente
{
    public partial class BuscadorCliForm : Form
    {
        public BuscadorCliForm()
        {
            InitializeComponent();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            if (this.validarCampos()){
                listado.DataSource = DB.ClienteDB.buscarClientes(boxNombre.Text, boxApellido.Text, comboBoxTipoDoc.Text, boxDocumento.Text, boxMail.Text);
            }
        }

        private bool validarCampos()
        {
            return true;
        }
    }
}
