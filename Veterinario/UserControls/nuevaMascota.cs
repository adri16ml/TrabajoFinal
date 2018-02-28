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
    public partial class nuevaMascota : UserControl
    {
        public nuevaMascota()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            {
                Mascota pMascota = new Mascota();
                pMascota.Nombre = txtNombre.Text.Trim();
                pMascota.Chip = txtChip.Text.Trim();
                pMascota.Fecha_Nac = dtpFecha_nac.Value.Year + "/" + dtpFecha_nac.Value.Month + "/" + dtpFecha_nac.Value.Day;
                pMascota.Propietario = txtDnip.Text.Trim();

                int resultado = MascotaReg.Agregar(pMascota);
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
