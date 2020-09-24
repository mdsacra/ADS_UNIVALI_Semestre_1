using Adventures.Model;
using Adventures.Model.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adventures.Controller
{
    public class ColaboradorController
    {

        public void AdicionarColaborador(Colaborador colaborador)
        {
            ColabDataStore colabDataStore = new ColabDataStore();

            colabDataStore.AddColab(colaborador);
        }
    }
}
