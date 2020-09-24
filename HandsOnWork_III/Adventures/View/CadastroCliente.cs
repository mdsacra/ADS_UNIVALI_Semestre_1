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

        readonly ClienteController clienteController = new ClienteController();

        
        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clienteController.ListarClientes();
        }

        private void cadastrarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente()
            {
                Nome = nomeCliente.Text,
                Cpf = cpfCliente.Text,
                Email = emailCliente.Text
            };

            clienteController.CadastrarCliente(cliente);
        }

        private void removerCliente_Click(object sender, EventArgs e)
        {
            int id = dataGridView1.CurrentRow.Index + 1;

            clienteController.RemoverCliente(id);
        }

        private void editarCliente_Click(object sender, EventArgs e)
        {

            using (var editCli = new EditarCliente())
            {

                editCli.Id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                editCli.AltNome = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                editCli.AltCpf = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                editCli.AltEmail = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                editCli.AltDtCad = (DateTime)dataGridView1.CurrentRow.Cells[4].Value;
                editCli.ShowDialog();
            }
            






        }
    }
}
