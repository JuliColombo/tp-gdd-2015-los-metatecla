using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.DB
{
    class TarjetaDB
    {
        public static bool estaVencida(string numero_tarjeta)
        {
            double numero = Convert.ToDouble(numero_tarjeta);

            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT * FROM LOS_METATECLA.Tarjeta" +
                "WHERE Tarjeta_Fecha_Vencimiento < {0}", numero);
            conexion.ejecutarQuery();
            bool valida = (conexion.leerReader());
            conexion.cerrarConexion();
            return valida;
        }
    }
}
