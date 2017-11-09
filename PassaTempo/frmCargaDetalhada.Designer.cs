namespace PassaTempo
{
    partial class frmCargaDetalhada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaDetalhada));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTotaCaixas = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnImprimirCarga = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lbTotalItens = new System.Windows.Forms.Label();
            this.lbPesoBruto = new System.Windows.Forms.Label();
            this.lbPesoLiquido = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gridCarga = new System.Windows.Forms.DataGridView();
            this.Fk_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsc_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComprador = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtDataCarregamento = new System.Windows.Forms.TextBox();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarga)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbTotaCaixas);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.btnImprimirCarga);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lbTotalItens);
            this.panel2.Controls.Add(this.lbPesoBruto);
            this.panel2.Controls.Add(this.lbPesoLiquido);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.gridCarga);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(13, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(729, 539);
            this.panel2.TabIndex = 1;
            // 
            // lbTotaCaixas
            // 
            this.lbTotaCaixas.AutoSize = true;
            this.lbTotaCaixas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotaCaixas.ForeColor = System.Drawing.Color.Red;
            this.lbTotaCaixas.Location = new System.Drawing.Point(459, 513);
            this.lbTotaCaixas.Name = "lbTotaCaixas";
            this.lbTotaCaixas.Size = new System.Drawing.Size(16, 16);
            this.lbTotaCaixas.TabIndex = 15;
            this.lbTotaCaixas.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(344, 513);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "Total de Caixas:";
            // 
            // btnImprimirCarga
            // 
            this.btnImprimirCarga.BackColor = System.Drawing.Color.White;
            this.btnImprimirCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirCarga.Location = new System.Drawing.Point(587, 206);
            this.btnImprimirCarga.Name = "btnImprimirCarga";
            this.btnImprimirCarga.Size = new System.Drawing.Size(129, 23);
            this.btnImprimirCarga.TabIndex = 2;
            this.btnImprimirCarga.Text = "Imprimir carga";
            this.btnImprimirCarga.UseVisualStyleBackColor = false;
            this.btnImprimirCarga.Click += new System.EventHandler(this.btnImprimirCarga_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Itens adiquiridos na carga:";
            // 
            // lbTotalItens
            // 
            this.lbTotalItens.AutoSize = true;
            this.lbTotalItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalItens.ForeColor = System.Drawing.Color.Red;
            this.lbTotalItens.Location = new System.Drawing.Point(658, 513);
            this.lbTotalItens.Name = "lbTotalItens";
            this.lbTotalItens.Size = new System.Drawing.Size(16, 16);
            this.lbTotalItens.TabIndex = 12;
            this.lbTotalItens.Text = "0";
            // 
            // lbPesoBruto
            // 
            this.lbPesoBruto.AutoSize = true;
            this.lbPesoBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesoBruto.ForeColor = System.Drawing.Color.Red;
            this.lbPesoBruto.Location = new System.Drawing.Point(254, 513);
            this.lbPesoBruto.Name = "lbPesoBruto";
            this.lbPesoBruto.Size = new System.Drawing.Size(16, 16);
            this.lbPesoBruto.TabIndex = 11;
            this.lbPesoBruto.Text = "0";
            // 
            // lbPesoLiquido
            // 
            this.lbPesoLiquido.AutoSize = true;
            this.lbPesoLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesoLiquido.ForeColor = System.Drawing.Color.Red;
            this.lbPesoLiquido.Location = new System.Drawing.Point(111, 513);
            this.lbPesoLiquido.Name = "lbPesoLiquido";
            this.lbPesoLiquido.Size = new System.Drawing.Size(16, 16);
            this.lbPesoLiquido.TabIndex = 10;
            this.lbPesoLiquido.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(554, 513);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Total de itens:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(169, 513);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Peso bruto:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 513);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "Peso Liquido:";
            // 
            // gridCarga
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridCarga.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridCarga.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCarga.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridCarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCarga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fk_produto,
            this.dsc_produto,
            this.lote,
            this.qtd_produto});
            this.gridCarga.Location = new System.Drawing.Point(4, 231);
            this.gridCarga.Name = "gridCarga";
            this.gridCarga.ReadOnly = true;
            this.gridCarga.RowHeadersVisible = false;
            this.gridCarga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCarga.Size = new System.Drawing.Size(712, 279);
            this.gridCarga.TabIndex = 1;
            this.gridCarga.TabStop = false;
            // 
            // Fk_produto
            // 
            this.Fk_produto.DataPropertyName = "Fk_produto";
            this.Fk_produto.HeaderText = "ID";
            this.Fk_produto.Name = "Fk_produto";
            this.Fk_produto.ReadOnly = true;
            // 
            // dsc_produto
            // 
            this.dsc_produto.DataPropertyName = "dsc_produto";
            this.dsc_produto.HeaderText = "PRODUTO";
            this.dsc_produto.Name = "dsc_produto";
            this.dsc_produto.ReadOnly = true;
            // 
            // lote
            // 
            this.lote.DataPropertyName = "lote";
            this.lote.HeaderText = "LOTES";
            this.lote.Name = "lote";
            this.lote.ReadOnly = true;
            // 
            // qtd_produto
            // 
            this.qtd_produto.DataPropertyName = "qtd_produto";
            this.qtd_produto.HeaderText = "QTD TOTAL";
            this.qtd_produto.Name = "qtd_produto";
            this.qtd_produto.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCep);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtComprador);
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.txtNomeCliente);
            this.groupBox1.Controls.Add(this.txtDataCarregamento);
            this.groupBox1.Controls.Add(this.txtCodCliente);
            this.groupBox1.Controls.Add(this.txtPedido);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Cliente";
            // 
            // txtCep
            // 
            this.txtCep.BackColor = System.Drawing.Color.Silver;
            this.txtCep.Location = new System.Drawing.Point(468, 142);
            this.txtCep.Name = "txtCep";
            this.txtCep.ReadOnly = true;
            this.txtCep.Size = new System.Drawing.Size(244, 22);
            this.txtCep.TabIndex = 102;
            this.txtCep.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(420, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 16);
            this.label14.TabIndex = 101;
            this.label14.Text = "CEP:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Data do carregamento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cod. Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pedido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Comprador:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Endereço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cliente:";
            // 
            // txtComprador
            // 
            this.txtComprador.BackColor = System.Drawing.Color.Silver;
            this.txtComprador.Location = new System.Drawing.Point(118, 170);
            this.txtComprador.Name = "txtComprador";
            this.txtComprador.ReadOnly = true;
            this.txtComprador.Size = new System.Drawing.Size(594, 22);
            this.txtComprador.TabIndex = 7;
            this.txtComprador.TabStop = false;
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.Silver;
            this.txtEstado.Location = new System.Drawing.Point(118, 142);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(296, 22);
            this.txtEstado.TabIndex = 6;
            this.txtEstado.TabStop = false;
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.Silver;
            this.txtCidade.Location = new System.Drawing.Point(118, 114);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.ReadOnly = true;
            this.txtCidade.Size = new System.Drawing.Size(594, 22);
            this.txtCidade.TabIndex = 5;
            this.txtCidade.TabStop = false;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.Silver;
            this.txtEndereco.Location = new System.Drawing.Point(118, 86);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.ReadOnly = true;
            this.txtEndereco.Size = new System.Drawing.Size(594, 22);
            this.txtEndereco.TabIndex = 4;
            this.txtEndereco.TabStop = false;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BackColor = System.Drawing.Color.Silver;
            this.txtNomeCliente.Location = new System.Drawing.Point(118, 58);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(594, 22);
            this.txtNomeCliente.TabIndex = 3;
            this.txtNomeCliente.TabStop = false;
            // 
            // txtDataCarregamento
            // 
            this.txtDataCarregamento.BackColor = System.Drawing.Color.Silver;
            this.txtDataCarregamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataCarregamento.Location = new System.Drawing.Point(557, 21);
            this.txtDataCarregamento.Name = "txtDataCarregamento";
            this.txtDataCarregamento.ReadOnly = true;
            this.txtDataCarregamento.Size = new System.Drawing.Size(119, 26);
            this.txtDataCarregamento.TabIndex = 2;
            this.txtDataCarregamento.TabStop = false;
            this.txtDataCarregamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.BackColor = System.Drawing.Color.Silver;
            this.txtCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCliente.Location = new System.Drawing.Point(278, 21);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.ReadOnly = true;
            this.txtCodCliente.Size = new System.Drawing.Size(100, 26);
            this.txtCodCliente.TabIndex = 1;
            this.txtCodCliente.TabStop = false;
            this.txtCodCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPedido
            // 
            this.txtPedido.BackColor = System.Drawing.Color.Red;
            this.txtPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedido.Location = new System.Drawing.Point(70, 21);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.ReadOnly = true;
            this.txtPedido.Size = new System.Drawing.Size(100, 26);
            this.txtPedido.TabIndex = 100;
            this.txtPedido.TabStop = false;
            this.txtPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
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
            // frmCargaDetalhada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 563);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCargaDetalhada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CARGA DETALHADA";
            this.Load += new System.EventHandler(this.frmCargaDetalhada_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarga)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComprador;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtDataCarregamento;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.DataGridView gridCarga;
        private System.Windows.Forms.Label lbTotalItens;
        private System.Windows.Forms.Label lbPesoBruto;
        private System.Windows.Forms.Label lbPesoLiquido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnImprimirCarga;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fk_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsc_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd_produto;
        private System.Windows.Forms.Label lbTotaCaixas;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label label14;
    }
}