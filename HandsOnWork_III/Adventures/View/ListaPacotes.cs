using Adventures.Controller;
using Adventures.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace Adventures.View
{
    public partial class ListaPacotes : Form
    {
        public ListaPacotes()
        {
            InitializeComponent();
        }

        PacoteController pacoteController = new PacoteController();

        private void ListaPacotes_Load(object sender, EventArgs e)
        {
            

        }


        private void ListarPacotes()
        {
            List<Pacote> pacotes = pacoteController.Listar();

            foreach (Pacote p in pacotes)
            {
                Button btn = new Button()
                {
                    Text = p.Cidade + " - " + p.Pais + ", de " + p.DtPartida.Date + " a " + p.DtRetorno.Date,
                    Size = new Size(400, 100),
                    Location = new Point(40, 40)
                };


                this.Controls.Add(btn);
            }
        }

        private void AbrirDetalhes(object sender, EventArgs e)
        {

            Form form = new Form();

        }
        
    }
}
