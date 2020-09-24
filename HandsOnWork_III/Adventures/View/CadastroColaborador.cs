using Adventures.Controller;
using Adventures.Model;
using Adventures.Model.DAL;
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
    public partial class CadastroColaborador : Form
    {

        private ColaboradorController controller = new ColaboradorController();
        public CadastroColaborador()
        {
            InitializeComponent();
        }


        private void CadastroColaborador_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.BuscarColaboradores();
            comboBox1.DataSource = EnumToList<Departamento>.Listar();
        }

        private void cadastraColab_Click(object sender, EventArgs e)
        {
            Colaborador colaborador = new Colaborador()
            {
                Nome = colabNome.Text,
                Fone = colabFone.Text,
                Email = colabEmail.Text,
                Dpto = (Departamento) comboBox1.SelectedItem,
                Salario = Convert.ToDouble(colabSalario.Text)
            };

            controller.AdicionarColaborador(colaborador);
        }

        private void removeColab_click(object sender, EventArgs e)
        {
            int id = dataGridView1.CurrentRow.Index + 1;

            controller.RemoverColaborador(id);
        }

        
    }
}
