using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public interface IColabView
    {
        void SetController(ColaboradorController controller);
        void AddColaborador(Colaborador colaborador);
        void RemoveColaborador(Colaborador colaborador);

        int id { get; set; }
        string nome { get; set; }
        DateTime dtNasc { get; set; }
        string cpf { get; set; }
        string email { get; set; }
        DateTime dtCadastro { get; set; }


    }
}
