using Datos; 
using Entidades;
using System.Collections.Generic;

namespace Logica
{
    public class ClienteLogica
    {
        private ClienteConsulta clienteConsulta;

        public ClienteLogica()
        {
            clienteConsulta = new ClienteConsulta();
        }

        public List<Cliente> BuscarClientePorRazonSocial(string razonSocial)
        {            
            return clienteConsulta.BuscarPorRazonSocial(razonSocial);
        }

        public List<Cliente> ObtenerClientes()
        {
            return clienteConsulta.ObtenerClientes();
        }
        public bool AgregarCliente(Cliente cliente)
        {
            return clienteConsulta.AgregarCliente(cliente);
        }

        public bool EditarCliente(Cliente cliente)
        {
            return clienteConsulta.EditarCliente(cliente);
        }

        public bool EliminarCliente(int idCliente)
        {
            return clienteConsulta.EliminarCliente(idCliente);
        }
    }
}
