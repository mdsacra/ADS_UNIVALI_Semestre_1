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
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
            dataGridView1.DataSource = _controller.Listar();
        }

        readonly PacoteController _controller = new PacoteController();

        private void cadPacote_Click(object sender, EventArgs e)
        {
            CadastroPacote cadPacote = new CadastroPacote();

            cadPacote.ShowDialog();
        }

        private void cadColab_Click(object sender, EventArgs e)
        {
            CadastroColaborador cadColab = new CadastroColaborador();

            cadColab.ShowDialog();
        }

        private void vender_Click(object sender, EventArgs e)
        {
            Pacote selecPacote = dataGridView1.CurrentRow.DataBoundItem as Pacote;

            using(var insCli = new InserirCliente(selecPacote))
            {
                insCli.ShowDialog();
            }
        }
    }
}
