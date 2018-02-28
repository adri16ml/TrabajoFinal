using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Veterinario
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }


        private void iniciarSesion_Click(object sender, EventArgs e)
        {
            //192.168.1.36 ip casa
            //172.16.3.2 ip uni
            MySqlConnection con = new MySqlConnection("Server = 172.16.3.2; Database = veterinario; Uid = root; Pwd =root;");
            con.Open();

            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection connecta = new MySqlConnection();
            codigo.Connection = con;

            codigo.CommandText = ("select * from usuario where nombre = '"+usuario.Text+"'and pass= '"+password.Text+"' ");

            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
                MessageBox.Show("BIENVENIDO");
                Form2 launcher = new Form2();
                launcher.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("NO SE ENCUENTRA EL USUARIO");
            }
            con.Close();
        }


    }
}
