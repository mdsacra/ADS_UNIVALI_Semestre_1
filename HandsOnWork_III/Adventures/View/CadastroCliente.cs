using Adventures.Controller;
using Adventures.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Adventures.View
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        ClienteController clienteController = new ClienteController();

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente()
            {
                Nome = nomeCliente.Text,
                Cpf = cpfCliente.Text,
                Email = emailCliente.Text
            };

            clienteController.CadastrarCliente(cliente);
        }
    }
}
