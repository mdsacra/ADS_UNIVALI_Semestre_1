using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class ClienteController
    {

        IClienteView _view;
        IList _clientes;
        Cliente cliente;

        public ClienteController(IClienteView view, IList clientes)
        {
            _view = view;
            _clientes = clientes;
            view.SetController(this);
        }

        public IList Users
        {
            get { return ArrayList.ReadOnly(_clientes); }
        }
    }
}
