﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Dominio;
using System.Data.SqlClient;

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

        internal static int getId(string tipo)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT TOP 1 Id_Tipo FROM LOS_METATECLA.Tipo_Cuenta WHERE Tipo_Desc = '{0}'", tipo);
            conexion.ejecutarQuery();
            conexion.leerReader();
            int id = Convert.ToInt32(conexion.lector[0]);
            conexion.cerrarConexion();
            return id;
        }

        public static double obtenerCosto(int id)
        {
            double i = 0;
            Conexion conexion = new Conexion();
            List<SqlParameter> ListParam = new List<SqlParameter>();
            conexion.query = string.Format("SELECT Tipo_Costo FROM LOS_METATECLA.Tipo_Cuenta WHERE (Id_Tipo = '{0}')",id);
            //ListParam.Add(new SqlParameter("@id_tipo", id));
           // SqlDataReader lector = conexion.ejecutarQueryConParam("SELECT Tipo_Costo FROM LOS_METATECLA.Tipo_Cuenta WHERE (Id_Tipo = @id_tipo)", ListParam);
            i = (double)(decimal)conexion.lector["Tipo_costo"];
            conexion.cerrarConexion();
            return i;

        }
    }
}
