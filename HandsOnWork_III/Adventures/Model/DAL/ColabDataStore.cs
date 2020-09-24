﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adventures.Model.DAL
{
    class ColabDataStore
    {

        AdventuresContext context = new AdventuresContext();

        public List<Colaborador> BuscarColabs()
        {
            return context.Colaboradores.ToList();
        }

        public void AddColab(Colaborador colaborador)
        {
            context.Colaboradores.Add(colaborador);

            context.SaveChanges();
        }

        public void RemoverColab(int id)
        {
            Colaborador colaborador = context.Colaboradores.FirstOrDefault(c => c.Id == id);
            context.Colaboradores.Remove(colaborador);
            context.SaveChanges();
        }
    }
}
