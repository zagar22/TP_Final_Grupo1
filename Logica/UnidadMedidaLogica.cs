using Datos;
using Entidades;
using System.Collections.Generic;

namespace Logica
{
    public class UnidadMedidaLogica
    {
        private UnidadMedidaConsulta unidadMedidaConsulta;

        public UnidadMedidaLogica()
        {
            unidadMedidaConsulta = new UnidadMedidaConsulta();
        }

        public List<UnidadDeMedida> ObtenerUnidadMedida()
        {

            return unidadMedidaConsulta.ObtenerUnidadesDeMedida();
        }

        public void AgregarUnidadMedida(UnidadDeMedida unidadMedida)
        {

            unidadMedidaConsulta.AgregarUnidadDeMedida(unidadMedida);
        }

        public bool EditarUnidadMedida(UnidadDeMedida unidadMedida)
        {
            return unidadMedidaConsulta.EditarUnidadDeMedida(unidadMedida);
        }

        public bool EliminarUnidadMedida(int idUnidadMedida)
        {
            // Verificar si hay productos asociados a la unidad de medida
            if (unidadMedidaConsulta.TieneProductosAsociados(idUnidadMedida))
            {
                return false;
            }

            // No hay productos asociados, proceder con la eliminación
            return unidadMedidaConsulta.EliminarUnidadDeMedida(idUnidadMedida);
        }

        public string ObtenerDescripcionUnidadMedida(int idUnidadMedida)
        {
            return unidadMedidaConsulta.ObtenerDescripcionUnidadMedida(idUnidadMedida);
        }


    }
}
