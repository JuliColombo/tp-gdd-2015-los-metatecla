using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.Listados
{
    public partial class EstadisticasForm : Form
    {
        public EstadisticasForm()
        {
            InitializeComponent();
            cargarAnios();
        }

        private void cargarAnios()
        {
            int contador = 15; //Se buscarán 15 años hacia atrás
            int año = Convert.ToInt32(Dominio.Config.fechaSystem().Substring(0, 4));
            while (contador != 0)
            {
                comboBoxAño.Items.Add(año);
                año--;
                contador--;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
