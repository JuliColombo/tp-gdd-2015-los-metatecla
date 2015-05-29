using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Dominio
{
    public class Funcionalidad
    {
        public int id{ get; set; }
        public string nombre { get; set; }

        public Funcionalidad(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;

        }
    }
}
