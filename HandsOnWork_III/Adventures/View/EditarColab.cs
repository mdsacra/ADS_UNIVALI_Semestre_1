using Adventures.Controller;
using Adventures.Model;
using Adventures.Model.Enum;
using Adventures.Uteis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Adventures.View
{
    public partial class EditarColab : Form
    {
        public EditarColab()
        {
            InitializeComponent();
            editDptoColab.DataSource = EnumToList<Departamento>.Listar();
        }

        public EditarColab(Colaborador colaborador) : this()
        {
            _colaborador = colaborador;
            editNomeColab.Text = colaborador.Nome;
            editEmailColab.Text = colaborador.Email;
            editDptoColab.SelectedItem = colaborador.Dpto;
            editFoneColab.Text = colaborador.Fone;
            editSalColab.Text = colaborador.Salario.ToString();
            editDptoColab.SelectedItem = colaborador.Dpto;
        }

        private readonly Colaborador _colaborador;
        private ColaboradorController controllerColab = new ColaboradorController();

        private void salvarAltColab_Click(object sender, EventArgs e)
        {
            Colaborador editColab = new Colaborador()
            {
                Id = _colaborador.Id,
                Nome = editNomeColab.Text,
                Email = editEmailColab.Text,
                Dpto = (Departamento)editDptoColab.SelectedItem,
                Fone = editFoneColab.Text,
                Salario = Convert.ToDouble(editSalColab.Text),
                DataAdmissao = _colaborador.DataAdmissao
            };

            controllerColab.EditarColaborador(editColab);

            Close();

            CadastroColaborador cadColab = new CadastroColaborador();
            cadColab.ShowDialog();
        }
    }
}
