using System;
using System.Collections.Generic;
using System.Text;

namespace Adventures.Model
{
    public class PacoteCliente
    {
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int PacoteId { get; set; }
        public Pacote Pacote { get; set; }


    }
}
