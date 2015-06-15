using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Dominio
{
   public class Costos
    {
        public double costoTrans;
        public double costoApertura;
        public double costoModificacion;


        public Costos(double trans, double aper, double mod)
        {
            this.costoApertura = aper;
            this.costoModificacion = mod;
            this.costoTrans = trans;
        }

    }
}
