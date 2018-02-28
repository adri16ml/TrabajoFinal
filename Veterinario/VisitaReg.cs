using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Veterinario
{
    class VisitaReg
    {
        
        public static int Agregar(Visita pVisita)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into Visitas (Chip, Dni_propietario, Dni_usuario, Consulta, Fecha_visita) values ('{0}','{1}','{2}','{3}','{4}')",
                pVisita.Chip, pVisita.Dni_propietario, pVisita.Dni_usuario, pVisita.Consulta, pVisita.Fecha_visita), BDcon.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static List<Visita> Buscar(string pChip, string pDniP)
        {
            List<Visita> _lista = new List<Visita>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT Chip, Dni_propietario, Dni_usuario, Consulta, Fecha_visita FROM Visitas  where Chip ='{0}' or Dni_propietario='{1}'", pChip, pDniP), BDcon.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Visita pVisita = new Visita();
                pVisita.Chip = _reader.GetString(0);
                pVisita.Dni_propietario = _reader.GetString(1);
                pVisita.Dni_usuario = _reader.GetString(2);
                pVisita.Consulta = _reader.GetString(3);
                pVisita.Fecha_visita = _reader.GetString(4);



                _lista.Add(pVisita);
            }

            return _lista;
        }
      
    }
}
