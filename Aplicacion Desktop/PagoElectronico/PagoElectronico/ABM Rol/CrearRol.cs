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
            cargarCheckList();
        }
        private void cargarCheckList()
        {
           Funcionalidades.DisplayMember = "nombre";
           Funcionalidades.ValueMember = "id";
           List<Funcionalidad> funcionalidadesExistentes = FuncionalidadDB.obtenerFuncionalidades();
           for (int i = 0; i < funcionalidadesExistentes.Count(); i++)
            { 
               Funcionalidades.Items.Add(new Funcionalidad(funcionalidadesExistentes[i].id, funcionalidadesExistentes[i].nombre));
            }
        }

        private void botonCrearGuardar_Click(object sender, EventArgs e)
        {       
            //1. Me fijo que los campos esten completos ya que son OBLIGATORIOS
            if (nombreText.Text == "")
             {
              MessageBox.Show("No se ingreso Nombre del ROL", "Error, Completar Campos Obligatorios", MessageBoxButtons.OK);
              nombreText.Focus();
              } else{
              int cantidad = Funcionalidades.CheckedItems.Count;
                 if (cantidad < 1) {
                   MessageBox.Show("No se slecciono ninguna Funcionalidad", "Error, Completar Campos Obligatorios", MessageBoxButtons.OK);
                   }else{
                    //2. Una vez que verifique los campos, lo INSERTO en la tabla de roles en la DB si es posible
                     List<Funcionalidad> funcionalidadesNuevoRol = filtrarSeleccionadas();
                     RolDB DBRol = new RolDB();
                     int resultado = DBRol.AgregarRol(nombreText.Text, checkBox1.Checked, funcionalidadesNuevoRol);
                     if(resultado == (-1)){
                      MessageBox.Show("Ocurrio un error al intentar agregar el nuevo Rol", "Error", MessageBoxButtons.OK);
                     }else{
                         MessageBox.Show("Nuevo rol creado en el Sistema", "Exito", MessageBoxButtons.OK);
                         this.Close();
                     }
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
            cargarCheckList();
        }
        }
            
           
        }
        