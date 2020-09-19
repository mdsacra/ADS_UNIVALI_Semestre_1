using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ColaboradorController
    {
        IColabView _view;
        IList _colaboradores;
        Colaborador Colaborador;

        public ColaboradorController(IColabView view, IList colaboradores)
        {
            _view = view;
            _colaboradores = colaboradores;
            view.SetController(this);
        }

        public IList Users
        {
            get { return ArrayList.ReadOnly(_colaboradores); }
        }


    }
}
