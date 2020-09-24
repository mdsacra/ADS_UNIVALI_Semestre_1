using Adventures.Model.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adventures.Model
{
    public class Colaborador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Fone { get; set; }
        public string Email { get; set; }
        public Double Salario { get; set; }
        public Departamento Dpto { get; set; }
        public DateTime DataAdmissao { get; set; } = DateTime.Now;

    }
}
