using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinario.UserControls
{
    public partial class NuevaVisita : UserControl
    {
        public NuevaVisita()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            {
                Visita pVisitas = new Visita();
                pVisitas.Chip = txtChip.Text.Trim();
                pVisitas.Dni_propietario = txtDniP.Text.Trim();
                pVisitas.Dni_usuario = txtDniU.Text.Trim();
                pVisitas.Fecha_visita = dtpFechaV.Value.Year + "/" + dtpFechaV.Value.Month + "/" + dtpFechaV.Value.Day;
                pVisitas.Consulta = txtConsulta.Text.Trim();

                int resultado = VisitaReg.Agregar(pVisitas);
                if (resultado > 0)
                {
                    MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
