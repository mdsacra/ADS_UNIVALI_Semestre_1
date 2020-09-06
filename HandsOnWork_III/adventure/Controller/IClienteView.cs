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
        void removeClinete(Cliente cliente);
        void atualizarCliente(Cliente cliente);

        int id { get; set; }
        string nome { get; set; }
        string telefone { get; set; }
        DateTime dtNasc { get; set; }
        string cpf { get; set; }
        string email { get; set; }
        DateTime dtCadastro { get; set; }

    }
}
