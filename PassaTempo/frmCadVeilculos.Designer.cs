namespace PassaTempo
{
    partial class frmCadVeilculos
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
            this.txtCodigoVeiculo = new System.Windows.Forms.TextBox();
            this.txtNomeCaminhao = new System.Windows.Forms.TextBox();
            this.txtTara = new System.Windows.Forms.TextBox();
            this.txtLotacao = new System.Windows.Forms.TextBox();
            this.txtPesoBruto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtPlaca);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtPesoBruto);
            this.panel2.Controls.Add(this.txtLotacao);
            this.panel2.Controls.Add(this.txtTara);
            this.panel2.Controls.Add(this.txtNomeCaminhao);
            this.panel2.Controls.Add(this.txtCodigoVeiculo);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnLista
            // 
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCodigoVeiculo
            // 
            this.txtCodigoVeiculo.Location = new System.Drawing.Point(32, 32);
            this.txtCodigoVeiculo.Name = "txtCodigoVeiculo";
            this.txtCodigoVeiculo.ReadOnly = true;
            this.txtCodigoVeiculo.Size = new System.Drawing.Size(116, 22);
            this.txtCodigoVeiculo.TabIndex = 0;
            this.txtCodigoVeiculo.TabStop = false;
            // 
            // txtNomeCaminhao
            // 
            this.txtNomeCaminhao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCaminhao.Location = new System.Drawing.Point(32, 89);
            this.txtNomeCaminhao.MaxLength = 50;
            this.txtNomeCaminhao.Name = "txtNomeCaminhao";
            this.txtNomeCaminhao.Size = new System.Drawing.Size(585, 22);
            this.txtNomeCaminhao.TabIndex = 0;
            // 
            // txtTara
            // 
            this.txtTara.Location = new System.Drawing.Point(32, 148);
            this.txtTara.MaxLength = 10;
            this.txtTara.Name = "txtTara";
            this.txtTara.Size = new System.Drawing.Size(221, 22);
            this.txtTara.TabIndex = 1;
            this.txtTara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            this.txtTara.Leave += new System.EventHandler(this.txtTara_Leave);
            // 
            // txtLotacao
            // 
            this.txtLotacao.Location = new System.Drawing.Point(396, 148);
            this.txtLotacao.MaxLength = 10;
            this.txtLotacao.Name = "txtLotacao";
            this.txtLotacao.Size = new System.Drawing.Size(221, 22);
            this.txtLotacao.TabIndex = 2;
            this.txtLotacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            this.txtLotacao.Leave += new System.EventHandler(this.txtLotacao_Leave);
            // 
            // txtPesoBruto
            // 
            this.txtPesoBruto.Location = new System.Drawing.Point(32, 208);
            this.txtPesoBruto.Name = "txtPesoBruto";
            this.txtPesoBruto.ReadOnly = true;
            this.txtPesoBruto.Size = new System.Drawing.Size(221, 22);
            this.txtPesoBruto.TabIndex = 4;
            this.txtPesoBruto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código veiculo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome do Veiculos*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tara*:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lotação*:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Peso Bruto:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaca.Location = new System.Drawing.Point(396, 206);
            this.txtPlaca.MaxLength = 7;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(221, 22);
            this.txtPlaca.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Placa*:";
            // 
            // frmCadVeilculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(808, 426);
            this.Name = "frmCadVeilculos";
            this.Text = "CADASTRO DE VEICULOS";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesoBruto;
        private System.Windows.Forms.TextBox txtLotacao;
        private System.Windows.Forms.TextBox txtTara;
        private System.Windows.Forms.TextBox txtNomeCaminhao;
        private System.Windows.Forms.TextBox txtCodigoVeiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPlaca;
    }
}
