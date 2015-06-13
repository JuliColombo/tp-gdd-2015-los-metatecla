using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.DB
{
    class DepositoDB
    {
        public static double obtener_ultimo_codigo_deposito()
        {
            Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT MAX(Deposito_Codigo)" +
                "FROM LOS_METATECLA.Deposito ");
            conexion.ejecutarQuery();
            conexion.leerReader();
            
            double ultimo_codigo = Convert.ToDouble(conexion.lector[0]);
            
            conexion.cerrarConexion();
            return ultimo_codigo;
        }

    }
}
