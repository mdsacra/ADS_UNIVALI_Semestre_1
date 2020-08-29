using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class calc : Form
    {
        public calc()
        {
            InitializeComponent();
        }

        private void soma_Click(object sender, EventArgs e)
        {
            double resultado = Convert.ToDouble(num1.Text) + Convert.ToDouble(num2.Text);
            result.Text = Convert.ToString(resultado);
        }

        private void subtr_Click(object sender, EventArgs e)
        {
            double resultado = Convert.ToDouble(num1.Text) - Convert.ToDouble(num2.Text);
            result.Text = Convert.ToString(resultado);
        }

        private void mult_Click(object sender, EventArgs e)
        {
            double resultado = Convert.ToDouble(num1.Text) * Convert.ToDouble(num2.Text);
            result.Text = Convert.ToString(resultado);
        }

        private void div_Click(object sender, EventArgs e)
        {
            double resultado = (Convert.ToDouble(num1.Text) / Convert.ToDouble(num2.Text));
            result.Text = resultado.ToString("N2");
        }
    }
}
