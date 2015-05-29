using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Dominio;
using PagoElectronico.DB;


namespace PagoElectronico.ABM_Rol
{
    public partial class NuevaFuncionalidad : Form
    {
        public NuevaFuncionalidad()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void botonCrearFunc_Click(object sender, EventArgs e)
        {   //1. Me fijo si el nombre esta ingresado
            FuncionalidadDB DBFuncionalidad = new FuncionalidadDB();
            if (textNombreFunc.Text == "")
            {
                MessageBox.Show("No se ingreso ningun nombre. Vuelva a intentarlo", "Error", MessageBoxButtons.OK);
                textNombreFunc.Focus();
            }
            else
            {
                //2. Me fijo si lo ingresado ya existe en el sistema
                List<Funcionalidad> funcionalidadesExistentes = FuncionalidadDB.obtenerFuncionalidades();
                if (funcionalidadesExistentes.Exists(func => func.nombre == textNombreFunc.Text))
                {
                    MessageBox.Show("La Funcionalidad ingresada ya existe en el sistema", "Error", MessageBoxButtons.OK);
                }
                else
                {//3. Inserto la funcionalidad en su tabla
                    DBFuncionalidad.AgregarFuncionalidad(textNombreFunc.Text);
                    this.Close();
                }
            }
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
