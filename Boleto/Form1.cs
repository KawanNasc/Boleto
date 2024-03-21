using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boleto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            txtBoleto.Clear();
            mskVencimento.Clear();
            mskPagamento.Clear();
            txtMulta.Clear();
            txtJuros.Clear();
            txtDesconto.Clear();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Declaramento das variáveis
            // Inteiras
            int data;
            // Pontos flutuantes (Decimais)
            double boleto, multa, juros, desconto, vlrMulta, vlrJuros, acrescimo, vlrDesconto, total;
            // Datas
            DateTime vencimento, pagamento;

            boleto = double.Parse(txtBoleto.Text);
            vencimento = Convert.ToDateTime(mskVencimento.Text);
            pagamento = Convert.ToDateTime(mskPagamento.Text);
            multa = double.Parse(txtMulta.Text);
            juros = double.Parse(txtJuros.Text);
            desconto = double.Parse(txtDesconto.Text);

            // Processamento
            data = (pagamento - vencimento).Days;

            if (data > 0)
            {
                vlrMulta = boleto * (multa / 100);
                vlrJuros = boleto * (juros / 100) * data;
                acrescimo = vlrMulta + vlrJuros;
            }
            else
            {
                vlrMulta = 0; vlrJuros = 0; acrescimo = 0;
            }

            if (data <= -5)
            {
                vlrDesconto = boleto * (desconto / 100);
            }
            else
            {
                vlrDesconto = 0;
            }

            total = boleto + acrescimo - vlrDesconto;

            txtDias.Text = data.ToString();
            txtVlrMulta.Text = vlrMulta.ToString("C");
            txtVlrJuros.Text = vlrJuros.ToString("C");
            txtAcrescimo.Text = acrescimo.ToString("C");
            txtVlrDesconto.Text = vlrDesconto.ToString("C");
            txtTotal.Text = total.ToString("C");
        }
    }
}
