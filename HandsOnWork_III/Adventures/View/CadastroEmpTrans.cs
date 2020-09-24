using Adventures.Controller;
using Adventures.Model;
using Adventures.Model.Enum;
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
        }

        EmpTransController empTransController = new EmpTransController();
        RespEmpController respEmpController = new RespEmpController();
        
        private void CadastroEmpTrans_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = empTransController.ListarEmpresas();
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
                Responsavel = respEmpController.AdicionarResponsavel(responsavel),
                Tipo = TipoTransporte.Onibus
            };

            empTransController.CadastrarEmpTrans(empresa);
            

        }

        private void removerEmpresa_Click(object sender, EventArgs e)
        {
            int id = dataGridView1.CurrentRow.Index + 1;

            empTransController.RemoverEmpTrans(id);

        }
    }
}
