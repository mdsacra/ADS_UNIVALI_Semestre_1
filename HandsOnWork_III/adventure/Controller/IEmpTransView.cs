using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    interface IEmpTransView
    {
        void SetController(EmpTransController emptransController);
        void AddEmpTrans(EmpTrans emp);
        void RemoveEmpTrans(EmpTrans emp);
        void AtualiarEmpTrans(EmpTrans emp);

        int id { get; set; }
        string razaoSocial { get; set; }
        string nomeFantasia { get; set; }
        string cnpj { get; set; }
        TipoTransporte tipoTransp { get; set; }
        ResponsavelEmpresa responsavel { get; set; }
    }
}
