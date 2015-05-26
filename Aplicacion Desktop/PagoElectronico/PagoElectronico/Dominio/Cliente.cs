using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Dominio
{
    class Cliente
    {
        public String nombre { get; set; }
        public String apellido { get; set; }
        public double tipo_doc { get; set; }
        public int documento { get; set; }
        public int domicilio { get; set; }
        public double pais { get; set; } //Fijarse si conviene que sea una clase aparte
        public String mail { get; set; }
        public DateTime fecha_nac { get; set; }
    }
}
