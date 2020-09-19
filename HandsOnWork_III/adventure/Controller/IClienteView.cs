using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    interface IClienteView
    {
        void SetController(ClienteController clienteController);
        void addCliente(Cliente cliente);
        void removeCliente(Cliente cliente);
        void atualizarCliente(Cliente cliente);

      
    }
}
