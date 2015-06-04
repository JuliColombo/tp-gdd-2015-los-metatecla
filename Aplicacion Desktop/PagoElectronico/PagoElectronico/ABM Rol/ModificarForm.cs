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
    public partial class ModificarForm : Form
    {
        Rol rolAModificar;
        public ModificarForm(Rol rol)
        {
            InitializeComponent();
            this.CenterToScreen();
            label1.Text = rol.nombre;
            label2.Text = rol.estado;
            rolAModificar = rol;
            cargarListBox(rol);
            cargarCheckList();


        }

        public void cargarListBox(Rol rol)
        {
            List<string> nombreFuncionalidades = new List<string>();
            foreach (Funcionalidad func in (rol.funcionalidades))
            {
                nombreFuncionalidades.Add(func.nombre);
            }
            funcionalidadesActuales.DataSource = nombreFuncionalidades;

        }

        public void cargarCheckList()
        {
            funcionalidadesDelSistema.DisplayMember = "nombre";
            funcionalidadesDelSistema.ValueMember = "id";
            List<Funcionalidad> funcionalidadesExistentes = FuncionalidadDB.obtenerFuncionalidades();
            foreach (Funcionalidad func in funcionalidadesExistentes)
            {
                if (!funcionalidadesDelSistema.Items.Contains(func))
                {
                    funcionalidadesDelSistema.Items.Add(func);
                }
            }
        }

        private void actualizarCheckList()
        {//SEGURO hay una mejor forma de hacer esto
            funcionalidadesDelSistema.Items.Clear();
            cargarCheckList();
        }

        private void botonNuevaFunc_Click(object sender, EventArgs e)
        {
            NuevaFuncionalidad newFunc = new NuevaFuncionalidad();
            newFunc.ShowDialog();
            actualizarCheckList();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
                int cantidad = funcionalidadesDelSistema.CheckedItems.Count;
                if (cantidad < 1)
                {
                    MessageBox.Show("No se slecciono ninguna Funcionalidad", "Error, Completar Campos Obligatorios", MessageBoxButtons.OK);
                }
                else
                {
                    if (!(textNewNombre.Text == "")) {
                        rolAModificar.nombre = textNewNombre.Text;
                    }
                    rolAModificar.habilitado = chkEstado.Checked;
                    rolAModificar.funcionalidades = filtrarSeleccionadas();
                    RolDB DBRol = new RolDB();
                    DBRol.actualizarRol(rolAModificar);
                    this.Close();  
                }

                
        }

        private List<Funcionalidad> filtrarSeleccionadas()
        {
            List<Funcionalidad> funcionalidadesNuevoRol = new List<Funcionalidad>();
            for (int i = 0; i < funcionalidadesDelSistema.Items.Count; i++)
            {
                if (funcionalidadesDelSistema.GetItemChecked(i))
                {
                    Funcionalidad funcionalidad = funcionalidadesDelSistema.Items[i] as Funcionalidad;
                    funcionalidadesNuevoRol.Add(funcionalidad);
                }
            }
            return funcionalidadesNuevoRol;
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
