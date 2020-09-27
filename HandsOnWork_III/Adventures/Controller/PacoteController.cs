using Adventures.Model;
using Adventures.Model.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adventures.Controller
{
    public class PacoteController
    {

        PacoteDataStore pacoteDataStore = new PacoteDataStore();

        public void CadastrarPacote(Pacote pacote)
        {
            pacoteDataStore.AddPacote(pacote);
        }

        internal List<Pacote> Listar()
        {
            return pacoteDataStore.ListarPacotes();
        }

        public void RemoverPacote(int id)
        {
            pacoteDataStore.RemoverPacote(id);
        }
    }
}
