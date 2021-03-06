﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.DB
{
    class DocumentoDB
    {
        public static bool validar(string tipoDoc)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT * FROM LOS_METATECLA.Tipo_Documento WHERE Doc_Tipo_Desc = '{0}'", tipoDoc);
            conexion.ejecutarQuery();
            bool valida = (conexion.leerReader());
            conexion.cerrarConexion();
            return valida;
        }

        public static double getID(string tipoDoc)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT TOP 1 Doc_Tipo_Cod FROM LOS_METATECLA.Tipo_Documento WHERE Doc_Tipo_Desc = '{0}'", tipoDoc);
            conexion.ejecutarQuery();
            conexion.leerReader();
            double id = Convert.ToDouble(conexion.lector[0]);
            conexion.cerrarConexion();
            return id;
        }

        public static string getTipoDoc(double idTipoDoc)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT * FROM LOS_METATECLA.Tipo_Documento WHERE Doc_Tipo_Cod = '{0}'", idTipoDoc);
            conexion.ejecutarQuery();
            conexion.leerReader();
            string tipoCod = conexion.lector.GetString(1);
            conexion.cerrarConexion();
            return tipoCod;
        }

        public static void cargarTiposDocumento(System.Windows.Forms.ComboBox.ObjectCollection tipos)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format("SELECT Doc_Tipo_Desc FROM LOS_METATECLA.Tipo_Documento");
            conexion.ejecutarQuery();
            while (conexion.leerReader())
            {
                tipos.Add(conexion.lector.GetString(0));
            }
        }
    }
}
