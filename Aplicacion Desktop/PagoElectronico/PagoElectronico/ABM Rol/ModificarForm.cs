using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Dominio;

namespace PagoElectronico.ABM_Rol
{
    public partial class ModificarForm : Form
    {
        public ModificarForm(Rol rol)
        {
            InitializeComponent();
            this.CenterToScreen();
            label1.Text = rol.nombre;
            label2.Text = rol.estado;
            cargarListBox(rol);

        }

        public void cargarListBox(Rol rol){
            List<string> nombreFuncionalidades = new List<string>();
            foreach ( Funcionalidad func in (rol.funcionalidades)){
                nombreFuncionalidades.Add(func.nombre);
            }
            funcionalidadesActuales.DataSource = nombreFuncionalidades;

        }
    }
}
