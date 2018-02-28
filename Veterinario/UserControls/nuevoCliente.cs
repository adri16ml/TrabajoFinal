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
    public partial class nuevoCliente : UserControl
    {
        public nuevoCliente()
        {
            InitializeComponent();
        }

        private void btnSaveCliente_Click(object sender, EventArgs e)
        {
            {
                cliente pCliente = new cliente();
                pCliente.Nombre = txtNombre.Text.Trim();
                pCliente.Apellido = txtApellido.Text.Trim();
                pCliente.Fecha_registro = dtpFechaR.Value.Year + "/" + dtpFechaR.Value.Month + "/" + dtpFechaR.Value.Day;
                pCliente.Dni = txtDni.Text.Trim();

                int resultado = ClientesReg.Agregar(pCliente);
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
