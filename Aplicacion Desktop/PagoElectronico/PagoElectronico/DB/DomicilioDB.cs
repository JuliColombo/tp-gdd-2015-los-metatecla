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

        public static bool yaExiste(Dominio.Domicilio domicilio)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT * FROM LOS_METATECLA.Domicilio WHERE Dom_Calle = '{0}' AND Dom_Nro = '{1}' AND Dom_Piso = '{2}' " +
                "AND Dom_Depto = '{3}'", domicilio.calle, domicilio.numero, domicilio.piso, domicilio.depto);
            conexion.ejecutarQuery();
            bool existe = (conexion.leerReader());
            conexion.cerrarConexion();
            return existe;
        }

        public static Dominio.Domicilio getDomicilio(int idDomicilio)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT * FROM LOS_METATECLA.Domicilio WHERE Id_Domicilio = '{0}'", idDomicilio);
            conexion.ejecutarQuery();
            conexion.leerReader();
            Dominio.Domicilio domicilio = new PagoElectronico.Dominio.Domicilio();
            domicilio.calle = conexion.lector.GetString(0);
            domicilio.numero = Convert.ToInt32(conexion.lector[1]);
            domicilio.piso = Convert.ToInt32(conexion.lector[2]);
            domicilio.depto = conexion.lector.GetString(3);
            conexion.cerrarConexion();
            return domicilio;
        }
    }
}
