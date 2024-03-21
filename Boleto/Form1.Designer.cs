namespace Boleto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbEntrada = new System.Windows.Forms.GroupBox();
            this.lblBoleto = new System.Windows.Forms.Label();
            this.lblVlrMulta = new System.Windows.Forms.Label();
            this.gpbResultados = new System.Windows.Forms.GroupBox();
            this.gpbAcoes = new System.Windows.Forms.GroupBox();
            this.lblVencimento = new System.Windows.Forms.Label();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.lblMulta = new System.Windows.Forms.Label();
            this.lblJuros = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblVlrJuros = new System.Windows.Forms.Label();
            this.lblAcrescimo = new System.Windows.Forms.Label();
            this.lblVlrDesconto = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtBoleto = new System.Windows.Forms.TextBox();
            this.txtMulta = new System.Windows.Forms.TextBox();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.txtVlrMulta = new System.Windows.Forms.TextBox();
            this.txtVlrJuros = new System.Windows.Forms.TextBox();
            this.txtAcrescimo = new System.Windows.Forms.TextBox();
            this.txtVlrDesconto = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnLimp = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.mskVencimento = new System.Windows.Forms.MaskedTextBox();
            this.mskPagamento = new System.Windows.Forms.MaskedTextBox();
            this.gpbEntrada.SuspendLayout();
            this.gpbResultados.SuspendLayout();
            this.gpbAcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbEntrada
            // 
            this.gpbEntrada.BackColor = System.Drawing.Color.Black;
            this.gpbEntrada.Controls.Add(this.mskPagamento);
            this.gpbEntrada.Controls.Add(this.mskVencimento);
            this.gpbEntrada.Controls.Add(this.txtDesconto);
            this.gpbEntrada.Controls.Add(this.txtJuros);
            this.gpbEntrada.Controls.Add(this.txtMulta);
            this.gpbEntrada.Controls.Add(this.txtBoleto);
            this.gpbEntrada.Controls.Add(this.lblDesconto);
            this.gpbEntrada.Controls.Add(this.lblJuros);
            this.gpbEntrada.Controls.Add(this.lblMulta);
            this.gpbEntrada.Controls.Add(this.lblPagamento);
            this.gpbEntrada.Controls.Add(this.lblVencimento);
            this.gpbEntrada.Controls.Add(this.lblBoleto);
            this.gpbEntrada.ForeColor = System.Drawing.Color.Yellow;
            this.gpbEntrada.Location = new System.Drawing.Point(31, 304);
            this.gpbEntrada.Name = "gpbEntrada";
            this.gpbEntrada.Size = new System.Drawing.Size(143, 336);
            this.gpbEntrada.TabIndex = 0;
            this.gpbEntrada.TabStop = false;
            this.gpbEntrada.Text = "Dados de entrada:";
            // 
            // lblBoleto
            // 
            this.lblBoleto.AutoSize = true;
            this.lblBoleto.Location = new System.Drawing.Point(38, 16);
            this.lblBoleto.Name = "lblBoleto";
            this.lblBoleto.Size = new System.Drawing.Size(82, 13);
            this.lblBoleto.TabIndex = 1;
            this.lblBoleto.Text = "Valor do Boleto:";
            // 
            // lblVlrMulta
            // 
            this.lblVlrMulta.AutoSize = true;
            this.lblVlrMulta.Location = new System.Drawing.Point(33, 67);
            this.lblVlrMulta.Name = "lblVlrMulta";
            this.lblVlrMulta.Size = new System.Drawing.Size(78, 13);
            this.lblVlrMulta.TabIndex = 1;
            this.lblVlrMulta.Text = "Valor da Multa:";
            // 
            // gpbResultados
            // 
            this.gpbResultados.BackColor = System.Drawing.Color.Black;
            this.gpbResultados.Controls.Add(this.txtTotal);
            this.gpbResultados.Controls.Add(this.txtVlrDesconto);
            this.gpbResultados.Controls.Add(this.txtAcrescimo);
            this.gpbResultados.Controls.Add(this.txtVlrJuros);
            this.gpbResultados.Controls.Add(this.txtVlrMulta);
            this.gpbResultados.Controls.Add(this.txtDias);
            this.gpbResultados.Controls.Add(this.lblDias);
            this.gpbResultados.Controls.Add(this.lblTotal);
            this.gpbResultados.Controls.Add(this.lblVlrDesconto);
            this.gpbResultados.Controls.Add(this.lblAcrescimo);
            this.gpbResultados.Controls.Add(this.lblVlrJuros);
            this.gpbResultados.Controls.Add(this.lblVlrMulta);
            this.gpbResultados.ForeColor = System.Drawing.Color.Yellow;
            this.gpbResultados.Location = new System.Drawing.Point(809, 303);
            this.gpbResultados.Name = "gpbResultados";
            this.gpbResultados.Size = new System.Drawing.Size(140, 336);
            this.gpbResultados.TabIndex = 2;
            this.gpbResultados.TabStop = false;
            this.gpbResultados.Text = "Resultado:";
            // 
            // gpbAcoes
            // 
            this.gpbAcoes.BackColor = System.Drawing.Color.Black;
            this.gpbAcoes.Controls.Add(this.btnFechar);
            this.gpbAcoes.Controls.Add(this.btnLimp);
            this.gpbAcoes.Controls.Add(this.btnCalc);
            this.gpbAcoes.ForeColor = System.Drawing.Color.Yellow;
            this.gpbAcoes.Location = new System.Drawing.Point(266, 565);
            this.gpbAcoes.Name = "gpbAcoes";
            this.gpbAcoes.Size = new System.Drawing.Size(451, 75);
            this.gpbAcoes.TabIndex = 3;
            this.gpbAcoes.TabStop = false;
            this.gpbAcoes.Text = "Ações";
            // 
            // lblVencimento
            // 
            this.lblVencimento.AutoSize = true;
            this.lblVencimento.Location = new System.Drawing.Point(40, 67);
            this.lblVencimento.Name = "lblVencimento";
            this.lblVencimento.Size = new System.Drawing.Size(66, 13);
            this.lblVencimento.TabIndex = 1;
            this.lblVencimento.Text = "Vencimento:";
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Location = new System.Drawing.Point(40, 121);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(64, 13);
            this.lblPagamento.TabIndex = 1;
            this.lblPagamento.Text = "Pagamento:";
            // 
            // lblMulta
            // 
            this.lblMulta.AutoSize = true;
            this.lblMulta.Location = new System.Drawing.Point(56, 181);
            this.lblMulta.Name = "lblMulta";
            this.lblMulta.Size = new System.Drawing.Size(36, 13);
            this.lblMulta.TabIndex = 1;
            this.lblMulta.Text = "Multa:";
            // 
            // lblJuros
            // 
            this.lblJuros.AutoSize = true;
            this.lblJuros.Location = new System.Drawing.Point(56, 234);
            this.lblJuros.Name = "lblJuros";
            this.lblJuros.Size = new System.Drawing.Size(35, 13);
            this.lblJuros.TabIndex = 1;
            this.lblJuros.Text = "Juros:";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(48, 285);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(56, 13);
            this.lblDesconto.TabIndex = 1;
            this.lblDesconto.Text = "Desconto:";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(31, 16);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(80, 13);
            this.lblDias.TabIndex = 1;
            this.lblDias.Text = "Dias atrasados:";
            // 
            // lblVlrJuros
            // 
            this.lblVlrJuros.AutoSize = true;
            this.lblVlrJuros.Location = new System.Drawing.Point(31, 121);
            this.lblVlrJuros.Name = "lblVlrJuros";
            this.lblVlrJuros.Size = new System.Drawing.Size(82, 13);
            this.lblVlrJuros.TabIndex = 1;
            this.lblVlrJuros.Text = "Valor dos Juros:";
            // 
            // lblAcrescimo
            // 
            this.lblAcrescimo.AutoSize = true;
            this.lblAcrescimo.Location = new System.Drawing.Point(33, 172);
            this.lblAcrescimo.Name = "lblAcrescimo";
            this.lblAcrescimo.Size = new System.Drawing.Size(86, 13);
            this.lblAcrescimo.TabIndex = 1;
            this.lblAcrescimo.Text = "Acréscimo Total:";
            // 
            // lblVlrDesconto
            // 
            this.lblVlrDesconto.AutoSize = true;
            this.lblVlrDesconto.Location = new System.Drawing.Point(26, 224);
            this.lblVlrDesconto.Name = "lblVlrDesconto";
            this.lblVlrDesconto.Size = new System.Drawing.Size(98, 13);
            this.lblVlrDesconto.TabIndex = 1;
            this.lblVlrDesconto.Text = "Valor do Desconto:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(38, 276);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(73, 13);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total à pagar:";
            // 
            // txtBoleto
            // 
            this.txtBoleto.Location = new System.Drawing.Point(41, 32);
            this.txtBoleto.Name = "txtBoleto";
            this.txtBoleto.Size = new System.Drawing.Size(65, 20);
            this.txtBoleto.TabIndex = 2;
            // 
            // txtMulta
            // 
            this.txtMulta.Location = new System.Drawing.Point(41, 197);
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.Size = new System.Drawing.Size(65, 20);
            this.txtMulta.TabIndex = 2;
            // 
            // txtJuros
            // 
            this.txtJuros.Location = new System.Drawing.Point(41, 250);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(65, 20);
            this.txtJuros.TabIndex = 2;
            // 
            // txtDias
            // 
            this.txtDias.Enabled = false;
            this.txtDias.Location = new System.Drawing.Point(24, 32);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(100, 20);
            this.txtDias.TabIndex = 2;
            // 
            // txtVlrMulta
            // 
            this.txtVlrMulta.Enabled = false;
            this.txtVlrMulta.Location = new System.Drawing.Point(24, 83);
            this.txtVlrMulta.Name = "txtVlrMulta";
            this.txtVlrMulta.Size = new System.Drawing.Size(100, 20);
            this.txtVlrMulta.TabIndex = 2;
            // 
            // txtVlrJuros
            // 
            this.txtVlrJuros.Enabled = false;
            this.txtVlrJuros.Location = new System.Drawing.Point(24, 137);
            this.txtVlrJuros.Name = "txtVlrJuros";
            this.txtVlrJuros.Size = new System.Drawing.Size(100, 20);
            this.txtVlrJuros.TabIndex = 2;
            // 
            // txtAcrescimo
            // 
            this.txtAcrescimo.Enabled = false;
            this.txtAcrescimo.Location = new System.Drawing.Point(24, 188);
            this.txtAcrescimo.Name = "txtAcrescimo";
            this.txtAcrescimo.Size = new System.Drawing.Size(100, 20);
            this.txtAcrescimo.TabIndex = 2;
            // 
            // txtVlrDesconto
            // 
            this.txtVlrDesconto.Enabled = false;
            this.txtVlrDesconto.Location = new System.Drawing.Point(24, 240);
            this.txtVlrDesconto.Name = "txtVlrDesconto";
            this.txtVlrDesconto.Size = new System.Drawing.Size(100, 20);
            this.txtVlrDesconto.TabIndex = 2;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(24, 292);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 2;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(41, 301);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(65, 20);
            this.txtDesconto.TabIndex = 2;
            // 
            // btnCalc
            // 
            this.btnCalc.ForeColor = System.Drawing.Color.Black;
            this.btnCalc.Location = new System.Drawing.Point(59, 29);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnLimp
            // 
            this.btnLimp.ForeColor = System.Drawing.Color.Black;
            this.btnLimp.Location = new System.Drawing.Point(200, 29);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(75, 23);
            this.btnLimp.TabIndex = 3;
            this.btnLimp.Text = "Limpar";
            this.btnLimp.UseVisualStyleBackColor = true;
            this.btnLimp.Click += new System.EventHandler(this.btnLimp_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.ForeColor = System.Drawing.Color.Black;
            this.btnFechar.Location = new System.Drawing.Point(323, 29);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // mskVencimento
            // 
            this.mskVencimento.Location = new System.Drawing.Point(41, 83);
            this.mskVencimento.Mask = "00/00/0000";
            this.mskVencimento.Name = "mskVencimento";
            this.mskVencimento.Size = new System.Drawing.Size(65, 20);
            this.mskVencimento.TabIndex = 3;
            this.mskVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // mskPagamento
            // 
            this.mskPagamento.Location = new System.Drawing.Point(41, 138);
            this.mskPagamento.Mask = "00/00/0000";
            this.mskPagamento.Name = "mskPagamento";
            this.mskPagamento.Size = new System.Drawing.Size(65, 20);
            this.mskPagamento.TabIndex = 3;
            this.mskPagamento.ValidatingType = typeof(System.DateTime);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Boleto.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(981, 651);
            this.Controls.Add(this.gpbAcoes);
            this.Controls.Add(this.gpbResultados);
            this.Controls.Add(this.gpbEntrada);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Boleto";
            this.gpbEntrada.ResumeLayout(false);
            this.gpbEntrada.PerformLayout();
            this.gpbResultados.ResumeLayout(false);
            this.gpbResultados.PerformLayout();
            this.gpbAcoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbEntrada;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblJuros;
        private System.Windows.Forms.Label lblMulta;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.Label lblVencimento;
        private System.Windows.Forms.Label lblBoleto;
        private System.Windows.Forms.Label lblVlrMulta;
        private System.Windows.Forms.GroupBox gpbResultados;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblVlrDesconto;
        private System.Windows.Forms.Label lblAcrescimo;
        private System.Windows.Forms.Label lblVlrJuros;
        private System.Windows.Forms.GroupBox gpbAcoes;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.TextBox txtMulta;
        private System.Windows.Forms.TextBox txtBoleto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtVlrDesconto;
        private System.Windows.Forms.TextBox txtAcrescimo;
        private System.Windows.Forms.TextBox txtVlrJuros;
        private System.Windows.Forms.TextBox txtVlrMulta;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.MaskedTextBox mskPagamento;
        private System.Windows.Forms.MaskedTextBox mskVencimento;
    }
}

