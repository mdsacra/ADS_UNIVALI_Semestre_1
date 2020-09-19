using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pacote
    {

        [Key]
        public int Id { get; set; }
        public string Cidade { get; set; }
        public string Pais { get; set; }
        public string Hotel { get; set; }
        public DateTime DtPartida { get; set; }
        public DateTime DtRetorno { get; set; }
        public EmpTrans Empresa { get; set; }
        public Double VlrEstadia { get; set; }
        public Double VlrTransporte { get; set; }
        public bool AllInclusive { get; set; }


    }
}
