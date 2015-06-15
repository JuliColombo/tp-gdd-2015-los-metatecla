using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Dominio
{
    public class Cuenta
    {
        public long numero { get; set; }
        public DateTime fecha_creacion { get; set; }
        public int estado { get; set; }
        public int pais { get; set; } //Devuelta lo mismo, fijarse si conviene que sea una clase aparte
        public DateTime fecha_cierre {get; set;} //esto tiene que ver con el tema de los tipos de la cuenta (seria una forma de poder calcularlo), posiblemente este demas
        public int tipo { set; get; } //Fijarse implementacion de los tipos
        //public Cliente dueño {get; set;} //Es unico el dueño de la cuenta, si no seria una lista
        public double saldo { get; set; }
        public int idPropietario { get; set; }
    }
}
