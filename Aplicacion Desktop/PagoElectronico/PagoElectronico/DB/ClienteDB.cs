﻿using System;
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

        public static bool mailRepetido(String mail)
        {
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT TOP 1 * FROM LOS_METATECLA.Cliente WHERE Cli_mail = '{0}'", mail);
            conexion.ejecutarQuery();
            bool repetido = (conexion.leerReader());
            conexion.cerrarConexion();
            return repetido;
        }

        public static bool documentoRepetido(int documento)
        {
            //int doc = Convert.ToInt32(documento);
            PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT TOP 1 * FROM LOS_METATECLA.Cliente WHERE Cli_Nro_Doc = '{0}'", documento);
            conexion.ejecutarQuery();
            bool repetido = (conexion.leerReader());
            conexion.cerrarConexion();
            return repetido;
        }

        public static List<ABM_Cliente.ClienteEdit> buscarClientes(string nom, string ape, string tipoDoc, string doc, string mail)
        {
            List<ABM_Cliente.ClienteEdit> clientes = new List<ABM_Cliente.ClienteEdit>();
            Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT Cli_Nombre, Cli_Apellido, Doc_Tipo_Desc, Cli_Nro_Doc, Cli_Mail " +
                "FROM LOS_METATECLA.Cliente, LOS_METATECLA.Documento " +
                "WHERE Cli_Tipo_Doc_Cod = Doc_Tipo_Cod AND Cli_Nombre LIKE '%{0}%' AND Cli_Apellido LIKE '%{1}%' " +
                "AND Doc_Tipo_Desc LIKE '%{2}%' AND Cli_Nro_Doc LIKE '%{3}%' AND Cli_Mail LIKE '%{4}%'",
                nom, ape, tipoDoc, doc, mail);
            conexion.ejecutarQuery();
            while (conexion.leerReader())
            {
                ABM_Cliente.ClienteEdit cliente = new ABM_Cliente.ClienteEdit();
                cliente.nombre = conexion.lector.GetString(0);
                cliente.apellido = conexion.lector.GetString(1);
                cliente.tipo_doc = conexion.lector.GetString(2);
                cliente.documento = Convert.ToInt32(conexion.lector[3]);
                cliente.mail = conexion.lector.GetString(4);
                clientes.Add(cliente);
            }
            conexion.cerrarConexion();
            return clientes;
        }
    }
}
