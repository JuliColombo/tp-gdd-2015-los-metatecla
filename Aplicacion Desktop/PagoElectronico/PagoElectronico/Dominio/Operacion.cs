using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Dominio
{
    public class Operacion
    {
        public double importe { get; set; }
        public double codigo { get; set; }
        public DateTime fecha { get; set; }
        public int moneda { get; set; }
    }
}
