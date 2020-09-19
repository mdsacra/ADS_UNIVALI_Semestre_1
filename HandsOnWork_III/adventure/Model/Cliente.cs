﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DtNasc { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public DateTime DtCadastro { get; set; }
    }
}
