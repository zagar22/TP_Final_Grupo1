using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;


namespace Datos
{
    public class UnidadMedidaConsulta
    {
        private ConexionMySql conexionMysql;

        public UnidadMedidaConsulta()
        {
            conexionMysql = new ConexionMySql();
        }

        public List<UnidadDeMedida> ObtenerUnidadesDeMedida()
        {
            List<UnidadDeMedida> unidadesDeMedida = new List<UnidadDeMedida>();

            MySqlConnection connection = conexionMysql.GetConexion();
            string query = "SELECT IdUnidadDeMedida, Descripcion, Habilitado FROM unidaddemedida";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        UnidadDeMedida unidadDeMedida = new UnidadDeMedida
                        {
                            IdUnidadDeMedida = Convert.ToInt32(reader["IdUnidadDeMedida"]),
                            Descripcion = reader["Descripcion"].ToString(),
                            Habilitado = Convert.ToInt32(reader["Habilitado"])
                        };

                        unidadesDeMedida.Add(unidadDeMedida);
                    }
                }
            } // La conexión se cierra automáticamente al salir del bloque using

            return unidadesDeMedida;
        }

        public void AgregarUnidadDeMedida(UnidadDeMedida nuevaUnidadDeMedida)
        {
            MySqlConnection connection = conexionMysql.GetConexion();
            string query = "INSERT INTO unidaddemedida (Descripcion, Habilitado) VALUES (@descripcion, @habilitado)";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@descripcion", nuevaUnidadDeMedida.Descripcion);
                cmd.Parameters.AddWithValue("@habilitado", nuevaUnidadDeMedida.Habilitado);

                cmd.ExecuteNonQuery();
            }
        }

        public bool EditarUnidadDeMedida(UnidadDeMedida unidadDeMedida)
        {
            MySqlConnection connection = conexionMysql.GetConexion();
            string query = "UPDATE unidaddemedida SET Descripcion = @descripcion, Habilitado = @habilitado WHERE IdUnidadDeMedida = @idUnidadDeMedida";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@descripcion", unidadDeMedida.Descripcion);
                cmd.Parameters.AddWithValue("@habilitado", unidadDeMedida.Habilitado);
                cmd.Parameters.AddWithValue("@idUnidadDeMedida", unidadDeMedida.IdUnidadDeMedida);

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }

        public bool EliminarUnidadDeMedida(int idUnidadDeMedida)
        {
            MySqlConnection connection = conexionMysql.GetConexion();
            string query = "DELETE FROM unidaddemedida WHERE IdUnidadDeMedida = @idUnidadDeMedida";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@idUnidadDeMedida", idUnidadDeMedida);

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }
    }
}
