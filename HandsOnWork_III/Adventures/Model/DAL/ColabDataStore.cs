using System;
using System.Collections.Generic;
using System.Text;

namespace Adventures.Model.DAL
{
    class ColabDataStore
    {

        AdventuresContext context = new AdventuresContext();


        public void AddColab(Colaborador colaborador)
        {
            context.Colaboradores.Add(colaborador);

            context.SaveChanges();
        }
    }
}
