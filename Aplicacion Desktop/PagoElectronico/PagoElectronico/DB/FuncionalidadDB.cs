using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Dominio;
using System.Data.SqlClient;

namespace PagoElectronico.DB
{
    class FuncionalidadDB
    {
        public static List<Funcionalidad> obtenerFuncionalidades()
        {
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
            Conexion conexion = new Conexion();
            conexion.query = string.Format("SELECT * FROM LOS_METATECLA.Funcionalidad");
            conexion.ejecutarQuery();
            if (conexion.lector.HasRows)
            {
                while (conexion.lector.Read())
                {
                    Funcionalidad func = new Funcionalidad((int)(decimal)conexion.lector["Id_Funcionalidad"], (string)conexion.lector["Nombre"]);
                    funcionalidades.Add(func);
                }
            }
            conexion.cerrarConexion();
            return funcionalidades;
        }


        public void AgregarFuncionalidadDelRol(int idRol,Funcionalidad funcionalidad){
            List<SqlParameter> ListParam = new List<SqlParameter>();
            ListParam.Add(new SqlParameter("@id_rol",idRol));
            ListParam.Add(new SqlParameter("@funcionalidad", funcionalidad.nombre));
            Conexion.ejecutarStoredProcedureSinRet("LOS_METATECLA.AgregarFuncionalidadARol", ListParam);
        
        }

        public void AgregarFuncionalidad(string nombre) {
            List<SqlParameter> ListParam = new List<SqlParameter>();
            ListParam.Add(new SqlParameter("@nombre", nombre));
            Conexion.ejecutarStoredProcedureSinRet("MERCADONEGRO.AgregarFuncionalidadNueva", ListParam);
        }
    }
}
