using System;
using System.Collections.Generic;
using System.Linq;
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

        public void RemoverClientePacote(int clienteId, int pacoteId)
        {
            PacoteCliente pacoteCliente = context.PacoteClientes.Find(clienteId, pacoteId);

            context.PacoteClientes.Remove(pacoteCliente);
            
            context.SaveChanges();

        }

        public List<Cliente> ListarClientesPacote(int id)
        {
            return context.PacoteClientes
                .Where(pc => pc.PacoteId == id)
                .Select(pc => pc.Cliente)
                .ToList();
                
                
        }
    }
}
