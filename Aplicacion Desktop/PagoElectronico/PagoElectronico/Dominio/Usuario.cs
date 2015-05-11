using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Dominio
{
    class Usuario
    {
        public String username { get; set; }
        public String contraseña { get; set; }
        public Rol rol { get; set; } //Capaz conviene que sea una lista, el enunciado no aclara si puede tener mas de un rol
        public DateTime fecha_creacion { get; set; }
        public DateTime ult_modificacion { get; set; }
        public String preg_secreta { get; set; }
        public String resp_secreta { get; set; }
    }
}
