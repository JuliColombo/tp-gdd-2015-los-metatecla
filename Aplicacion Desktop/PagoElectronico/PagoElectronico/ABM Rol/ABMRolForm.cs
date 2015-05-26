using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.DB;

namespace PagoElectronico.ABM_Rol
{
    public partial class ABMRolForm : Form
    {
        public ABMRolForm()
        {
            InitializeComponent();
            actualizarDataGrid();

        }

        private void actualizarDataGrid()
        {
            dataGridRoles.DataSource = RolDB.obtenerRoles();
        }
        private void ABMRolForm_Load(object sender, EventArgs e)
        {

        }

        // Si se hace click en crear se abre nueva ventana con las opciones correspondientes
        private void botonCrear_Click(object sender, EventArgs e)
        {
            CrearRol creacion = new CrearRol();
            creacion.ShowDialog();
            actualizarDataGrid();
        }

     
    }
}
