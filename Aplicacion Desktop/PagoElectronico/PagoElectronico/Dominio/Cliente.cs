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
        public String tipo_doc { get; set; }
        public int documento { get; set; }
        public Domicilio domicilio { get; set; }
        public String pais { get; set; } //Fijarse si conviene que sea una clase aparte
        public String mail { get; set; }
        public DateTime fecha_nac { get; set; }
    }
}
