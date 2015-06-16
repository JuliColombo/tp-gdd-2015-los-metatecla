using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Dominio
{
    public class Transferencia
    {
        public double importe { get; set; }
        public long cuenta_destino { get; set; }
        public DateTime fecha { get; set; }
        public int moneda { get; set; }
    }
}
