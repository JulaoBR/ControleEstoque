namespace PassaTempo
{
    partial class frmMovimentacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDataFabricacao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbAjuste = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbEntrada = new System.Windows.Forms.RadioButton();
            this.rbSaida = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtDataVencimento = new System.Windows.Forms.TextBox();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtQuatidadeAtual = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rbMateriaPrima = new System.Windows.Forms.RadioButton();
            this.rbProdutoFinal = new System.Windows.Forms.RadioButton();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.txtCodRegistro = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtCodRegistro);
            this.panel1.Controls.Add(this.txtDataFabricacao);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.txtObservacao);
            this.panel1.Controls.Add(this.txtDataVencimento);
            this.panel1.Controls.Add(this.txtLote);
            this.panel1.Controls.Add(this.txtQuantidade);
            this.panel1.Controls.Add(this.txtQuatidadeAtual);
            this.panel1.Controls.Add(this.txtNomeProduto);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtCodProduto);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 291);
            this.panel1.TabIndex = 0;
            // 
            // txtDataFabricacao
            // 
            this.txtDataFabricacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataFabricacao.Location = new System.Drawing.Point(180, 152);
            this.txtDataFabricacao.MaxLength = 10;
            this.txtDataFabricacao.Name = "txtDataFabricacao";
            this.txtDataFabricacao.Size = new System.Drawing.Size(132, 26);
            this.txtDataFabricacao.TabIndex = 2;
            this.txtDataFabricacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataFabricacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataFabricacao_KeyPress);
            this.txtDataFabricacao.Leave += new System.EventHandler(this.txtDataFabricacao_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(511, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Qtd Atual:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(505, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 15);
            this.label8.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Descrição do produto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Observação:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Data vencimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Lote*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Data fabricação*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Quantidade*:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Codigo produto*:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbAjuste);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(344, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 55);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ajuste";
            // 
            // rbAjuste
            // 
            this.rbAjuste.AutoSize = true;
            this.rbAjuste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rbAjuste.Location = new System.Drawing.Point(18, 24);
            this.rbAjuste.Name = "rbAjuste";
            this.rbAjuste.Size = new System.Drawing.Size(76, 19);
            this.rbAjuste.TabIndex = 3;
            this.rbAjuste.Text = "AJUSTE";
            this.rbAjuste.UseVisualStyleBackColor = true;
            this.rbAjuste.CheckedChanged += new System.EventHandler(this.rbAjuste_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbEntrada);
            this.groupBox2.Controls.Add(this.rbSaida);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(344, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 55);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de manutenção:";
            // 
            // rbEntrada
            // 
            this.rbEntrada.AutoSize = true;
            this.rbEntrada.ForeColor = System.Drawing.Color.Green;
            this.rbEntrada.Location = new System.Drawing.Point(18, 19);
            this.rbEntrada.Name = "rbEntrada";
            this.rbEntrada.Size = new System.Drawing.Size(88, 19);
            this.rbEntrada.TabIndex = 3;
            this.rbEntrada.Text = "ENTRADA";
            this.rbEntrada.UseVisualStyleBackColor = true;
            this.rbEntrada.CheckedChanged += new System.EventHandler(this.rbEntrada_CheckedChanged);
            // 
            // rbSaida
            // 
            this.rbSaida.AutoSize = true;
            this.rbSaida.ForeColor = System.Drawing.Color.Red;
            this.rbSaida.Location = new System.Drawing.Point(116, 19);
            this.rbSaida.Name = "rbSaida";
            this.rbSaida.Size = new System.Drawing.Size(64, 19);
            this.rbSaida.TabIndex = 2;
            this.rbSaida.Text = "SAIDA";
            this.rbSaida.UseVisualStyleBackColor = true;
            this.rbSaida.CheckedChanged += new System.EventHandler(this.rbSaida_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(573, 220);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 28);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(573, 186);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(103, 28);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(573, 152);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(103, 28);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.TabStop = false;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(573, 118);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(103, 28);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtObservacao
            // 
            this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Location = new System.Drawing.Point(18, 254);
            this.txtObservacao.MaxLength = 150;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(658, 22);
            this.txtObservacao.TabIndex = 5;
            // 
            // txtDataVencimento
            // 
            this.txtDataVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataVencimento.ForeColor = System.Drawing.Color.Red;
            this.txtDataVencimento.Location = new System.Drawing.Point(180, 192);
            this.txtDataVencimento.Name = "txtDataVencimento";
            this.txtDataVencimento.ReadOnly = true;
            this.txtDataVencimento.Size = new System.Drawing.Size(132, 26);
            this.txtDataVencimento.TabIndex = 10;
            this.txtDataVencimento.TabStop = false;
            this.txtDataVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLote
            // 
            this.txtLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLote.Location = new System.Drawing.Point(21, 192);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(100, 26);
            this.txtLote.TabIndex = 3;
            this.txtLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(21, 148);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 26);
            this.txtQuantidade.TabIndex = 1;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQuatidadeAtual
            // 
            this.txtQuatidadeAtual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtQuatidadeAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuatidadeAtual.Location = new System.Drawing.Point(508, 81);
            this.txtQuatidadeAtual.Name = "txtQuatidadeAtual";
            this.txtQuatidadeAtual.ReadOnly = true;
            this.txtQuatidadeAtual.Size = new System.Drawing.Size(168, 26);
            this.txtQuatidadeAtual.TabIndex = 5;
            this.txtQuatidadeAtual.TabStop = false;
            this.txtQuatidadeAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.BackColor = System.Drawing.Color.Blue;
            this.txtNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.ForeColor = System.Drawing.Color.White;
            this.txtNomeProduto.Location = new System.Drawing.Point(18, 81);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.ReadOnly = true;
            this.txtNomeProduto.Size = new System.Drawing.Size(484, 26);
            this.txtNomeProduto.TabIndex = 4;
            this.txtNomeProduto.TabStop = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(142, 26);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(47, 27);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.TabStop = false;
            this.btnPesquisar.Text = "...";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.rbMateriaPrima);
            this.groupBox1.Controls.Add(this.rbProdutoFinal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(290, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 40);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione o tipo de produto:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(263, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(117, 26);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.TabStop = false;
            // 
            // rbMateriaPrima
            // 
            this.rbMateriaPrima.AutoSize = true;
            this.rbMateriaPrima.Location = new System.Drawing.Point(118, 17);
            this.rbMateriaPrima.Name = "rbMateriaPrima";
            this.rbMateriaPrima.Size = new System.Drawing.Size(116, 19);
            this.rbMateriaPrima.TabIndex = 2;
            this.rbMateriaPrima.Text = "Materia Prima";
            this.rbMateriaPrima.UseVisualStyleBackColor = true;
            this.rbMateriaPrima.CheckedChanged += new System.EventHandler(this.rbMateriaPrima_CheckedChanged);
            // 
            // rbProdutoFinal
            // 
            this.rbProdutoFinal.AutoSize = true;
            this.rbProdutoFinal.Checked = true;
            this.rbProdutoFinal.Location = new System.Drawing.Point(6, 17);
            this.rbProdutoFinal.Name = "rbProdutoFinal";
            this.rbProdutoFinal.Size = new System.Drawing.Size(111, 19);
            this.rbProdutoFinal.TabIndex = 100;
            this.rbProdutoFinal.TabStop = true;
            this.rbProdutoFinal.Text = "Produto Final";
            this.rbProdutoFinal.UseVisualStyleBackColor = true;
            this.rbProdutoFinal.CheckedChanged += new System.EventHandler(this.rbProdutoFinal_CheckedChanged);
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.BackColor = System.Drawing.Color.Red;
            this.txtCodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProduto.Location = new System.Drawing.Point(18, 26);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(100, 26);
            this.txtCodProduto.TabIndex = 0;
            this.txtCodProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodProduto.Leave += new System.EventHandler(this.txtCodProduto_Leave);
            // 
            // txtCodRegistro
            // 
            this.txtCodRegistro.Enabled = false;
            this.txtCodRegistro.Location = new System.Drawing.Point(196, 29);
            this.txtCodRegistro.Name = "txtCodRegistro";
            this.txtCodRegistro.Size = new System.Drawing.Size(46, 21);
            this.txtCodRegistro.TabIndex = 26;
            this.txtCodRegistro.Visible = false;
            // 
            // frmMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 316);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMovimentacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MOVIMENTAÇÃO";
            this.Load += new System.EventHandler(this.frmMovimentacao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMovimentacao_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rbMateriaPrima;
        private System.Windows.Forms.RadioButton rbProdutoFinal;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbAjuste;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbEntrada;
        private System.Windows.Forms.RadioButton rbSaida;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtDataVencimento;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtQuatidadeAtual;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDataFabricacao;
        private System.Windows.Forms.TextBox txtCodRegistro;
    }
}