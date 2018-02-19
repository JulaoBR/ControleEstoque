namespace PassaTempo
{
    partial class frmPesquisaTotal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisaTotal));
            this.gridTotal = new System.Windows.Forms.DataGridView();
            this.Id_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsc_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btmImprimir = new System.Windows.Forms.Button();
            this.date01 = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rbEntrada = new System.Windows.Forms.RadioButton();
            this.rbSaida = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbProdutoFinal = new System.Windows.Forms.RadioButton();
            this.rbMateriaPrima = new System.Windows.Forms.RadioButton();
            this.date02 = new System.Windows.Forms.DateTimePicker();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTotal)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Size = new System.Drawing.Size(493, 21);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btmImprimir);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.Controls.SetChildIndex(this.txtPesquisa, 0);
            this.panel2.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.panel2.Controls.SetChildIndex(this.btnCancelar, 0);
            this.panel2.Controls.SetChildIndex(this.btmImprimir, 0);
            this.panel2.Controls.SetChildIndex(this.panel3, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridTotal);
            // 
            // gridTotal
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridTotal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTotal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_produto,
            this.dsc_produto,
            this.qtd_produto});
            this.gridTotal.Location = new System.Drawing.Point(4, 4);
            this.gridTotal.Name = "gridTotal";
            this.gridTotal.ReadOnly = true;
            this.gridTotal.RowHeadersVisible = false;
            this.gridTotal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTotal.Size = new System.Drawing.Size(909, 452);
            this.gridTotal.TabIndex = 0;
            // 
            // Id_produto
            // 
            this.Id_produto.DataPropertyName = "Fk_produto";
            this.Id_produto.FillWeight = 121.8274F;
            this.Id_produto.HeaderText = "ID";
            this.Id_produto.Name = "Id_produto";
            this.Id_produto.ReadOnly = true;
            this.Id_produto.Width = 80;
            // 
            // dsc_produto
            // 
            this.dsc_produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dsc_produto.DataPropertyName = "dsc_produto";
            this.dsc_produto.FillWeight = 89.0863F;
            this.dsc_produto.HeaderText = "PRODUTO";
            this.dsc_produto.Name = "dsc_produto";
            this.dsc_produto.ReadOnly = true;
            // 
            // qtd_produto
            // 
            this.qtd_produto.DataPropertyName = "qtd_produto";
            this.qtd_produto.FillWeight = 89.0863F;
            this.qtd_produto.HeaderText = "QUANTIDADE";
            this.qtd_produto.Name = "qtd_produto";
            this.qtd_produto.ReadOnly = true;
            this.qtd_produto.Width = 269;
            // 
            // btmImprimir
            // 
            this.btmImprimir.Location = new System.Drawing.Point(833, 3);
            this.btmImprimir.Name = "btmImprimir";
            this.btmImprimir.Size = new System.Drawing.Size(75, 30);
            this.btmImprimir.TabIndex = 3;
            this.btmImprimir.Text = "Imprimir";
            this.btmImprimir.UseVisualStyleBackColor = true;
            this.btmImprimir.Click += new System.EventHandler(this.btmImprimir_Click);
            // 
            // date01
            // 
            this.date01.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date01.Location = new System.Drawing.Point(15, 50);
            this.date01.Name = "date01";
            this.date01.Size = new System.Drawing.Size(200, 21);
            this.date01.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.date02);
            this.panel3.Controls.Add(this.date01);
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(492, 76);
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "à";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.rbEntrada);
            this.panel5.Controls.Add(this.rbSaida);
            this.panel5.Location = new System.Drawing.Point(272, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 40);
            this.panel5.TabIndex = 9;
            // 
            // rbEntrada
            // 
            this.rbEntrada.AutoSize = true;
            this.rbEntrada.ForeColor = System.Drawing.Color.Red;
            this.rbEntrada.Location = new System.Drawing.Point(17, 4);
            this.rbEntrada.Name = "rbEntrada";
            this.rbEntrada.Size = new System.Drawing.Size(75, 19);
            this.rbEntrada.TabIndex = 6;
            this.rbEntrada.TabStop = true;
            this.rbEntrada.Text = "Entrada";
            this.rbEntrada.UseVisualStyleBackColor = true;
            this.rbEntrada.CheckedChanged += new System.EventHandler(this.rbEntrada_CheckedChanged);
            // 
            // rbSaida
            // 
            this.rbSaida.AutoSize = true;
            this.rbSaida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbSaida.Location = new System.Drawing.Point(124, 4);
            this.rbSaida.Name = "rbSaida";
            this.rbSaida.Size = new System.Drawing.Size(62, 19);
            this.rbSaida.TabIndex = 7;
            this.rbSaida.TabStop = true;
            this.rbSaida.Text = "Saida";
            this.rbSaida.UseVisualStyleBackColor = true;
            this.rbSaida.CheckedChanged += new System.EventHandler(this.rbSaida_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.rbProdutoFinal);
            this.panel4.Controls.Add(this.rbMateriaPrima);
            this.panel4.Location = new System.Drawing.Point(15, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 40);
            this.panel4.TabIndex = 8;
            // 
            // rbProdutoFinal
            // 
            this.rbProdutoFinal.AutoSize = true;
            this.rbProdutoFinal.Location = new System.Drawing.Point(3, 4);
            this.rbProdutoFinal.Name = "rbProdutoFinal";
            this.rbProdutoFinal.Size = new System.Drawing.Size(74, 19);
            this.rbProdutoFinal.TabIndex = 6;
            this.rbProdutoFinal.TabStop = true;
            this.rbProdutoFinal.Text = "P. Final";
            this.rbProdutoFinal.UseVisualStyleBackColor = true;
            this.rbProdutoFinal.CheckedChanged += new System.EventHandler(this.rbProdutoFinal_CheckedChanged);
            // 
            // rbMateriaPrima
            // 
            this.rbMateriaPrima.AutoSize = true;
            this.rbMateriaPrima.Location = new System.Drawing.Point(94, 4);
            this.rbMateriaPrima.Name = "rbMateriaPrima";
            this.rbMateriaPrima.Size = new System.Drawing.Size(82, 19);
            this.rbMateriaPrima.TabIndex = 7;
            this.rbMateriaPrima.TabStop = true;
            this.rbMateriaPrima.Text = "M. prima";
            this.rbMateriaPrima.UseVisualStyleBackColor = true;
            this.rbMateriaPrima.CheckedChanged += new System.EventHandler(this.rbMateriaPrima_CheckedChanged);
            // 
            // date02
            // 
            this.date02.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date02.Location = new System.Drawing.Point(272, 50);
            this.date02.Name = "date02";
            this.date02.Size = new System.Drawing.Size(200, 21);
            this.date02.TabIndex = 5;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // frmPesquisaTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 608);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPesquisaTotal";
            this.Text = "ENTRADA/SAIDA";
            this.Load += new System.EventHandler(this.frmPesquisaTotal_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTotal)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTotal;
        private System.Windows.Forms.Button btmImprimir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rbEntrada;
        private System.Windows.Forms.RadioButton rbSaida;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbProdutoFinal;
        private System.Windows.Forms.RadioButton rbMateriaPrima;
        private System.Windows.Forms.DateTimePicker date02;
        private System.Windows.Forms.DateTimePicker date01;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsc_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd_produto;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}