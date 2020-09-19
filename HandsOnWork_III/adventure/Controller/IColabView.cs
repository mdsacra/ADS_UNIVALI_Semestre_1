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
        void RemoverColaborador(Colaborador colaborador);
        void AtualizarColaborador(Colaborador colaborador);
        

    }
}
