using Adventures.Controller;
using Adventures.Model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Adventures.View
{
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
            dataGridView1.DataSource = _controller.Listar();
        }

        readonly PacoteController _controller = new PacoteController();
        readonly PacoteClienteController _pacliController = new PacoteClienteController();

        private void cadPacote_Click(object sender, EventArgs e)
        {
            CadastroPacote cadPacote = new CadastroPacote();

            cadPacote.ShowDialog();

            AtualizarTela<CadastroPacote>();
        }

        private void cadColab_Click(object sender, EventArgs e)
        {
            CadastroColaborador cadColab = new CadastroColaborador();

            cadColab.ShowDialog();
        }

        private void vender_Click(object sender, EventArgs e)
        {
            Pacote selecPacote = dataGridView1.CurrentRow.DataBoundItem as Pacote;

            InserirCliente insCli = new InserirCliente(selecPacote);
            
            insCli.ShowDialog();
            
        }

        private void AtualizarTela<T>()
        {
            while(Application.OpenForms.OfType<T>().Count() > 0)
            {
                continue;
            }
            dataGridView1.DataSource = _controller.Listar();
        }

        private void removerPacote_Click(object sender, EventArgs e)
        {
            int idPacote = (int)dataGridView1.CurrentRow.Cells[0].Value;

            List<Cliente> clientesPacote = _pacliController.ListarClientesPacote(idPacote);

            if (clientesPacote.Count > 0)
            {
                MessageBox.Show("Este Pacote já possui clientes e não pode ser removido.");
            } else
            {
                _controller.RemoverPacote(idPacote);
                dataGridView1.DataSource = _controller.Listar();
            }


        }

        private void listarClientes_Click(object sender, EventArgs e)
        {
            int pacoteId = (int)dataGridView1.CurrentRow.Cells[0].Value;

            ClientesPacote clipac = new ClientesPacote(pacoteId);
            clipac.ShowDialog();

            
        }
    }
}
