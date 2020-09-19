using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace Controller
{
    interface IPacoteView
    {
        void SetController(PacoteController pacoteController);
        void AddPacote(Pacote pacote);
        void RemovePacote(Pacote pacote);
        void AtualizarPacote(Pacote pacote);
   
    }
}
