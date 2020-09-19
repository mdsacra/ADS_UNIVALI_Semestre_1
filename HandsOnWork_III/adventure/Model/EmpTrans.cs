using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EmpTrans
    {
        [Key]
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public TipoTransporte TipoTransp { get; set; }
        public ResponsavelEmpresa Responsavel { get; set; }


    }
}
