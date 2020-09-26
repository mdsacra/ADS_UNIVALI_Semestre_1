using System;
using System.Collections.Generic;
using System.Text;

namespace Adventures.Model.DAL
{
    public class PacoteClienteDataStore
    {

        AdventuresContext context = new AdventuresContext();


        public void AddClientePacote(PacoteCliente pacoteCliente)
        {
            context.PacoteClientes.Add(pacoteCliente);
            context.SaveChanges();

        }
    }
}
