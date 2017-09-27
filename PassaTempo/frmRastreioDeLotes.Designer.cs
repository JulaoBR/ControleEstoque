namespace PassaTempo
{
    partial class frmRastreioDeLotes
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
            this.txtLote = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.rbDataCarregamento = new System.Windows.Forms.RadioButton();
            this.brProduto = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.gridRastreioLotes = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRastreioLotes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnImprimir);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.SetChildIndex(this.btnCancelar, 0);
            this.panel2.Controls.SetChildIndex(this.groupBox1, 0);
            this.panel2.Controls.SetChildIndex(this.txtPesquisa, 0);
            this.panel2.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.panel2.Controls.SetChildIndex(this.groupBox2, 0);
            this.panel2.Controls.SetChildIndex(this.btnImprimir, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridRastreioLotes);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLote);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(303, 82);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione o lote:";
            // 
            // txtLote
            // 
            this.txtLote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLote.Location = new System.Drawing.Point(24, 26);
            this.txtLote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(257, 37);
            this.txtLote.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtData);
            this.groupBox2.Controls.Add(this.rbDataCarregamento);
            this.groupBox2.Controls.Add(this.brProduto);
            this.groupBox2.Controls.Add(this.rbCliente);
            this.groupBox2.Location = new System.Drawing.Point(333, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(713, 82);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opções de filtragem:";
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(533, 27);
            this.txtData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(169, 30);
            this.txtData.TabIndex = 3;
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // rbDataCarregamento
            // 
            this.rbDataCarregamento.AutoSize = true;
            this.rbDataCarregamento.Location = new System.Drawing.Point(296, 36);
            this.rbDataCarregamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDataCarregamento.Name = "rbDataCarregamento";
            this.rbDataCarregamento.Size = new System.Drawing.Size(201, 22);
            this.rbDataCarregamento.TabIndex = 2;
            this.rbDataCarregamento.TabStop = true;
            this.rbDataCarregamento.Text = "Data de carregamento:";
            this.rbDataCarregamento.UseVisualStyleBackColor = true;
            this.rbDataCarregamento.CheckedChanged += new System.EventHandler(this.rbDataCarregamento_CheckedChanged);
            // 
            // brProduto
            // 
            this.brProduto.AutoSize = true;
            this.brProduto.Location = new System.Drawing.Point(164, 36);
            this.brProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.brProduto.Name = "brProduto";
            this.brProduto.Size = new System.Drawing.Size(89, 22);
            this.brProduto.TabIndex = 1;
            this.brProduto.TabStop = true;
            this.brProduto.Text = "Produto";
            this.brProduto.UseVisualStyleBackColor = true;
            this.brProduto.CheckedChanged += new System.EventHandler(this.brProduto_CheckedChanged);
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Location = new System.Drawing.Point(29, 36);
            this.rbCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(81, 22);
            this.rbCliente.TabIndex = 0;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            this.rbCliente.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(1111, 5);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 38);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // gridRastreioLotes
            // 
            this.gridRastreioLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRastreioLotes.Location = new System.Drawing.Point(5, 3);
            this.gridRastreioLotes.Name = "gridRastreioLotes";
            this.gridRastreioLotes.RowTemplate.Height = 24;
            this.gridRastreioLotes.Size = new System.Drawing.Size(1212, 559);
            this.gridRastreioLotes.TabIndex = 0;
            // 
            // frmRastreioDeLotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1260, 748);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmRastreioDeLotes";
            this.Text = "PESQUISA DE LOTES";
            this.Load += new System.EventHandler(this.frmRastreioDeLotes_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRastreioLotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.RadioButton rbDataCarregamento;
        private System.Windows.Forms.RadioButton brProduto;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridView gridRastreioLotes;
    }
}
