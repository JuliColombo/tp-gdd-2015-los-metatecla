using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.DB
{
    class PaisDB
    {
        public static void insertar(string pais)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "INSERT INTO LOS_METATECLA.PAIS (Pais_Desc) values ('{0}')", pais);
            conexion.ejecutarNoQuery();
        }

        public static int getID(string pais)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT Pais_Codigo FROM LOS_METATECLA.PAIS WHERE Pais_Desc = '{0}')", pais);
            conexion.ejecutarQuery();
            int id = conexion.lector.GetInt32(0);
            conexion.cerrarConexion();
            return id;
        }
    }
}
