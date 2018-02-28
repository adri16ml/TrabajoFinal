using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Veterinario
{
    class ClientesReg
    {
        public static int Agregar(cliente pCliente)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into Clientes (Nombre, Apellido, Fecha_registro, Dni) values ('{0}','{1}','{2}', '{3}')",
                pCliente.Nombre, pCliente.Apellido, pCliente.Fecha_registro, pCliente.Dni), BDcon.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static List<cliente> Buscar(string pNombre, string pDni)
        {
            List<cliente> _lista = new List<cliente>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT Nombre, Dni, Apellido, Fecha_registro FROM clientes  where Nombre ='{0}' or Dni='{1}'", pNombre, pDni), BDcon.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                cliente pCliente = new cliente();
                pCliente.Nombre = _reader.GetString(0);
                pCliente.Dni = _reader.GetString(1);
                pCliente.Apellido = _reader.GetString(2);
                pCliente.Fecha_registro = _reader.GetString(3);
               


                _lista.Add(pCliente);
            }

            return _lista;
        }

    }
    }
