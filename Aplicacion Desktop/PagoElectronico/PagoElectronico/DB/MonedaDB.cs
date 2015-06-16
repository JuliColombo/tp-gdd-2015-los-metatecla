using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.DB
{
    class MonedaDB
    {
        public static int getID(string moneda)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT TOP 1 Id_Moneda FROM LOS_METATECLA.Moneda WHERE Moneda_Desc = '{0}'", moneda);
            conexion.ejecutarQuery();
            conexion.leerReader();
            int id = Convert.ToInt32(conexion.lector[0]);
            conexion.cerrarConexion();
            return id;
        }

        public static void cargarMonedas(System.Windows.Forms.ComboBox.ObjectCollection monedas)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format("SELECT Moneda_Desc FROM LOS_METATECLA.Moneda");
            conexion.ejecutarQuery();
            while (conexion.leerReader())
            {
                monedas.Add(conexion.lector.GetString(0));
            }
        }

        public static string getMoneda(int id)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT TOP 1 Moneda_Desc FROM LOS_METATECLA.Moneda WHERE Id_Moneda = {0}", id);
            conexion.ejecutarQuery();
            conexion.leerReader();
            string moneda = conexion.lector[0].ToString();
            conexion.cerrarConexion();
            return moneda;
        }
    }
}

