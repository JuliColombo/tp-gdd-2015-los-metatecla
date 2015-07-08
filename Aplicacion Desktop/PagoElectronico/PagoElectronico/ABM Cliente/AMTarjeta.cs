using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.ABM_Cliente
{
    public partial class AMTarjeta : Form
    {
        public int idCliente {get; set;}
        public bool alta { get; set; }

        public AMTarjeta()
        {
            InitializeComponent();
        }

        public AMTarjeta(int idCli, string ultimos4)
        {
            InitializeComponent();
            DB.EmisorDB.cargarEmisores(comboBoxEmisores.Items);
            this.idCliente = idCli;
            this.alta = (ultimos4 == "0");
            if (!alta)
            {
                cambiarComponentes();
                cargarCampos(ultimos4);
            }
        }

        private void limpiar()
        {
            boxNumero.Text = "";
            boxCodSeguridad.Text = "";
            comboBoxEmisores.Text = "";
            boxFechaEmision.Text = "";
            boxFechaVencimiento.Text = "";

            limpiarErrores();
        }

        private void limpiarErrores()
        {
            labelErrorFVenc.Visible = false;
            labelErrorNro.Visible = false;
            labelErrorFEmision.Visible = false;
            labelErrorEmisor.Visible = false;
            labelErrorCod.Visible = false;
            labelErrorFechaEmi.Visible = false;
            labelErrorFechaVenc.Visible = false;
        }

        private void cambiarComponentes()
        {
            labelNumero.Text = "Últimos 4 números";
            boxCodSeguridad.ReadOnly = true;
            boxCodSeguridad.UseSystemPasswordChar = true;
            boxNumero.ReadOnly = true;
            comboBoxEmisores.Enabled = false;
        }

        private void cargarCampos(string ultimos4)
        {
            Dominio.Tarjeta tarjeta = DB.TarjetaDB.getTarjeta(ultimos4, idCliente);
            boxNumero.Text = ultimos4;
            boxCodSeguridad.Text = tarjeta.codigo_seguridad;
            comboBoxEmisores.Text = DB.EmisorDB.getEmisor(tarjeta.emisor);
            boxFechaEmision.Text = tarjeta.fecha_emision;
            boxFechaVencimiento.Text = tarjeta.fecha_vencimiento;
        }

        private void boxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            EventosUI.soloNumeros(e);
        }

        private void boxCodSeguridad_KeyPress(object sender, KeyPressEventArgs e)
        {
            EventosUI.soloNumeros(e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private bool validarCamposVacios()
        {
            bool valido = true;
            if (boxNumero.Text == "")
            {
                valido = false;
                labelErrorNro.Visible = true;
            }
            if (boxCodSeguridad.Text == "")
            {
                valido = false;
                labelErrorCod.Visible = true;
            }
            if (comboBoxEmisores.Text == "")
            {
                valido = false;
                labelErrorEmisor.Visible = true;
            }
            if (boxFechaEmision.Text == "  /  /")
            {
                valido = false;
                labelErrorFEmision.Visible = true;
            }
            if (boxFechaVencimiento.Text == "  /  /")
            {
                valido = false;
                labelErrorFVenc.Visible = true;
            }
            return valido;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.limpiarErrores();
            if (this.validarCamposVacios())
            {
                if (DB.EmisorDB.validar(comboBoxEmisores.Text))
                {
                    if (alta)
                    {
                        confirmarAlta();
                    }
                    else
                    {
                        confirmarModificacion();
                    }
                }
            }
        }

        private bool validarFechas()
        {
            bool valido = true;
            if(PagoElectronico.EventosUI.validar_fecha_DDMMYYYY(boxFechaEmision.Text)){
                valido = false;
                labelErrorFechaEmi.Visible = true;
            }
            if(PagoElectronico.EventosUI.validar_fecha_DDMMYYYY(boxFechaVencimiento.Text)){
                valido = false;
                labelErrorFechaVenc.Visible = true;
            }
            return valido;
        }

        private void confirmarAlta()
        {
            Dominio.Tarjeta tarjeta = this.cargarTarjeta();
            DB.TarjetaDB.insertar(tarjeta);
            MessageBox.Show("¡Tarjeta asociada correctamente!");
            this.Close();
        }

        private void confirmarModificacion()
        {
            Dominio.Tarjeta tarjeta = this.cargarTarjeta();
            DB.TarjetaDB.modificarFechas(tarjeta);
            MessageBox.Show("Tarjeta modificada con éxito");
            this.Close();
        }

        private Dominio.Tarjeta cargarTarjeta()
        {
            Dominio.Tarjeta tarjeta = new PagoElectronico.Dominio.Tarjeta();
            tarjeta.numero = boxNumero.Text;
            tarjeta.codigo_seguridad = boxCodSeguridad.Text;
            tarjeta.emisor = DB.EmisorDB.getID(comboBoxEmisores.Text);
            tarjeta.cliente = idCliente;
            tarjeta.fecha_emision = boxFechaEmision.Text;
            tarjeta.fecha_vencimiento = boxFechaVencimiento.Text;
            return tarjeta;
        }

    }
}
