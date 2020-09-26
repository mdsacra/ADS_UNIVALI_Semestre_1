using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorMoedas
{
    public partial class Form1 : Form
    {
        public double valor { get; set; }

        public Form1()
        {
            InitializeComponent();
            CbMoedaEntrada.DataSource = MoedasEntrada;
            CbMoedaSaida.DataSource = MoedasSaida;

        }

        List<String> MoedasEntrada = new List<string>()
        {
            "Real",
            "Euro",
            "Dólar"
        };

        List<String> MoedasSaida = new List<string>()
        {
            "Real",
            "Euro",
            "Dólar"
        };


        private decimal Dolar(double valor)
        {
            if (CbMoedaSaida.SelectedItem.ToString() == "Real")
            {
                valor *= 5.56;
                return Convert.ToDecimal(valor);
            } else
            {
                valor *= 0.86;
                return Convert.ToDecimal(valor);
            }
        }

        private decimal Euro(double valor)
        {
            if (CbMoedaSaida.SelectedItem.ToString() == "Real")
            {
                valor *= 6.47;
                return Convert.ToDecimal(valor);
            }
            else
            {
                valor *= 1.16;
                return Convert.ToDecimal(valor);
            }
        }

        private decimal Real(double valor)
        {
            if (CbMoedaSaida.SelectedItem.ToString() == "Dólar")
            {
                valor *= 0.18;
                return Convert.ToDecimal(valor);
            }
            else
            {
                valor *= 0.15;
                return Convert.ToDecimal(valor);
            }
        }

        private void BtConverter_Click(object sender, EventArgs e)
        {

            valor = Convert.ToDouble(TbValor.Text);

            if (CbMoedaEntrada.SelectedItem.ToString() == "Real")
            {
                TbResultado.Text = Convert.ToString(Real(valor));
            } 
            else if (CbMoedaEntrada.SelectedItem.ToString() == "Euro")
            {
                TbResultado.Text = Convert.ToString(Euro(valor));
            } 
            else
            {
                TbResultado.Text = Convert.ToString(Dolar(valor));
            }
        }
    }
}
