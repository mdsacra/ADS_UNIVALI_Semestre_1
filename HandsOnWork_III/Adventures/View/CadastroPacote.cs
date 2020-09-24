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
    public partial class CadastroPacote : Form
    {
        public CadastroPacote()
        {
            InitializeComponent();
        }

        PacoteController pacoteController = new PacoteController();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Pacote pacote = new Pacote()
            {
                Cidade = cidadePacote.Text,
                Pais = paisPacote.Text,
                Hotel = hotelPacote.Text,
                VlrEstadia = Convert.ToDouble(vlrEstadiaPacote.Text),
                VlrTransporte = Convert.ToDouble(vlrTransPacote.Text),
                DtPartida = dataPartida.Value,
                DtRetorno = dataRetorno.Value,
                Empresa = null,
                AllInclusive = false
            };

            pacoteController.CadastrarPacote(pacote);
        }
    }
}
