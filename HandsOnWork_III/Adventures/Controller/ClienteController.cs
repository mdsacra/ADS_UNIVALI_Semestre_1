using Adventures.Model;
using Adventures.Model.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adventures.Controller
{
    public class ClienteController
    {
        ClienteDataStore clienteDataStore = new ClienteDataStore();

        public List<Cliente> ListarClientes()
        {
            return clienteDataStore.ListarClientes();
        }

        public void CadastrarCliente(Cliente cliente)
        {
            clienteDataStore.AddCliente(cliente);
        }

        public void RemoverCliente(int id)
        {
            clienteDataStore.RemoverCliente(id);
        }

        public void EditarCliente(Cliente cliente)
        {
            clienteDataStore.EditarCliente(cliente);
        }
    }
}
