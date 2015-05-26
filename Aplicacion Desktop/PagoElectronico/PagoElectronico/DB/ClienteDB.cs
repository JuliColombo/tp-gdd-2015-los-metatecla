using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.DB
{
    class ClienteDB
    {
        public static void insertar(PagoElectronico.Dominio.Cliente cliente)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "INSERT INTO LOS_METATECLA.Cliente (Cli_Nombre, Cli_Apellido, Cli_Tipo_Doc_Cod, Cli_Nro_Doc, " +
                "Cli_Pais_Codigo, Id_Domicilio, Cli_Fecha_Nac, Cli_Mail) values ('{0}', '{1}', {2}, '{3}', '{4}', {5}, '{6}', '{7}')",
                cliente.nombre, cliente.apellido, cliente.tipo_doc, cliente.documento, cliente.pais, cliente.domicilio,
                cliente.fecha_nac, cliente.mail);
            conexion.ejecutarNoQuery();
        }
    }
}
