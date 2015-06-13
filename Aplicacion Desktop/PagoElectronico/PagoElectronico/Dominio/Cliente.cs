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


        public List<int> ultimos_numeros_tarjetas()
        {
        List<int> numeros = new List<int>();

        foreach (PagoElectronico.Dominio.Tarjeta tarjeta in tarjetas)
           {
            numeros.Add(Convert.ToInt32(tarjeta.ultimos_4_numeros));
           }

        return numeros;
        }

        public PagoElectronico.Dominio.Tarjeta buscar_tarjeta(int ult_num)
        {
            return tarjetas.Find(tarjeta => tarjeta.ultimos_4_numeros == ult_num);
        }

    }

}

