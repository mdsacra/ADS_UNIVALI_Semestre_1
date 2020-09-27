using Adventures.Model;
using Adventures.Model.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adventures.Controller
{
    public class PacoteClienteController
    {

        PacoteClienteDataStore paclids = new PacoteClienteDataStore();

        public void InserirClientePacote(PacoteCliente pacli)
        {
            paclids.AddClientePacote(pacli);
        }

        public void RemoverClientePacote(int clienteId, int pacoteId)
        {
            paclids.RemoverClientePacote(clienteId, pacoteId);
        }

        public List<Cliente> ListarClientesPacote(int pacoteId)
        {
            return paclids.ListarClientesPacote(pacoteId);
        }
    }

}
