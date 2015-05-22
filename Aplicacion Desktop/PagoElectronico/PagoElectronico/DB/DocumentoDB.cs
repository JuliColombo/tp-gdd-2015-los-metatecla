using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.DB
{
    class DocumentoDB
    {
        public static void insertar(string tipoDoc)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "INSERT INTO LOS_METATECLA.Documento (Doc_Tipo_Desc) values ('{0}')", tipoDoc);
            conexion.ejecutarNoQuery();
        }

        public static int getID(string tipoDoc)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT Doc_Tipo_Cod FROM LOS_METATECLA.Documento WHERE Doc_Tipo_Desc = '{0}')", tipoDoc);
            conexion.ejecutarQuery();
            int id = conexion.lector.GetInt32(0);
            conexion.cerrarConexion();
            return id;
        }
    }
}
