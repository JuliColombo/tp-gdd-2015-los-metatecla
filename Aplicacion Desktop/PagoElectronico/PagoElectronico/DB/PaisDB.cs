using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.DB
{
    class PaisDB
    {
        public static bool validar(string pais)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT * FROM LOS_METATECLA.PAIS WHERE Pais_Desc LIKE '%{0}'", pais);
            conexion.ejecutarQuery();
            bool valida = (conexion.leerReader());
            conexion.cerrarConexion();
            return valida;
        }

        public static double getID(string pais)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT TOP 1 Pais_Codigo FROM LOS_METATECLA.PAIS WHERE Pais_Desc LIKE '%{0}'", pais);
            conexion.ejecutarQuery();
            conexion.leerReader();
            double id = Convert.ToDouble(conexion.lector[0]);
            conexion.cerrarConexion();
            return id;
        }

        public static string getPais(double idPais)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT * FROM LOS_METATECLA.PAIS WHERE Pais_Codigo = '{0}'", idPais);
            conexion.ejecutarQuery();
            conexion.leerReader();
            string pais = conexion.lector.GetString(1);
            conexion.cerrarConexion();
            return pais;
        }

        public static void cargarPaises(System.Windows.Forms.ComboBox.ObjectCollection paises)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format("SELECT Pais_Desc FROM LOS_METATECLA.PAIS");
            conexion.ejecutarQuery();
            while (conexion.leerReader())
            {
                paises.Add(conexion.lector.GetString(0));
            }
        }
    }
}
