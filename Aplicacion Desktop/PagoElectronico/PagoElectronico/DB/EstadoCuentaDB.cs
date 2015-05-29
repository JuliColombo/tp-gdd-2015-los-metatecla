using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.DB
{
    class EstadoCuentaDB
    {
        public static int getID(string estado)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT TOP 1 Id_Estado FROM LOS_METATECLA.Estado_Cuenta WHERE Estado_Desc = '{0}'", estado);
            conexion.ejecutarQuery();
            conexion.leerReader();
            int id = Convert.ToInt32(conexion.lector[0]);
            conexion.cerrarConexion();
            return id;
        }
    }
}
