using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.DB
{
    class EmisorDB
    {
        public static void cargarEmisores(System.Windows.Forms.ComboBox.ObjectCollection emisores)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format("SELECT Emisor_Descripcion FROM LOS_METATECLA.Emisor");
            conexion.ejecutarQuery();
            while (conexion.leerReader())
            {
                emisores.Add(conexion.lector.GetString(0));
            }
        }

        public static int getID(string emisor)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT TOP 1 Id_Emisor FROM LOS_METATECLA.Emisor WHERE Emisor_Descripcion LIKE '%{0}'", emisor);
            conexion.ejecutarQuery();
            conexion.leerReader();
            int id = Convert.ToInt32(conexion.lector[0]);
            conexion.cerrarConexion();
            return id;
        }

        public static bool validar(string emisor)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT * FROM LOS_METATECLA.Emisor WHERE Emisor_Descripcion LIKE '%{0}'", emisor);
            conexion.ejecutarQuery();
            bool valida = (conexion.leerReader());
            conexion.cerrarConexion();
            return valida;
        }
    }
}
