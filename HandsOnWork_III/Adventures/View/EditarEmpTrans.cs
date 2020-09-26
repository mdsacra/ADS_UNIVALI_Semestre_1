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
    public partial class EditarEmpTrans : Form
    {

        private readonly EmpTransController _controller = new EmpTransController();
        private readonly EmpTrans _empTrans;
        public EditarEmpTrans()
        {
            InitializeComponent();
            editTipoEmpTrans.DataSource = EnumToList<TipoTransporte>.Listar();
        }

        public EditarEmpTrans(EmpTrans empTrans) : this()
        {
            _empTrans = empTrans;
            editNomeEmpTrans.Text = empTrans.Nome;
            editCnpjEmpTrans.Text = empTrans.Cnpj;
            editTipoEmpTrans.SelectedItem = empTrans.Tipo;
            editRespEmpTrans.Text = empTrans.Responsavel.Nome;
            editCpfRespEmpTrans.Text = empTrans.Responsavel.Cpf;

        }

        private void salvarAltEmpTrans_Click(object sender, EventArgs e)
        {
            if (!editRespEmpTrans.Text.Equals(_empTrans.Responsavel.Nome) || !editCpfRespEmpTrans.Text.Equals(_empTrans.Responsavel.Cpf))
            {

                RespEmpresa resp = new RespEmpresa()
                {
                    Nome = editRespEmpTrans.Text,
                    Cpf = editCpfRespEmpTrans.Text
                };

                _empTrans.Responsavel = resp;
            }

            EmpTrans editEmpTrans = new EmpTrans()
            {
                Id = _empTrans.Id,
                Nome = editNomeEmpTrans.Text,
                Cnpj = editCnpjEmpTrans.Text,
                Tipo = (TipoTransporte)editTipoEmpTrans.SelectedItem,
                Responsavel = _empTrans.Responsavel
            };

            _controller.EditarEmpTrans(editEmpTrans);

            Close();

            CadastroEmpTrans cadEmp = new CadastroEmpTrans();

            cadEmp.ShowDialog();
        }
    }
}
