using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Veterinario
{
    class MascotaReg
    {
        public static int Agregar(Mascota pMascota)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into Mascota (Nombre, Chip, fecha_nacimiento, Propietario) values ('{0}','{1}','{2}','{3}')",
                pMascota.Nombre, pMascota.Chip, pMascota.Fecha_Nac, pMascota.Propietario), BDcon.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static List<Mascota> Buscar(string pNombre, string pChip)
        {
            List<Mascota> _lista = new List<Mascota>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
            "SELECT Nombre, Chip, fecha_nacimiento, Propietario, FROM Mascota where Chip ='{1}' or Nombre='{0}'", pNombre, pChip), BDcon.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Mascota pMascota = new Mascota();
                pMascota.Nombre = _reader.GetString(0);
                pMascota.Chip = _reader.GetString(1);
                pMascota.Fecha_Nac = _reader.GetString(2);
                pMascota.Propietario = _reader.GetString(3);
               

                _lista.Add(pMascota);
            }

            return _lista;
        }

    }
}

