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

        public void CadastrarCliente(Cliente cliente)
        {
            clienteDataStore.AddCliente(cliente);
        }
    }
}
