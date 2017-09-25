namespace PassaTempo
{
    partial class frmPesquisaSaida
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCampoData = new System.Windows.Forms.MaskedTextBox();
            this.rbDataCarregamento = new System.Windows.Forms.RadioButton();
            this.rbNumPedido = new System.Windows.Forms.RadioButton();
            this.rbNomeCliente = new System.Windows.Forms.RadioButton();
            this.gridSaidaCarga = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSaidaCarga)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.SetChildIndex(this.btnCancelar, 0);
            this.panel2.Controls.SetChildIndex(this.txtPesquisa, 0);
            this.panel2.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.panel2.Controls.SetChildIndex(this.groupBox1, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridSaidaCarga);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCampoData);
            this.groupBox1.Controls.Add(this.rbDataCarregamento);
            this.groupBox1.Controls.Add(this.rbNumPedido);
            this.groupBox1.Controls.Add(this.rbNomeCliente);
            this.groupBox1.Location = new System.Drawing.Point(5, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(964, 84);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções para pesquisa";
            // 
            // txtCampoData
            // 
            this.txtCampoData.Location = new System.Drawing.Point(673, 36);
            this.txtCampoData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCampoData.Mask = "00/00/0000";
            this.txtCampoData.Name = "txtCampoData";
            this.txtCampoData.Size = new System.Drawing.Size(281, 24);
            this.txtCampoData.TabIndex = 3;
            this.txtCampoData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCampoData.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCampoData_MaskInputRejected);
            // 
            // rbDataCarregamento
            // 
            this.rbDataCarregamento.AutoSize = true;
            this.rbDataCarregamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbDataCarregamento.Location = new System.Drawing.Point(383, 36);
            this.rbDataCarregamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDataCarregamento.Name = "rbDataCarregamento";
            this.rbDataCarregamento.Size = new System.Drawing.Size(244, 22);
            this.rbDataCarregamento.TabIndex = 2;
            this.rbDataCarregamento.Text = "DATA DE CARREGAMENTO";
            this.rbDataCarregamento.UseVisualStyleBackColor = true;
            this.rbDataCarregamento.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbNumPedido
            // 
            this.rbNumPedido.AutoSize = true;
            this.rbNumPedido.ForeColor = System.Drawing.Color.Red;
            this.rbNumPedido.Location = new System.Drawing.Point(215, 37);
            this.rbNumPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbNumPedido.Name = "rbNumPedido";
            this.rbNumPedido.Size = new System.Drawing.Size(115, 22);
            this.rbNumPedido.TabIndex = 1;
            this.rbNumPedido.Text = "Nº PEDIDO";
            this.rbNumPedido.UseVisualStyleBackColor = true;
            this.rbNumPedido.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbNomeCliente
            // 
            this.rbNomeCliente.AutoSize = true;
            this.rbNomeCliente.Checked = true;
            this.rbNomeCliente.ForeColor = System.Drawing.Color.Green;
            this.rbNomeCliente.Location = new System.Drawing.Point(8, 36);
            this.rbNomeCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbNomeCliente.Name = "rbNomeCliente";
            this.rbNomeCliente.Size = new System.Drawing.Size(153, 22);
            this.rbNomeCliente.TabIndex = 0;
            this.rbNomeCliente.TabStop = true;
            this.rbNomeCliente.Text = "NOME CLIENTE";
            this.rbNomeCliente.UseVisualStyleBackColor = true;
            this.rbNomeCliente.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // gridSaidaCarga
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridSaidaCarga.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSaidaCarga.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridSaidaCarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSaidaCarga.Location = new System.Drawing.Point(5, 5);
            this.gridSaidaCarga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridSaidaCarga.Name = "gridSaidaCarga";
            this.gridSaidaCarga.ReadOnly = true;
            this.gridSaidaCarga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSaidaCarga.Size = new System.Drawing.Size(1212, 556);
            this.gridSaidaCarga.TabIndex = 0;
            this.gridSaidaCarga.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSaidaCarga_CellDoubleClick);
            // 
            // frmPesquisaSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1260, 748);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmPesquisaSaida";
            this.Text = "PESQUISA DE SAIDAS ";
            this.Load += new System.EventHandler(this.frmPesquisaSaida_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSaidaCarga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtCampoData;
        private System.Windows.Forms.RadioButton rbDataCarregamento;
        private System.Windows.Forms.RadioButton rbNumPedido;
        private System.Windows.Forms.RadioButton rbNomeCliente;
        private System.Windows.Forms.DataGridView gridSaidaCarga;
    }
}
