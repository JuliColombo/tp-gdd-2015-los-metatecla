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
            DB.MonedaDB.cargarMonedas(comboBox_moneda.Items);
            maskedTextBox_fecha.Text = PagoElectronico.Dominio.Config.fecha_DDMMYYYY(Dominio.Config.fechaSystem());            
        }

        public CrearCuentaForm(PagoElectronico.Dominio.Cuenta cuenta)
        {
            InitializeComponent();

            DB.TipoCuentaDB.cargarTipos(comboBox_tipo.Items);

            textBox_usuario.Text = DB.ClienteDB.getCliente(cuenta.idPropietario).nombre;
            textBox_nro_cuenta.Text = cuenta.numero.ToString();
            maskedTextBox_fecha.Text = cuenta.fecha_cierre.ToString();
            comboBoxPais.Text = DB.PaisDB.getPais(cuenta.pais);
            comboBox_tipo.Text = DB.TipoCuentaDB.getTipo(cuenta.tipo);
            comboBox_moneda.Text = DB.MonedaDB.getMoneda(cuenta.moneda);

            textBox_usuario.ReadOnly = true;
            textBox_nro_cuenta.ReadOnly = true;
            comboBox_moneda.Enabled = false;
            comboBoxPais.Enabled = false;
            maskedTextBox_fecha.ReadOnly = true;
        
        }



        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (validarCamposVacios())
            {
                if (textBox_nro_cuenta.ReadOnly)
                {
                        modificarCuenta(textBox_nro_cuenta.Text, comboBox_tipo.Text); 
                }
                else
                {
                    if (validaciones())
                    {
                        crearCuenta();
                    }else { MessageBox.Show("Hay un error en los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void modificarCuenta(string nro_cuenta, string tipo)
        {
            PagoElectronico.DB.CuentaDB.modificarTipoCuenta(Convert.ToInt64(nro_cuenta), tipo);
            PagoElectronico.Dominio.Costos costo = DB.TipoCuentaDB.obtenerCosto(DB.TipoCuentaDB.getId(tipo));
            DB.FacturaDB.insertarItemPendiente("Costo por Modificacion", costo.costoModificacion, Convert.ToInt64(nro_cuenta), 1);
            Form exito = new PagoElectronico.UI.ExitoForm("Cuenta modificada con éxito");
            exito.ShowDialog();
            this.Close();
        }

        private void crearCuenta()
        {
            crearCuenta(textBox_nro_cuenta.Text, textBox_usuario.Text, comboBoxPais.Text, comboBox_tipo.Text, maskedTextBox_fecha.Text, comboBox_moneda.Text);

            double costoApertura = (DB.TipoCuentaDB.obtenerCosto(DB.TipoCuentaDB.getId(comboBox_tipo.Text)).costoApertura);
            long numeroCta = Convert.ToInt64(textBox_nro_cuenta.Text);
            DB.FacturaDB.insertarItemPendiente("Costo por Apertura de cuenta", costoApertura, numeroCta,0);
            limpiar();
            Form exito = new UI.ExitoForm("Cuenta creada con éxito" + '\n' + "Se envió solicitud de activación al administrador");
            exito.ShowDialog();
            this.Close();
        }


        private bool validarCamposVacios()
        {
            bool valido = true;

            ponerErroresInvisibles();

            if (textBox_usuario.Text == "")
            {
                valido = false;
                labelError_usuario.Visible = true;
            };

            if (textBox_nro_cuenta.Text == "")
            {
                valido = false;
                labelError_nro_cuenta.Visible = true;
            };

            if (comboBoxPais.Text == "")
            {
                valido = false;
                labelError_pais.Visible = true;
            };

            if (comboBox_tipo.Text == "")
            {
                valido = false;
                labelError_tipo.Visible = true;
            };

            if (comboBox_moneda.Text == "")
            {
                valido = false;
                labelError_moneda.Visible = true;
            };

            if (maskedTextBox_fecha.Text == "")
            {
                valido = false;
                labelError_fecha.Visible = true;
            };

            return valido;
        }

        private void crearCuenta(string nro_cuenta, string usuario, string pais, string tipo, string fecha, string moneda)
        {
            PagoElectronico.DB.CuentaDB.crearCuenta(nro_cuenta, usuario, pais, tipo, fecha, moneda);
        }


        private void ventanaDeError(String error)
        {
            Form f = new PagoElectronico.UI.ErrorForm(error);
            f.ShowDialog();
        }

        private bool validaciones()
        {
            return validarUsuario(textBox_usuario.Text) && validadNroCuenta(textBox_nro_cuenta.Text) && validarFechaApertura(maskedTextBox_fecha.Text);
        }

        private bool validarFechaApertura(string fecha)
        {
            DateTime date = Convert.ToDateTime(fecha);
            DateTime fecha_sistema = Convert.ToDateTime(PagoElectronico.Dominio.Config.fechaSystem());

            int comparacion = DateTime.Compare(date, fecha_sistema);

            return comparacion <= 0;

        }

        private bool validadNroCuenta(string nro_cuenta)
        {
            return PagoElectronico.DB.CuentaDB.noExisteCuenta(nro_cuenta);
        }

        private bool validarUsuario(string usuario)
        {
            return PagoElectronico.DB.UsuarioDB.existe(usuario);
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            textBox_nro_cuenta.Text = "";
            textBox_usuario.Text = "";
            comboBox_tipo.Text = "";
            comboBox_moneda.Text = "";
            comboBoxPais.Text = "";
            maskedTextBox_fecha.Text = "";
            ponerErroresInvisibles();
        }

        private void ponerErroresInvisibles()
        {
            labelError_fecha.Visible = false;
            labelError_usuario.Visible = false;
            labelError_nro_cuenta.Visible = false;
            labelError_tipo.Visible = false;
            labelError_pais.Visible = false;
        }

        private void textBox_nro_cuenta_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_nro_cuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            EventosUI.soloNumeros(e);
        }

        private void textBox_fecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            EventosUI.soloNumeros(e);
        }


    }
}

