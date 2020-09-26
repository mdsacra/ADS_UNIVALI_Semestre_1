using Adventures.Model.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adventures.Model
{
    public class EmpTrans
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public TipoTransporte Tipo { get; set; }
        public RespEmpresa Responsavel { get; set; }
        public int ResponsavelId { get; set; }
        public List<Pacote> Pacotes { get; set; }


        public override string ToString()
        {
            return this.Nome + " | " + this.Tipo;
        }

    }
}
