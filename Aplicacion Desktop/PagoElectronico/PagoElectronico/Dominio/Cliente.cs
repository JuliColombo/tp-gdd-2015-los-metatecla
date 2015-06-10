using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Dominio
{
    public class Cliente
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public double tipo_doc { get; set; }
        public int documento { get; set; }
        public int domicilio { get; set; }
        public double pais { get; set; }
        public String mail { get; set; }
        public String fecha_nac { get; set; }
        public List<double> numeros_cuentas { get; set; }
        public List<PagoElectronico.Dominio.Tarjeta> tarjetas { get; set; }


        public List<double> numeros_tarjetas()
        {
        List<double> numeros = new List<double>();

        foreach (PagoElectronico.Dominio.Tarjeta tarjeta in tarjetas)
           {
               numeros.Add(Convert.ToDouble(tarjeta.numero));
           }

        return numeros;
        }

    }

}

