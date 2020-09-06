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
        void SetController(ColaboradorController colaboradorController);
        void AddColaborador(Colaborador colaborador);
        void RemoveColaborador(Colaborador colaborador);

        int id { get; set; }
        string nome { get; set; }
        Departamento dpto  { get; set; }
        string cpf { get; set; }
        Double salario { get; set; }
        DateTime dtAdmissao { get; set; }


    }
}
