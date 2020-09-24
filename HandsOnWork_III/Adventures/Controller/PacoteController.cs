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
    }
}
