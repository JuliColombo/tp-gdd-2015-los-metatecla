using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.DB
{
    class DomicilioDB
    {
        public static void insertar(PagoElectronico.Dominio.Domicilio domicilio)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "INSERT INTO LOS_METATECLA.Domicilio (Dom_Calle, Dom_Nro, Dom_Piso, Dom_Depto) " +
                "values ('{0}', {1}, {2}, '{3}')",
                domicilio.calle, domicilio.numero, domicilio.piso, domicilio.depto);
            conexion.ejecutarNoQuery();
        }

        public static int getID(PagoElectronico.Dominio.Domicilio domicilio)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT TOP 1 Id_Domicilio FROM LOS_METATECLA.Domicilio WHERE Dom_Calle = '{0}' AND Dom_Nro = '{1}' AND Dom_Piso = '{2}' AND Dom_Depto = '{3}'", 
                domicilio.calle, domicilio.numero, domicilio.piso, domicilio.depto);
            conexion.ejecutarQuery();
            conexion.leerReader();
            int id = conexion.lector.GetInt32(0);
            conexion.cerrarConexion();
            return id;
        }
    }
}
