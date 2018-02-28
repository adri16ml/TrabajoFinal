using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinario
{
    class cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Fecha_registro { get; set; }
        public string Dni { get; set; }

        public cliente() { }

        public cliente(string pNombre, string pApellido, String pFecha_registro, String pDni)
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Fecha_registro = pFecha_registro;
            this.Dni = pDni;
        }
    }
}
