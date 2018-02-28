using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinario
{
    class Visita
    {
       
            public string Chip { get; set; }
            public string Dni_propietario { get; set; }
            public string Dni_usuario { get; set; }
            public string Consulta { get; set; }
            public string Fecha_visita { get; set; }

            public Visita() { }

            public Visita(string pChip, string pDni_propietario, String pDni_usuario, String pConsulta, string pFecha_visita)
            {
                this.Chip = pChip;
                this.Dni_propietario = pDni_propietario;
                this.Dni_usuario = pDni_usuario;
                this.Consulta = pConsulta;
                this.Fecha_visita = pFecha_visita;
            }
        }
    }

