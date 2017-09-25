namespace PassaTempo
{
    partial class frmCadCidadeEstado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeCidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoCidade = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeEstado = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbEstado = new System.Windows.Forms.RadioButton();
            this.rbCidade = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodEstado = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtCodEstado);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtCodigoCidade);
            this.panel2.Controls.Add(this.groupBox1);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCep);
            this.groupBox1.Controls.Add(this.cbEstado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNomeCidade);
            this.groupBox1.Location = new System.Drawing.Point(24, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 171);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da cidade";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(19, 89);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(562, 23);
            this.cbEstado.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "CEP*:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Estado*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome da cidade*:";
            // 
            // txtNomeCidade
            // 
            this.txtNomeCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCidade.Location = new System.Drawing.Point(19, 46);
            this.txtNomeCidade.MaxLength = 150;
            this.txtNomeCidade.Name = "txtNomeCidade";
            this.txtNomeCidade.Size = new System.Drawing.Size(562, 21);
            this.txtNomeCidade.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Código Cidade:";
            // 
            // txtCodigoCidade
            // 
            this.txtCodigoCidade.Location = new System.Drawing.Point(24, 16);
            this.txtCodigoCidade.Name = "txtCodigoCidade";
            this.txtCodigoCidade.ReadOnly = true;
            this.txtCodigoCidade.Size = new System.Drawing.Size(110, 21);
            this.txtCodigoCidade.TabIndex = 9;
            this.txtCodigoCidade.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtNomeEstado);
            this.groupBox2.Location = new System.Drawing.Point(24, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 120);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nome do estado*:";
            // 
            // txtNomeEstado
            // 
            this.txtNomeEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeEstado.Location = new System.Drawing.Point(19, 46);
            this.txtNomeEstado.MaxLength = 150;
            this.txtNomeEstado.Name = "txtNomeEstado";
            this.txtNomeEstado.Size = new System.Drawing.Size(562, 21);
            this.txtNomeEstado.TabIndex = 8;
            this.txtNomeEstado.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.rbEstado);
            this.panel3.Controls.Add(this.rbCidade);
            this.panel3.Location = new System.Drawing.Point(436, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 42);
            this.panel3.TabIndex = 12;
            // 
            // rbEstado
            // 
            this.rbEstado.AutoSize = true;
            this.rbEstado.ForeColor = System.Drawing.Color.Green;
            this.rbEstado.Location = new System.Drawing.Point(103, 11);
            this.rbEstado.Name = "rbEstado";
            this.rbEstado.Size = new System.Drawing.Size(79, 19);
            this.rbEstado.TabIndex = 1;
            this.rbEstado.Text = "ESTADO";
            this.rbEstado.UseVisualStyleBackColor = true;
            this.rbEstado.CheckedChanged += new System.EventHandler(this.rbEstado_CheckedChanged);
            // 
            // rbCidade
            // 
            this.rbCidade.AutoSize = true;
            this.rbCidade.BackColor = System.Drawing.SystemColors.Control;
            this.rbCidade.ForeColor = System.Drawing.Color.Red;
            this.rbCidade.Location = new System.Drawing.Point(22, 11);
            this.rbCidade.Name = "rbCidade";
            this.rbCidade.Size = new System.Drawing.Size(75, 19);
            this.rbCidade.TabIndex = 0;
            this.rbCidade.Text = "CIDADE";
            this.rbCidade.UseVisualStyleBackColor = false;
            this.rbCidade.CheckedChanged += new System.EventHandler(this.rbCidade_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 53;
            this.label5.Text = "Código Estado:";
            // 
            // txtCodEstado
            // 
            this.txtCodEstado.Location = new System.Drawing.Point(24, 247);
            this.txtCodEstado.Name = "txtCodEstado";
            this.txtCodEstado.ReadOnly = true;
            this.txtCodEstado.Size = new System.Drawing.Size(110, 21);
            this.txtCodEstado.TabIndex = 52;
            this.txtCodEstado.TabStop = false;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(19, 130);
            this.txtCep.Mask = "00000-9999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(225, 21);
            this.txtCep.TabIndex = 14;
            // 
            // frmCadCidadeEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(808, 426);
            this.KeyPreview = true;
            this.Name = "frmCadCidadeEstado";
            this.Text = "CADASTRO DE CIDADE E ESTADO";
            this.Load += new System.EventHandler(this.frmCadCidadeEstado_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadCidadeEstado_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeCidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigoCidade;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomeEstado;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbEstado;
        private System.Windows.Forms.RadioButton rbCidade;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodEstado;
        private System.Windows.Forms.MaskedTextBox txtCep;
    }
}
