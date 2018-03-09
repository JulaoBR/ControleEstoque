namespace PassaTempo
{
    partial class frmCadPedidosMateriaPrima
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.datePedido = new System.Windows.Forms.DateTimePicker();
            this.datePrevista = new System.Windows.Forms.DateTimePicker();
            this.gridProdutos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTipoOperacao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtObservacao);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbTipoOperacao);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnAdicionar);
            this.panel2.Controls.Add(this.txtQuantidade);
            this.panel2.Controls.Add(this.gridProdutos);
            this.panel2.Controls.Add(this.datePrevista);
            this.panel2.Controls.Add(this.datePedido);
            this.panel2.Controls.Add(this.cbProduto);
            this.panel2.Controls.Add(this.cbFornecedor);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(3, 31);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(390, 21);
            this.cbFornecedor.TabIndex = 0;
            // 
            // cbProduto
            // 
            this.cbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(3, 148);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(640, 21);
            this.cbProduto.TabIndex = 4;
            // 
            // datePedido
            // 
            this.datePedido.Enabled = false;
            this.datePedido.Location = new System.Drawing.Point(3, 90);
            this.datePedido.Name = "datePedido";
            this.datePedido.Size = new System.Drawing.Size(237, 20);
            this.datePedido.TabIndex = 2;
            // 
            // datePrevista
            // 
            this.datePrevista.Location = new System.Drawing.Point(406, 90);
            this.datePrevista.Name = "datePrevista";
            this.datePrevista.Size = new System.Drawing.Size(237, 20);
            this.datePrevista.TabIndex = 3;
            // 
            // gridProdutos
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.gridProdutos.Location = new System.Drawing.Point(3, 263);
            this.gridProdutos.Name = "gridProdutos";
            this.gridProdutos.RowHeadersVisible = false;
            this.gridProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProdutos.Size = new System.Drawing.Size(640, 131);
            this.gridProdutos.TabIndex = 5;
            this.gridProdutos.TabStop = false;
            this.gridProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProdutos_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id_produto";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "DscProduto";
            this.Column2.HeaderText = "PRODUTO";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "quantidade";
            this.Column3.HeaderText = "QUANTIDADE";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtQuantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(3, 198);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(136, 29);
            this.txtQuantidade.TabIndex = 5;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(529, 198);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(114, 38);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Selecione o fornecedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Data pedido*:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(403, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Data prevista para entrega*:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Selecione o produto*:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Quantidade*:";
            // 
            // cbTipoOperacao
            // 
            this.cbTipoOperacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoOperacao.FormattingEnabled = true;
            this.cbTipoOperacao.Items.AddRange(new object[] {
            "PEDIDO INTERNO",
            "PEDIDO DE COMPRA"});
            this.cbTipoOperacao.Location = new System.Drawing.Point(406, 31);
            this.cbTipoOperacao.Name = "cbTipoOperacao";
            this.cbTipoOperacao.Size = new System.Drawing.Size(237, 21);
            this.cbTipoOperacao.TabIndex = 20;
            this.cbTipoOperacao.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Selecione o tipo do PEDIDO:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.Location = new System.Drawing.Point(157, 198);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(352, 59);
            this.txtObservacao.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(154, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Observação*:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(157, 72);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 17);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "HABILITAR";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frmCadPedidosMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(808, 426);
            this.Name = "frmCadPedidosMateriaPrima";
            this.Text = "CADASTRO DE PEDIDOS";
            this.Load += new System.EventHandler(this.frmCadPedidosMateriaPrima_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProdutos;
        private System.Windows.Forms.DateTimePicker datePrevista;
        private System.Windows.Forms.DateTimePicker datePedido;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipoOperacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
