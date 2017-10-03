namespace PassaTempo
{
    partial class frmPesquisaEstoque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rbProdutoFinal = new System.Windows.Forms.RadioButton();
            this.rbMateriaPrima = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gridProduto = new System.Windows.Forms.DataGridView();
            this.Id_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dscproduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd_estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.rbMateriaPrima);
            this.panel2.Controls.Add(this.rbProdutoFinal);
            this.panel2.Controls.SetChildIndex(this.btnCancelar, 0);
            this.panel2.Controls.SetChildIndex(this.txtPesquisa, 0);
            this.panel2.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.panel2.Controls.SetChildIndex(this.rbProdutoFinal, 0);
            this.panel2.Controls.SetChildIndex(this.rbMateriaPrima, 0);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridProduto);
            // 
            // rbProdutoFinal
            // 
            this.rbProdutoFinal.AutoSize = true;
            this.rbProdutoFinal.Checked = true;
            this.rbProdutoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProdutoFinal.ForeColor = System.Drawing.Color.Green;
            this.rbProdutoFinal.Location = new System.Drawing.Point(16, 21);
            this.rbProdutoFinal.Name = "rbProdutoFinal";
            this.rbProdutoFinal.Size = new System.Drawing.Size(118, 20);
            this.rbProdutoFinal.TabIndex = 2;
            this.rbProdutoFinal.TabStop = true;
            this.rbProdutoFinal.Text = "Produto Final";
            this.rbProdutoFinal.UseVisualStyleBackColor = true;
            this.rbProdutoFinal.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbMateriaPrima
            // 
            this.rbMateriaPrima.AutoSize = true;
            this.rbMateriaPrima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMateriaPrima.ForeColor = System.Drawing.Color.Blue;
            this.rbMateriaPrima.Location = new System.Drawing.Point(16, 46);
            this.rbMateriaPrima.Name = "rbMateriaPrima";
            this.rbMateriaPrima.Size = new System.Drawing.Size(122, 20);
            this.rbMateriaPrima.TabIndex = 3;
            this.rbMateriaPrima.TabStop = true;
            this.rbMateriaPrima.Text = "Matéria Prima";
            this.rbMateriaPrima.UseVisualStyleBackColor = true;
            this.rbMateriaPrima.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(564, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Os itens em vermelho estão abaixo do limite minimo";
            // 
            // gridProduto
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_produto,
            this.Dscproduto,
            this.qtd_estoque});
            this.gridProduto.Location = new System.Drawing.Point(4, 4);
            this.gridProduto.Name = "gridProduto";
            this.gridProduto.ReadOnly = true;
            this.gridProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProduto.Size = new System.Drawing.Size(909, 452);
            this.gridProduto.TabIndex = 0;
            // 
            // Id_produto
            // 
            this.Id_produto.DataPropertyName = "Id_produto";
            this.Id_produto.HeaderText = "ID";
            this.Id_produto.Name = "Id_produto";
            this.Id_produto.ReadOnly = true;
            // 
            // Dscproduto
            // 
            this.Dscproduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dscproduto.DataPropertyName = "Dscproduto";
            this.Dscproduto.HeaderText = "PRODUTO";
            this.Dscproduto.Name = "Dscproduto";
            this.Dscproduto.ReadOnly = true;
            // 
            // qtd_estoque
            // 
            this.qtd_estoque.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qtd_estoque.DataPropertyName = "qtd_estoque";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.qtd_estoque.DefaultCellStyle = dataGridViewCellStyle3;
            this.qtd_estoque.HeaderText = "ESTOQUE";
            this.qtd_estoque.Name = "qtd_estoque";
            this.qtd_estoque.ReadOnly = true;
            // 
            // frmPesquisaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(945, 608);
            this.Name = "frmPesquisaEstoque";
            this.Text = "PESQUISA DE ESTOQUE";
            this.Load += new System.EventHandler(this.frmPesquisaEstoque_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbMateriaPrima;
        private System.Windows.Forms.RadioButton rbProdutoFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dscproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd_estoque;
    }
}
