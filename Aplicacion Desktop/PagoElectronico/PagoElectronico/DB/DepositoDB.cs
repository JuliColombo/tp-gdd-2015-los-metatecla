using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.DB
{
    class DepositoDB
    {
        public static double obtener_ultimo_codigo_deposito()
        {
            Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
            conexion.query = string.Format(
                "SELECT MAX(Deposito_Codigo) " +
                "FROM LOS_METATECLA.Deposito ");
            conexion.ejecutarQuery();
            conexion.leerReader();
            
            double ultimo_codigo = Convert.ToDouble(conexion.lector[0]);
            
            conexion.cerrarConexion();
            return ultimo_codigo;
        }

        

    
    public static void insertar_deposito(double codigo_deposito,double importe,int moneda,int id,long cuenta)
    {
        DateTime fecha = Convert.ToDateTime(PagoElectronico.Dominio.Config.fechaSystem());

        PagoElectronico.Dominio.Conexion conexion = new PagoElectronico.Dominio.Conexion();
        conexion.query = string.Format(
            "INSERT INTO LOS_METATECLA.Deposito (Deposito_Codigo, Deposito_Fecha, Deposito_Importe, Deposito_Moneda, Tarjeta_Id, Numero_Cuenta) " + 
            "VALUES ({0}, NULL, {2}, {3}, {4}, {5})",
            codigo_deposito, fecha, importe, moneda, id, cuenta);
        
        conexion.ejecutarNoQuery();
    }
    
    }
}
