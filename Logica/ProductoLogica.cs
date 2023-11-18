using Datos;
using Entidades;
using System.Collections.Generic;

namespace Logica
{
    public class ProductoLogica
    {
        private ProductoConsulta productoConsulta;

        public ProductoLogica()
        {
            productoConsulta = new ProductoConsulta();
        }

        public List<Producto> BuscarProductosPorDescripcion(string descripcion)
        {
            return productoConsulta.BuscarPorDescripcion(descripcion);
        }

        public List<Producto> ObtenerProductos()
        {
            return productoConsulta.ObtenerProductos();
        }

        public void AgregarProducto(Producto nuevoProducto)
        {
            productoConsulta.AgregarProducto(nuevoProducto);
        }

        public bool EditarProducto(Producto producto)
        {
            return productoConsulta.EditarProducto(producto);
        }

        public bool EliminarProducto(int idProducto)
        {
            return productoConsulta.EliminarProducto(idProducto);
        }
    }
}
