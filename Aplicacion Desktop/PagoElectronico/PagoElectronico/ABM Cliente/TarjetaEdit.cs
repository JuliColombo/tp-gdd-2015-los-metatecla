using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.ABM_Cliente
{
    class TarjetaEdit
    {
        public string ultimos4 { get; set; }
        public string emisor { get; set; }
        public string fecha_emision { get; set; }
        public string fecha_vencimiento { get; set; }
    }
}
