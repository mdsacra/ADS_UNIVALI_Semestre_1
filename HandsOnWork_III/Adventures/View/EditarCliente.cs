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
    public partial class EditarCliente : Form
    {
        public EditarCliente()
        {
            InitializeComponent();
        }

        public int Id { get; set; }
        
        public string AltNome
        {
            get { return editNomeCliente.Text; }
            set { editNomeCliente.Text = value; }
        }

        public string AltCpf
        {
            get { return editCpfCliente.Text; }
            set { editCpfCliente.Text = value; }
        }
        public string AltEmail
        {
            get { return editEmailCliente.Text; }
            set { editEmailCliente.Text = value; }
        }

        public DateTime AltDtCad { get; set; }
        

        private void salvarAltClientes_Click(object sender, EventArgs e)
        {
            ClienteController clienteController = new ClienteController();

            Cliente cliente = new Cliente()
            {
                Id = Id,
                Nome = AltNome,
                Cpf = AltCpf,
                Email = AltEmail,
                DataCadastro = AltDtCad
            };

            clienteController.EditarCliente(cliente);

            Close();

            CadastroCliente cadastroCliente = new CadastroCliente();
            cadastroCliente.ShowDialog();
        }
    }
}
