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
    public partial class CadastroEmpTrans : Form
    {
        public CadastroEmpTrans()
        {
            InitializeComponent();
            tipoEmpresa.DataSource = EnumToList<TipoTransporte>.Listar();
        }

        EmpTransController empTransController = new EmpTransController();
        
        private void CadastroEmpTrans_Load(object sender, EventArgs e)
        {
            ReciclarTela();
            
        }

        
        private void cadastrarEmpresa_Click(object sender, EventArgs e)
        {

            RespEmpresa responsavel = new RespEmpresa()
            {
                Nome = respEmpresa.Text,
                Cpf = cpfRespEmp.Text
            };

            EmpTrans empresa = new EmpTrans()
            {
                Nome = nomeEmpresa.Text,
                Cnpj = cnpjEmpresa.Text,
                Responsavel = responsavel,
                Tipo = (TipoTransporte) tipoEmpresa.SelectedItem,
            };
            
            empTransController.CadastrarEmpTrans(empresa);

            ReciclarTela();
        }

        private void removerEmpresa_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;

            empTransController.RemoverEmpTrans(id);

            ReciclarTela();
        }

        private void editarEmpresa_Click(object sender, EventArgs e)
        {
            EmpTrans empresa = dataGridView1.CurrentRow.DataBoundItem as EmpTrans;

            using(var editEmp = new EditarEmpTrans(empresa))
            {
                editEmp.ShowDialog();
            }

            Close();

        }

        private void ReciclarTela()
        {
            dataGridView1.DataSource = empTransController.ListarEmpresas();
            nomeEmpresa.Text = "";
            cnpjEmpresa.Text = "";
            respEmpresa.Text = "";
            cpfRespEmp.Text = "";
        }
    }
}
