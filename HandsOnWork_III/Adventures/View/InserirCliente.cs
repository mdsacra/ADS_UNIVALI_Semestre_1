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
    public partial class InserirCliente : Form
    {
        public InserirCliente()
        {
            InitializeComponent();
        }

        public InserirCliente(Pacote pacote) : this()
        {
            _pacote = pacote;
            

        }

        readonly Pacote _pacote;
        readonly ClienteController _clienteController = new ClienteController();
        readonly PacoteClienteController _pacliController = new PacoteClienteController();

        private void InserirCliente_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _clienteController.ListarClientes();
        }

        private void salvarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = dataGridView1.CurrentRow.DataBoundItem as Cliente;

            PacoteCliente pacoteCliente = new PacoteCliente()
            {
                ClienteId = cliente.Id,
                PacoteId = _pacote.Id
            };

            _pacliController.InserirClientePacote(pacoteCliente);
            MessageBox.Show("Cliente inserido com sucesso!");
            
        }

        private void novoCliente_Click(object sender, EventArgs e)
        {
            using(var cadCli = new CadastroCliente())
            {
                cadCli.ShowDialog();
            }

            Close();
            
        }
    }
}
