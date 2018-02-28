using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinario
{
    class Mascota
        {
            public string Nombre { get; set; }
            public string Chip { get; set; }
            public string Fecha_Nac { get; set; }
            public string Propietario { get; set; }


        public Mascota() { }

            public Mascota(string pNombre, String pChip, String pFecha_Nac, string pPropietario)
            {
                this.Nombre = pNombre;            
                this.Chip = pChip;
                this.Fecha_Nac = pFecha_Nac;
                this.Propietario = pPropietario;
            }
        }   
}
