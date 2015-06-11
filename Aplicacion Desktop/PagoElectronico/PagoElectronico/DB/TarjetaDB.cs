using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.DB
{
    class TarjetaDB
    {
        public static bool estaVencida(string numero_tarjeta)
        {
            double numero = Convert.ToDouble(numero_tarjeta);

            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT * FROM LOS_METATECLA.Tarjeta" +
                "WHERE Tarjeta_Fecha_Vencimiento < {0}", numero);
            conexion.ejecutarQuery();
            bool valida = (conexion.leerReader());
            conexion.cerrarConexion();
            return valida;
        }

        public static List<ABM_Cliente.TarjetaEdit> buscarTarjetas(int idCliente)
        {
            List<ABM_Cliente.TarjetaEdit> tarjetas = new List<ABM_Cliente.TarjetaEdit>();
            Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT Tarjeta_Ultimos_4, Emisor_Descripcion, Tarjeta_Fecha_Emision, Tarjeta_Fecha_Vencimiento " +
                "FROM LOS_METATECLA.Tarjeta, LOS_METATECLA.Emisor " +
                "WHERE Tarjeta_Emisor_Id = Id_Emisor AND Id_Cliente_Propietario = '{0}' AND Tarjeta_Estado = 'Activa'",
                idCliente);
            conexion.ejecutarQuery();
            while (conexion.leerReader())
            {
                ABM_Cliente.TarjetaEdit tarjeta = new ABM_Cliente.TarjetaEdit();
                tarjeta.ultimos4 = conexion.lector.GetString(0);
                tarjeta.emisor = conexion.lector.GetString(1);
                tarjeta.fecha_emision = Convert.ToString(conexion.lector[2]);
                tarjeta.fecha_vencimiento = Convert.ToString(conexion.lector[3]);
                tarjetas.Add(tarjeta);
            }
            conexion.cerrarConexion();
            return tarjetas;
        }

        public static void insertar(Dominio.Tarjeta tarjeta)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "INSERT INTO LOS_METATECLA.Tarjeta (Tarjeta_Numero, Tarjeta_Ultimos_4, Tarjeta_Fecha_Emision, Tarjeta_Fecha_Vencimiento, " +
                "Tarjeta_Codigo_Seg, Tarjeta_Emisor_Id, Id_Cliente_Propietario, Tarjeta_Estado) " +
                "values ('{0}', RIGHT('{0}', 4), '{1}', '{2}', '{3}', {4}, {5}, 'Activa')",
                tarjeta.numero, tarjeta.fecha_emision, tarjeta.fecha_vencimiento, tarjeta.codigo_seguridad,
                tarjeta.emisor, tarjeta.cliente);
            conexion.ejecutarNoQuery();
        }

        public static void darDeBaja(string ultimos4, int idCliente)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "UPDATE LOS_METATECLA.Tarjeta SET Tarjeta_Estado = 'Inactiva' " +
                "WHERE Tarjeta_Ultimos_4 = '{0}' AND Id_Cliente_Propietario = {1}", ultimos4, idCliente);
            conexion.ejecutarNoQuery();
        }
    }
}
