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
    public partial class ClientesPacote : Form
    {
        public ClientesPacote()
        {
            InitializeComponent();
            
        }

        public ClientesPacote(int pacoteId) : this()
        {
            dataGridView1.DataSource = _pacliController.ListarClientesPacote(pacoteId);
            _pacoteId = pacoteId;
        }

        PacoteClienteController _pacliController = new PacoteClienteController();
        private int _pacoteId;

        private void removerCliente_Click(object sender, EventArgs e)
        {
            int clienteId = (int)dataGridView1.CurrentRow.Cells[0].Value;

            _pacliController.RemoverClientePacote(clienteId, _pacoteId);
            dataGridView1.DataSource = _pacliController.ListarClientesPacote(_pacoteId);

        }
    }
}
