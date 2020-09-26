using Adventures.Controller;
using Adventures.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventures.View
{
    public partial class CadastroPacote : Form
    {
        public CadastroPacote()
        {
            InitializeComponent();
            empPacote.DataSource = empTransController.ListarEmpresas();

        }

        EmpTransController empTransController = new EmpTransController();
        PacoteController pacoteController = new PacoteController();


        private void cadastrarPacote_Click_1(object sender, EventArgs e)
        {

            EmpTrans emp = (EmpTrans)empPacote.SelectedItem;

            int empId = emp.Id;

            Pacote pacote = new Pacote()
            {
                Cidade = cidadePacote.Text,
                Pais = paisPacote.Text,
                Hotel = hotelPacote.Text,
                VlrEstadia = Convert.ToDouble(vlrEstadiaPacote.Text),
                VlrTransporte = Convert.ToDouble(vlrTransPacote.Text),
                DtPartida = dataPartida.Value,
                DtRetorno = dataRetorno.Value,
                EmpresaId = empId,
                AllInclusive = allInclusive.Checked ? true : false
            };

            pacoteController.CadastrarPacote(pacote);

            Close();
        }

        private void cadEmpTrans_Click(object sender, EventArgs e)
        {

            using (var empTrans = new CadastroEmpTrans()){
                empTrans.ShowDialog();
            }


            while(Application.OpenForms.OfType<CadastroEmpTrans>().Count() > 0)
            {
                continue;
            }

            empPacote.DataSource = empTransController.ListarEmpresas();
        }

    }
}
