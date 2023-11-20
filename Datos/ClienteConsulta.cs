using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
    public class ClienteConsulta
    {
        private ConexionMySql conexionMysql;

        public ClienteConsulta()
        {
            conexionMysql = new ConexionMySql();
        }

        public List<Cliente> BuscarPorRazonSocial(string razonSocial)
        {
            List<Cliente> clientes = new List<Cliente>();

            MySqlConnection connection = conexionMysql.GetConexion();
            string query = "SELECT IdCliente, RazonSocial, FechaAlta, FechaBaja, LimiteCredito, idTipoIva FROM cliente WHERE RazonSocial LIKE @razonSocial";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@razonSocial", "%" + razonSocial + "%");

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente
                        {
                            IdCliente = Convert.ToInt32(reader["IdCliente"]),
                            RazonSocial = reader["RazonSocial"].ToString(),
                            FechaAlta = Convert.ToDateTime(reader["FechaAlta"]),
                            FechaBaja = reader["FechaBaja"] is DBNull ? null : (DateTime?)Convert.ToDateTime(reader["FechaBaja"]),
                            LimiteCredito = Convert.ToDouble(reader["LimiteCredito"]),
                            TipoIva = Convert.ToInt32(reader["idTipoIva"])
                        };

                        clientes.Add(cliente);
                    }
                }
            } // La conexión se cierra automáticamente al salir del bloque using
            return clientes;
        }

        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            MySqlConnection connection = conexionMysql.GetConexion();
            string query = "SELECT IdCliente, RazonSocial, FechaAlta, FechaBaja, LimiteCredito, idTipoIva FROM cliente";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente
                        {
                            IdCliente = Convert.ToInt32(reader["IdCliente"]),
                            RazonSocial = reader["RazonSocial"].ToString(),
                            FechaAlta = Convert.ToDateTime(reader["FechaAlta"]),
                            FechaBaja = reader["FechaBaja"] is DBNull ? null : (DateTime?)Convert.ToDateTime(reader["FechaBaja"]),
                            LimiteCredito = Convert.ToDouble(reader["LimiteCredito"]),
                            TipoIva = Convert.ToInt32(reader["idTipoIva"])
                        };

                        clientes.Add(cliente);
                    }
                }
            } // La conexión se cierra automáticamente al salir del bloque using

            return clientes;
        }
        public bool AgregarCliente(Cliente cliente)
        {
            MySqlConnection connection = conexionMysql.GetConexion();
            string query = "INSERT INTO cliente (RazonSocial, FechaAlta, FechaBaja, LimiteCredito, idTipoIva) " +
                           "VALUES (@razonSocial, @fechaAlta, @fechaBaja, @limiteCredito, @tipoIva)";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@razonSocial", cliente.RazonSocial);
                cmd.Parameters.AddWithValue("@fechaAlta", cliente.FechaAlta);
                cmd.Parameters.AddWithValue("@fechaBaja", cliente.FechaBaja);
                cmd.Parameters.AddWithValue("@limiteCredito", cliente.LimiteCredito);
                cmd.Parameters.AddWithValue("@tipoIva", cliente.TipoIva);
                
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool EditarCliente(Cliente cliente)
        {
            MySqlConnection connection = conexionMysql.GetConexion();
            string query = "UPDATE cliente SET RazonSocial = @razonSocial, " +
                           "FechaAlta = @fechaAlta, FechaBaja = @fechaBaja, " +
                           "LimiteCredito = @limiteCredito, idTipoIva = @tipoIva " +
                           "WHERE IdCliente = @idCliente";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@razonSocial", cliente.RazonSocial);
                cmd.Parameters.AddWithValue("@fechaAlta", cliente.FechaAlta);
                cmd.Parameters.AddWithValue("@fechaBaja", cliente.FechaBaja);
                cmd.Parameters.AddWithValue("@limiteCredito", cliente.LimiteCredito);
                cmd.Parameters.AddWithValue("@tipoIva", cliente.TipoIva);
                cmd.Parameters.AddWithValue("@idCliente", cliente.IdCliente);

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }

        public bool EliminarCliente(int idCliente)
        {
            MySqlConnection connection = conexionMysql.GetConexion();
            string query = "DELETE FROM cliente WHERE IdCliente = @idCliente";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@idCliente", idCliente);

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }
    }
}
