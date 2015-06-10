using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Dominio
{
    class Tarjeta
    {
        public string numero { get; set; }
        public int emisor { get; set; }
        public int cliente { get; set; }
        public string fecha_emision { get; set; }
        public string fecha_vencimiento { get; set; }
        public string codigo_seguridad { get; set; }
    }
}
