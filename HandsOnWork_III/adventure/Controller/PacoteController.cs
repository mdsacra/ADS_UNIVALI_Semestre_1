using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class PacoteController
    {
        IPacoteView _view;
        IList _pacotes;
        Pacote pacote;

        public PacoteController(IPacoteView view, IList pacotes)
        {
            _view = view;
            _pacotes = pacotes;
            view.SetController(this);
        }

        public IList Users
        {
            get { return ArrayList.ReadOnly(_pacotes); }
        }

    }
}
