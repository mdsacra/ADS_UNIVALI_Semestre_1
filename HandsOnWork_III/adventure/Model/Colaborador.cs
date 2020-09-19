using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Colaborador
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public Departamento Dpto { get; set; }
        public Double Salario { get; set; }
        public DateTime DtAdmissao { get; set; }

    }
}
