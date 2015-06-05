using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.DB;
using PagoElectronico.Dominio;

namespace PagoElectronico.ABM_Rol
{
    public partial class CrearRol : Form
    {

        public CrearRol()
        {
            InitializeComponent();
            this.CenterToScreen();
            cargarCheckList();

        }


        private void cargarCheckList()
        {
            Funcionalidades.DisplayMember = "nombre";
            Funcionalidades.ValueMember = "id";
            List<Funcionalidad> funcionalidadesExistentes = FuncionalidadDB.obtenerFuncionalidades();
            foreach (Funcionalidad func in funcionalidadesExistentes)
            {
                if (!Funcionalidades.Items.Contains(func))
                {
                    Funcionalidades.Items.Add(func);
                }
            }
        }

        private void actualizarCheckList()
        {//SEGURO hay una mejor forma de hacer esto
            Funcionalidades.Items.Clear();
            cargarCheckList();
        }

        private void botonCrearGuardar_Click(object sender, EventArgs e)
        {
            //1. Me fijo que los campos esten completos ya que son OBLIGATORIOS
            if (nombreText.Text == "")
            {
                MessageBox.Show("No se ingreso Nombre del ROL", "Error, Completar Campos Obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nombreText.Focus();
            }
            else
            {
                int cantidad = Funcionalidades.CheckedItems.Count;
                if (cantidad < 1)
                {
                    MessageBox.Show("No se slecciono ninguna Funcionalidad", "Error, Completar Campos Obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //2. Una vez que verifique los campos, lo INSERTO en la tabla de roles en la DB si es posible
                    List<Funcionalidad> funcionalidadesNuevoRol = filtrarSeleccionadas();
                    RolDB DBRol = new RolDB();
                    List<Rol> rolesActuales = RolDB.obtenerRoles();
                    Rol nuevoRol = new Rol(-1,nombreText.Text,checkBox1.Checked);
                    nuevoRol.funcionalidades = funcionalidadesNuevoRol;
                    if(!rolesActuales.Exists(rol => rol.nombre == nuevoRol.nombre)){
                    DBRol.AgregarRol(nuevoRol);
                    MessageBox.Show("Nuevo rol creado en el Sistema", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    }
                    else { MessageBox.Show("El Rol ya existe en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }


        private List<Funcionalidad> filtrarSeleccionadas() {
         List<Funcionalidad> funcionalidadesNuevoRol = new List<Funcionalidad>();
               for (int i = 0; i < Funcionalidades.Items.Count; i++)
                {
                    if (Funcionalidades.GetItemChecked(i))
                    {
                        Funcionalidad funcionalidad = Funcionalidades.Items[i] as Funcionalidad;
                        funcionalidadesNuevoRol.Add(funcionalidad);
                    }
                }
                return funcionalidadesNuevoRol;
            }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonNewFunc_Click(object sender, EventArgs e)
        {
            NuevaFuncionalidad NewFunc = new NuevaFuncionalidad();
            NewFunc.Owner = this;
            NewFunc.ShowDialog();
            actualizarCheckList();
        }
        }
            
           
        }
        