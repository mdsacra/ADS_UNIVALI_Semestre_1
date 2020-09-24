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

        internal List<Pacote> ListarPacotes()
        {
            return context.Pacotes.ToList();
        }
    }
}
