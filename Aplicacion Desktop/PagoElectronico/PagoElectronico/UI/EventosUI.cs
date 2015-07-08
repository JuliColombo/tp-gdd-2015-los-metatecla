using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico
{
    class EventosUI
    {
        public static void soloNumeros(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        public static void soloDecimales(KeyPressEventArgs e, TextBox textBox)
        {
            if (e.KeyChar == 46 && textBox.Text.IndexOf('.') != -1)
            {
                MessageBox.Show("Solo se permite una coma", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }

        }

        public static bool validar_fecha_DDMMYYYY(string fecha)
        {
            bool validacion = true;
            int dia, mes, anio;
            
            dia = Convert.ToInt32(fecha.Substring(0,2));
            mes = Convert.ToInt32(fecha.Substring(3,2));
            anio = Convert.ToInt32(fecha.Substring(6,4));

            if (mes > 0 && mes < 13 & dia > 0)
            {
                switch(mes){
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        if (dia>31){
                            validacion = false;};
                        break;
                    case 2:
                        if (dia>28){
                            validacion = false;};
                        break;
                    default:
                        if (dia>30){
                            validacion = false;};
                        break;

                }
            }else{
                validacion = false;
            }

            return validacion;
            
        }
    }
}
