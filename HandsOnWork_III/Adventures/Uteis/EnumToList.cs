using Adventures.Model.Enum;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Adventures.Uteis
{
    public class EnumToList<T>
    {

        public static List<T> Listar()
        {
            List<T> lista = new List<T>();

            Array enumValues = Enum.GetValues(typeof(T));

            foreach(T value in enumValues)
            {
                lista.Add(value);
            }

            return lista;
        }

    }
}
