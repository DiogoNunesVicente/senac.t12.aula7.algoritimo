using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1EstruturaControle
{
    public partial class FormcalculoJuros : Form
    {
        public FormcalculoJuros()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //criar variaveis aporte e juros do tipo double
            //obter o texto do txtValor
            //obter o texto do txtJuros
            //converter o texto em um número double
            double aporte = double.Parse(txtValor.Text);
            double juros = double.Parse(txtJuros.Text);
            double mes = double.Parse(txtmes.Text);

            //chama o método calcular
            double total = CalcularJuros(aporte, juros, mes);

            MessageBox.Show($"Total de redimento: {total:F2}");
        }
        //calcula o juros com basse no aporte e %
        private double CalcularJuros(double aporte, double juros, double mes)
        {
            double total = 0.0;
            //estrutura de repetição
            for (int meses = 1; meses <= mes; meses++)
            {
                aporte *= 1 + (juros / 100);

            }

            total = aporte;
            return total;
        }
    }
}
