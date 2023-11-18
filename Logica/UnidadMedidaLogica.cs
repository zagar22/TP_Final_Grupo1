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
            return unidadMedidaConsulta.EliminarUnidadDeMedida(idUnidadMedida);
        }
    }
}
