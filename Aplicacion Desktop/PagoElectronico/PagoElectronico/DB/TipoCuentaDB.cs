using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.DB
{
    class TipoCuentaDB
    {
        public static void cargarTipos(System.Windows.Forms.ComboBox.ObjectCollection tipos)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format("SELECT Tipo_Desc FROM LOS_METATECLA.Tipo_Cuenta");
            conexion.ejecutarQuery();
            while (conexion.leerReader())
            {
                tipos.Add(conexion.lector.GetString(0));
            }
        }
    }
}
