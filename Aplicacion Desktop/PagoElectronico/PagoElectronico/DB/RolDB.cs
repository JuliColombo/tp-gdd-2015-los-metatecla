using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Dominio;
using System.Data.SqlClient;

namespace PagoElectronico.DB
{
    class RolDB
    {
         public static List<Rol> obtenerRoles()
        {
            List<Rol> roles = new List<Rol>();
            Conexion conexion = new Conexion();
            conexion.query = string.Format("SELECT * FROM LOS_METATECLA.Rol");
            conexion.ejecutarQuery();
            if (conexion.lector.HasRows)
            {
                while (conexion.lector.Read())
                {
                    Rol rol = new Rol((int)(decimal)conexion.lector["Id_Rol"], (string)conexion.lector["Nombre"], (bool)conexion.lector["Habilitado"]);
                    roles.Add(rol);
                }
            }
            conexion.cerrarConexion();
            return roles;
        }
    
        public int AgregarRol(string nombre,bool estado,List<Funcionalidad> funcionalidadesRol){ //No se si esta bien hecho el tema de ejecutarStoredProcedure
            List<SqlParameter> ListParam = new List<SqlParameter>();
            int respuesta = -1;
            //1. Primero agrego a la tabla de roles
            ListParam.Add(new SqlParameter("@nombre", nombre));
            ListParam.Add(new SqlParameter("@estado", estado));
            respuesta = (int)Conexion.ejecutarStoredProcedure("LOS_METATECLA.AgregarNuevoRol", ListParam);
            //2. Verifico que se haya agregado
            if(respuesta != -1) {
            //3. Agrego a Funcionalidades_Rol todas las funcionalidades de este rol
                FuncionalidadDB DBFuncionalidad = new FuncionalidadDB();
                foreach (Funcionalidad funcionalidad in funcionalidadesRol)
                    {
                        DBFuncionalidad.AgregarFuncionalidadDelRol(respuesta, funcionalidad);
                    } return 1;
            }
            return 0;
        }

    
    
    }
}
