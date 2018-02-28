using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinario
{
   public class BDcon
    {
        public static MySqlConnection ObtenerConexion()
        {
            // 172.16.3.2 ip uni
            // 192.168.1.36 ip casa
            MySqlConnection conexion = new MySqlConnection("Server = 172.16.3.2; Database = veterinario; Uid = root; Pwd =root;");
            conexion.Open();
            return conexion;
        }
    }
}
