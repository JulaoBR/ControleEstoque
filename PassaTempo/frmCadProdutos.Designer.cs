namespace PassaTempo
{
    partial class frmCadProdutos
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
            this.components = new System.ComponentModel.Container();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbTipoProduto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrazoValidade = new System.Windows.Forms.TextBox();
            this.cbUnidadeMedida = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPesoBruto = new System.Windows.Forms.TextBox();
            this.txtPesoLiquido = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEstoqueMaximo = new System.Windows.Forms.TextBox();
            this.txtEstoqueMinimo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.txtCodigoProduto);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnLista
            // 
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(24, 22);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.ReadOnly = true;
            this.txtCodigoProduto.Size = new System.Drawing.Size(110, 21);
            this.txtCodigoProduto.TabIndex = 0;
            this.txtCodigoProduto.TabStop = false;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(19, 46);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(562, 21);
            this.txtNomeProduto.TabIndex = 0;
            this.txtNomeProduto.Validating += new System.ComponentModel.CancelEventHandler(this.txtNomeProduto_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbTipoProduto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPrazoValidade);
            this.groupBox1.Controls.Add(this.cbUnidadeMedida);
            this.groupBox1.Controls.Add(this.txtNomeProduto);
            this.groupBox1.Location = new System.Drawing.Point(24, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 171);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Produto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(402, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Unidade Medida*:";
            // 
            // cbTipoProduto
            // 
            this.cbTipoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoProduto.FormattingEnabled = true;
            this.cbTipoProduto.Items.AddRange(new object[] {
            "MP",
            "PF"});
            this.cbTipoProduto.Location = new System.Drawing.Point(405, 91);
            this.cbTipoProduto.Name = "cbTipoProduto";
            this.cbTipoProduto.Size = new System.Drawing.Size(176, 23);
            this.cbTipoProduto.TabIndex = 10;
            this.cbTipoProduto.Validating += new System.ComponentModel.CancelEventHandler(this.cbTipoProduto_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Prazo Validade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Unidade Medida*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descrição*:";
            // 
            // txtPrazoValidade
            // 
            this.txtPrazoValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrazoValidade.Location = new System.Drawing.Point(19, 139);
            this.txtPrazoValidade.Name = "txtPrazoValidade";
            this.txtPrazoValidade.Size = new System.Drawing.Size(129, 21);
            this.txtPrazoValidade.TabIndex = 2;
            this.txtPrazoValidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrazoValidade_KeyPress);
            // 
            // cbUnidadeMedida
            // 
            this.cbUnidadeMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidadeMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnidadeMedida.FormattingEnabled = true;
            this.cbUnidadeMedida.Items.AddRange(new object[] {
            "CAIXA",
            "FARDO",
            "SACARIA",
            "PACOTE",
            "BALDE"});
            this.cbUnidadeMedida.Location = new System.Drawing.Point(19, 91);
            this.cbUnidadeMedida.Name = "cbUnidadeMedida";
            this.cbUnidadeMedida.Size = new System.Drawing.Size(357, 23);
            this.cbUnidadeMedida.TabIndex = 1;
            this.cbUnidadeMedida.Validating += new System.ComponentModel.CancelEventHandler(this.cbUnidadeMedida_Validating);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPesoBruto);
            this.groupBox2.Controls.Add(this.txtPesoLiquido);
            this.groupBox2.Location = new System.Drawing.Point(24, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 144);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Peso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Peso bruto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Peso liquido:";
            // 
            // txtPesoBruto
            // 
            this.txtPesoBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoBruto.Location = new System.Drawing.Point(139, 87);
            this.txtPesoBruto.MaxLength = 10;
            this.txtPesoBruto.Name = "txtPesoBruto";
            this.txtPesoBruto.Size = new System.Drawing.Size(129, 21);
            this.txtPesoBruto.TabIndex = 4;
            this.txtPesoBruto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesoBruto_KeyPress);
            // 
            // txtPesoLiquido
            // 
            this.txtPesoLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoLiquido.Location = new System.Drawing.Point(139, 46);
            this.txtPesoLiquido.MaxLength = 10;
            this.txtPesoLiquido.Name = "txtPesoLiquido";
            this.txtPesoLiquido.Size = new System.Drawing.Size(129, 21);
            this.txtPesoLiquido.TabIndex = 3;
            this.txtPesoLiquido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesoLiquido_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtEstoqueMaximo);
            this.groupBox3.Controls.Add(this.txtEstoqueMinimo);
            this.groupBox3.Location = new System.Drawing.Point(329, 254);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 144);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados de estocagem";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Estoque maximo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Estoque minimo:";
            // 
            // txtEstoqueMaximo
            // 
            this.txtEstoqueMaximo.BackColor = System.Drawing.SystemColors.Window;
            this.txtEstoqueMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoqueMaximo.Location = new System.Drawing.Point(147, 87);
            this.txtEstoqueMaximo.MaxLength = 6;
            this.txtEstoqueMaximo.Name = "txtEstoqueMaximo";
            this.txtEstoqueMaximo.Size = new System.Drawing.Size(129, 21);
            this.txtEstoqueMaximo.TabIndex = 6;
            this.txtEstoqueMaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstoqueMaximo_KeyPress);
            // 
            // txtEstoqueMinimo
            // 
            this.txtEstoqueMinimo.BackColor = System.Drawing.SystemColors.Window;
            this.txtEstoqueMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoqueMinimo.Location = new System.Drawing.Point(147, 46);
            this.txtEstoqueMinimo.MaxLength = 6;
            this.txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            this.txtEstoqueMinimo.Size = new System.Drawing.Size(129, 21);
            this.txtEstoqueMinimo.TabIndex = 5;
            this.txtEstoqueMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstoqueMinimo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código Produto:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCadProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(808, 426);
            this.KeyPreview = true;
            this.Name = "frmCadProdutos";
            this.Text = "CADASTRO DE PRODUTOS";
            this.Load += new System.EventHandler(this.frmCadProdutos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadProdutos_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtEstoqueMaximo;
        private System.Windows.Forms.TextBox txtEstoqueMinimo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPesoBruto;
        private System.Windows.Forms.TextBox txtPesoLiquido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrazoValidade;
        private System.Windows.Forms.ComboBox cbUnidadeMedida;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbTipoProduto;
    }
}
