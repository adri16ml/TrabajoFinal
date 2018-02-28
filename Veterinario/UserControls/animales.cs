using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Veterinario.UserControls
{
    public partial class animales : UserControl
    {
        public animales()
        {
            InitializeComponent();
        }
        DataSet ds;

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvBuscar.DataSource = MascotaReg.Buscar(txtNombre.Text, txtChip.Text);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            BDcon.ObtenerConexion();
            MySqlCommand com = new MySqlCommand("Select * from Mascota", BDcon.ObtenerConexion());

            MySqlDataAdapter con = new MySqlDataAdapter(com);
            ds = new DataSet();
            con.Fill(ds);

            dgvBuscar.DataSource = ds.Tables[0];

        }
    }
}
