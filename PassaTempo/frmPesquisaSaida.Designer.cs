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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisaSaida));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNumPedido = new System.Windows.Forms.RadioButton();
            this.rbNomeCliente = new System.Windows.Forms.RadioButton();
            this.txtCampoData = new System.Windows.Forms.TextBox();
            this.gridSaidaCarga = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSaidaCarga)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtCampoData);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.SetChildIndex(this.btnCancelar, 0);
            this.panel2.Controls.SetChildIndex(this.txtPesquisa, 0);
            this.panel2.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.panel2.Controls.SetChildIndex(this.groupBox1, 0);
            this.panel2.Controls.SetChildIndex(this.txtCampoData, 0);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.button1, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.gridSaidaCarga);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNumPedido);
            this.groupBox1.Controls.Add(this.rbNomeCliente);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 57);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções para pesquisa";
            // 
            // rbNumPedido
            // 
            this.rbNumPedido.AutoSize = true;
            this.rbNumPedido.ForeColor = System.Drawing.Color.Red;
            this.rbNumPedido.Location = new System.Drawing.Point(158, 29);
            this.rbNumPedido.Name = "rbNumPedido";
            this.rbNumPedido.Size = new System.Drawing.Size(96, 19);
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
            this.rbNomeCliente.Location = new System.Drawing.Point(6, 29);
            this.rbNomeCliente.Name = "rbNomeCliente";
            this.rbNomeCliente.Size = new System.Drawing.Size(127, 19);
            this.rbNomeCliente.TabIndex = 15;
            this.rbNomeCliente.TabStop = true;
            this.rbNomeCliente.Text = "NOME CLIENTE";
            this.rbNomeCliente.UseVisualStyleBackColor = true;
            this.rbNomeCliente.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtCampoData
            // 
            this.txtCampoData.Location = new System.Drawing.Point(501, 86);
            this.txtCampoData.MaxLength = 10;
            this.txtCampoData.Name = "txtCampoData";
            this.txtCampoData.Size = new System.Drawing.Size(191, 21);
            this.txtCampoData.TabIndex = 1;
            this.txtCampoData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCampoData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCampoData_KeyPress_1);
            // 
            // gridSaidaCarga
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
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
            this.gridSaidaCarga.Location = new System.Drawing.Point(4, 4);
            this.gridSaidaCarga.Name = "gridSaidaCarga";
            this.gridSaidaCarga.ReadOnly = true;
            this.gridSaidaCarga.RowHeadersVisible = false;
            this.gridSaidaCarga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSaidaCarga.Size = new System.Drawing.Size(909, 436);
            this.gridSaidaCarga.TabIndex = 0;
            this.gridSaidaCarga.TabStop = false;
            this.gridSaidaCarga.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSaidaCarga_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite da data de carregamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Digite o nome do cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(4, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(569, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Para visualizar a carga com mais detalhes, de um dublo clique sobre a carga que d" +
    "eseja visualizar.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(833, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // frmPesquisaSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(945, 608);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPesquisaSaida";
            this.Text = "PESQUISA DE SAIDAS ";
            this.Load += new System.EventHandler(this.frmPesquisaSaida_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSaidaCarga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNumPedido;
        private System.Windows.Forms.RadioButton rbNomeCliente;
        private System.Windows.Forms.DataGridView gridSaidaCarga;
        private System.Windows.Forms.TextBox txtCampoData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}
