using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adventures.Model.DAL
{
    class PacoteDataStore
    {

        AdventuresContext context = new AdventuresContext();

        public void AddPacote(Pacote pacote)
        {
            context.Pacotes.Add(pacote);
            context.SaveChanges();
        }

        public List<Pacote> ListarPacotes()
        {
            return context.Pacotes.Include(p => p.Empresa).ToList();
        }

        public List<Cliente> ListarClientes(int id)
        {

            Pacote pacote = context.Pacotes
                .Include(p => p.Clientes)
                .ThenInclude(pc => pc.Cliente)
                .FirstOrDefault(p => p.Id == id);

            List<Cliente> clientes = pacote.Clientes.Select(pc => pc.Cliente).ToList();

            return clientes;
        }

        public void RemoverPacote(int id)
        {
            context.Pacotes.Remove(context.Pacotes.Find(id));
            context.SaveChanges();
        }

    }
}
