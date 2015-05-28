using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Dominio
{
    class Rol
    {
          public int id { get; set; }
          public string nombre { get; set; }
          public bool habilitado { get; set; }
          public string estado { get; set; }
          public List<Funcionalidad> funcionalidades = new List<Funcionalidad>();

        public Rol(int id, string nombre, bool habilitado)
        {
            this.id = id;
            this.nombre = nombre;
            this.habilitado = habilitado;
            if (habilitado) //Es muy turbio pero la es la unica forma de sacar el checkbox del datagrid que encontre
            {
                estado = "Habilitado";
            }
            else {
                estado = "Inhabilidato";
            }
        }
    }
}
