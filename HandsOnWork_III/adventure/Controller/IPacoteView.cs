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

        int id { get; set; }
        string cidade { get; set; }
        string pais { get; set; }
        string hotel { get; set; }
        DateTime dtPartida { get; set; }
        DateTime dtRetorno { get; set; }
        EmpTrans empresa { get; set; }
        Double vlrEstadia { get; set; }
        Double vlrTransporte { get; set; }
        bool allInclusive { get; set; }
}
}
