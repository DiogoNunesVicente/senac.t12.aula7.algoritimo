using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1EstruturaControle
{
    public partial class FormPrincipal : Form
    {
        //variavel inteiro
        // 1-Tipo 2-nome 3-atribuição 4-valor da atribuição
        int contador = 0;
        //variavel texto
        string mensagem = "";
        //variavel decimal
        decimal saldoAtual = decimal.Zero;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void contaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cria uma variavél do formConta
            var formConta = new FormConta();
            //mostra a tela formConta
            formConta.Show();
            //icrementar o valor da variavel contador
            contador++;
        }

        private void contadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mensagem = "Contador de Click:" + contador;
            MessageBox.Show(mensagem,
                "contador",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mensagem = "Deseja Sair do Aplicativo?";
            var resultado = MessageBox.Show(mensagem, "Sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
                //fecha app
            }
            else//senão
            {
                //grava um log que ele desistiu de sair
                Console.Write("O usuario desistiu de fechar");
            }
        }

        private void calculoDeJurosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormcalculoJuros().ShowDialog();
        }
    }
}
