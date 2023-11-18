using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
    public class ProductoConsulta
    {
        private ConexionMySql conexionMysql;

        public ProductoConsulta()
        {
            conexionMysql = new ConexionMySql();
        }

        public List<Producto> BuscarPorDescripcion(string descripcion)
        {
            List<Producto> productos = new List<Producto>();

            MySqlConnection connection = conexionMysql.GetConexion();
            string query = "SELECT IdProducto, Descripcion, IdUnidadDeMedida, ValorUnitario, Habilitado FROM producto WHERE Descripcion LIKE @descripcion";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@descripcion", "%" + descripcion + "%");

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Producto producto = new Producto
                        {
                            IdProducto = Convert.ToInt32(reader["IdProducto"]),
                            Descripcion = reader["Descripcion"].ToString(),
                            IdUnidadDeMedida = Convert.ToInt32(reader["IdUnidadDeMedida"]),
                            ValorUnitario = Convert.ToDouble(reader["ValorUnitario"]),
                            Habilitado = Convert.ToInt32(reader["Habilitado"])
                        };

                        productos.Add(producto);
                    }
                }
            } // La conexión se cierra automáticamente al salir del bloque using

            return productos;
        }

        public List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();

            MySqlConnection connection = conexionMysql.GetConexion();
            string query = "SELECT IdProducto, Descripcion, IdUnidadDeMedida, ValorUnitario, Habilitado FROM producto";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Producto producto = new Producto
                        {
                            IdProducto = Convert.ToInt32(reader["IdProducto"]),
                            Descripcion = reader["Descripcion"].ToString(),
                            IdUnidadDeMedida = Convert.ToInt32(reader["IdUnidadDeMedida"]),
                            ValorUnitario = Convert.ToDouble(reader["ValorUnitario"]),
                            Habilitado = Convert.ToInt32(reader["Habilitado"])
                        };

                        productos.Add(producto);
                    }
                }
            } // La conexión se cierra automáticamente al salir del bloque using

            return productos;
        }

        public void AgregarProducto(Producto nuevoProducto)
        {
            MySqlConnection connection = conexionMysql.GetConexion();
            string query = "INSERT INTO producto (Descripcion, IdUnidadDeMedida, ValorUnitario, Habilitado) " +
                           "VALUES (@descripcion, @idUnidadDeMedida, @valorUnitario, @habilitado)";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@descripcion", nuevoProducto.Descripcion);
                cmd.Parameters.AddWithValue("@idUnidadDeMedida", nuevoProducto.IdUnidadDeMedida);
                cmd.Parameters.AddWithValue("@valorUnitario", nuevoProducto.ValorUnitario);
                cmd.Parameters.AddWithValue("@habilitado", nuevoProducto.Habilitado);

                cmd.ExecuteNonQuery();
            }
        }

        public bool EditarProducto(Producto producto)
        {
            MySqlConnection connection = conexionMysql.GetConexion();
            string query = "UPDATE producto SET Descripcion = @descripcion, IdUnidadDeMedida = @idUnidadDeMedida, " +
                           "ValorUnitario = @valorUnitario, Habilitado = @habilitado WHERE IdProducto = @idProducto";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                cmd.Parameters.AddWithValue("@idUnidadDeMedida", producto.IdUnidadDeMedida);
                cmd.Parameters.AddWithValue("@valorUnitario", producto.ValorUnitario);
                cmd.Parameters.AddWithValue("@habilitado", producto.Habilitado);
                cmd.Parameters.AddWithValue("@idProducto", producto.IdProducto);

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }

        public bool EliminarProducto(int idProducto)
        {
            MySqlConnection connection = conexionMysql.GetConexion();
            string query = "DELETE FROM producto WHERE IdProducto = @idProducto";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@idProducto", idProducto);

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }

    }
}
