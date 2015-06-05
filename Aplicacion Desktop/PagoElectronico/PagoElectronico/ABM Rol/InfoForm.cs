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
    public partial class InfoForm : Form
    {
        Rol infoRol;
        public InfoForm(Rol rol)
        {
            InitializeComponent();
            this.CenterToScreen();
            infoRol = rol;
            nombreLabel.Text = rol.nombre;
            estadoLabel.Text = rol.estado;
            cargarCheckList();

        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        public void cargarCheckList()
        {
            listaFuncionalidades.DisplayMember = "nombre";
            listaFuncionalidades.ValueMember = "id";
            FuncionalidadDB funcDB = new FuncionalidadDB();
            List<Funcionalidad> funcionalidadesExistentes = funcDB.obtenerFuncRol(infoRol);
            foreach (Funcionalidad func in funcionalidadesExistentes)
            {
                if (!listaFuncionalidades.Items.Contains(func))
                {
                    listaFuncionalidades.Items.Add(func);
                }
            }
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {

        }

       
    }
}
