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
    public partial class clientes : UserControl
    {
        public clientes()
        {
            InitializeComponent();

        }
        DataSet ds;
        MySqlDataAdapter sda;
        MySqlCommandBuilder scb;
        DataTable dt;

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvBuscar.DataSource = ClientesReg.Buscar(txtNombre.Text,txtDni.Text);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            BDcon.ObtenerConexion();
            MySqlCommand com = new MySqlCommand("Select * from Clientes", BDcon.ObtenerConexion());

            MySqlDataAdapter con = new MySqlDataAdapter(com);
            ds = new DataSet();
            con.Fill(ds);

            dgvBuscar.DataSource = ds.Tables[0];

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
