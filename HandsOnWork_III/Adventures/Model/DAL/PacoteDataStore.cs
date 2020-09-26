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
            return context.Pacotes
                .FirstOrDefault(p => p.Id == id)
                .Clientes.Select(c => c.Cliente)
                .ToList();
        }

    }
}
