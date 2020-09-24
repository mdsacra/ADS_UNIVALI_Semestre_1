using Adventures.Model;
using Adventures.Model.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adventures.Controller
{
    public class ColaboradorController
    {

        ColabDataStore colabDataStore = new ColabDataStore();

        public void AdicionarColaborador(Colaborador colaborador)
        {
            colabDataStore.AddColab(colaborador);
        }

        public List<Colaborador> BuscarColaboradores()
        {
            return colabDataStore.BuscarColabs();
        }

        public void RemoverColaborador(int id)
        {
            colabDataStore.RemoverColab(id);
        }
    }
}
