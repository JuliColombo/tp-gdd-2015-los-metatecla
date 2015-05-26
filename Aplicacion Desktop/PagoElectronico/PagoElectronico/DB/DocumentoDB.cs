using System;
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
                "SELECT * FROM LOS_METATECLA.Documento WHERE Doc_Tipo_Desc = '{0}'", tipoDoc);
            conexion.ejecutarQuery();
            //conexion.leerReader();
            return conexion.leerReader();
        }

        public static double getID(string tipoDoc)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT TOP 1 Doc_Tipo_Cod FROM LOS_METATECLA.Documento WHERE Doc_Tipo_Desc = '{0}'", tipoDoc);
            conexion.ejecutarQuery();
            conexion.leerReader();
            double id = Convert.ToDouble(conexion.lector[0]);
            conexion.cerrarConexion();
            return id;
        }
    }
}
