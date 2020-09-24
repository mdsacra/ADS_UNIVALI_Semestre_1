using System;
using System.Collections.Generic;
using System.Text;

namespace Adventures.Model.DAL
{
    class ClienteDataStore
    {
        AdventuresContext context = new AdventuresContext();

        public void AddCliente(Cliente cliente)
        {
            context.Clientes.Add(cliente);
            context.SaveChanges();
        }
    }
}
