using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Dominio
{
    class Banco
    {
        public double codigo { set; get; }
        public String nombre {set; get;}
        public String direccion { set; get; }

        public Banco(double codigo, string nombre, string direccion) {
            this.codigo = codigo;
            this.direccion = direccion;
            this.nombre = nombre;
        }
    }
}
