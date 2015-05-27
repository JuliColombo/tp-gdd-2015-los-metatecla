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
    public partial class CrearCuentaForm : Form
    {
        public CrearCuentaForm()
        {
            InitializeComponent();
            DB.PaisDB.cargarPaises(comboBoxPais.Items);
            DB.TipoCuentaDB.cargarTipos(comboBox_tipo.Items);
        }

        private void CrearCuentaForm_Load(object sender, EventArgs e)
        {

        }



    }
}
