namespace PassaTempo
{
    partial class frmPesquisaEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisaEntrada));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkSaidas = new System.Windows.Forms.CheckBox();
            this.rbAjuste = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.txtPesquisaData = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnLimparPesquisa = new System.Windows.Forms.Button();
            this.gridEntrada = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(3, 94);
            this.txtPesquisa.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnLimparPesquisa);
            this.panel2.Controls.Add(this.btnImprimir);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Size = new System.Drawing.Size(915, 125);
            this.panel2.Controls.SetChildIndex(this.btnCancelar, 0);
            this.panel2.Controls.SetChildIndex(this.txtPesquisa, 0);
            this.panel2.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.panel2.Controls.SetChildIndex(this.groupBox1, 0);
            this.panel2.Controls.SetChildIndex(this.groupBox2, 0);
            this.panel2.Controls.SetChildIndex(this.btnImprimir, 0);
            this.panel2.Controls.SetChildIndex(this.btnLimparPesquisa, 0);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridEntrada);
            this.panel1.Location = new System.Drawing.Point(13, 144);
            this.panel1.Size = new System.Drawing.Size(920, 452);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkSaidas);
            this.groupBox1.Controls.Add(this.rbAjuste);
            this.groupBox1.Location = new System.Drawing.Point(496, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 87);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções ";
            // 
            // checkSaidas
            // 
            this.checkSaidas.AutoSize = true;
            this.checkSaidas.Location = new System.Drawing.Point(15, 47);
            this.checkSaidas.Name = "checkSaidas";
            this.checkSaidas.Size = new System.Drawing.Size(121, 19);
            this.checkSaidas.TabIndex = 12;
            this.checkSaidas.Text = "Mostrar saidas";
            this.checkSaidas.UseVisualStyleBackColor = true;
            this.checkSaidas.CheckedChanged += new System.EventHandler(this.checkSaidas_CheckedChanged);
            // 
            // rbAjuste
            // 
            this.rbAjuste.AutoSize = true;
            this.rbAjuste.Location = new System.Drawing.Point(15, 20);
            this.rbAjuste.Name = "rbAjuste";
            this.rbAjuste.Size = new System.Drawing.Size(125, 19);
            this.rbAjuste.TabIndex = 11;
            this.rbAjuste.Text = "Mostrar ajustes";
            this.rbAjuste.UseVisualStyleBackColor = true;
            this.rbAjuste.CheckedChanged += new System.EventHandler(this.rbAjuste_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtLote);
            this.groupBox2.Controls.Add(this.txtPesquisaData);
            this.groupBox2.Location = new System.Drawing.Point(7, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 67);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opções de filtragem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data produção:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lote:";
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(183, 36);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(143, 21);
            this.txtLote.TabIndex = 2;
            // 
            // txtPesquisaData
            // 
            this.txtPesquisaData.Location = new System.Drawing.Point(6, 36);
            this.txtPesquisaData.MaxLength = 10;
            this.txtPesquisaData.Name = "txtPesquisaData";
            this.txtPesquisaData.Size = new System.Drawing.Size(162, 21);
            this.txtPesquisaData.TabIndex = 0;
            this.txtPesquisaData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPesquisaData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisaData_KeyPress);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(752, 76);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 31);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.TabStop = false;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimparPesquisa
            // 
            this.btnLimparPesquisa.Location = new System.Drawing.Point(752, 39);
            this.btnLimparPesquisa.Name = "btnLimparPesquisa";
            this.btnLimparPesquisa.Size = new System.Drawing.Size(156, 31);
            this.btnLimparPesquisa.TabIndex = 10;
            this.btnLimparPesquisa.TabStop = false;
            this.btnLimparPesquisa.Text = "Limpar";
            this.btnLimparPesquisa.UseVisualStyleBackColor = true;
            this.btnLimparPesquisa.Click += new System.EventHandler(this.btnLimparPesquisa_Click);
            // 
            // gridEntrada
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridEntrada.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridEntrada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEntrada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEntrada.Location = new System.Drawing.Point(3, 3);
            this.gridEntrada.Name = "gridEntrada";
            this.gridEntrada.ReadOnly = true;
            this.gridEntrada.RowHeadersVisible = false;
            this.gridEntrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEntrada.Size = new System.Drawing.Size(910, 442);
            this.gridEntrada.TabIndex = 0;
            this.gridEntrada.TabStop = false;
            this.gridEntrada.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEntrada_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite o nome do produto:";
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
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // frmPesquisaEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(945, 608);
            this.Name = "frmPesquisaEntrada";
            this.Text = "PESQUISAR ENTRADAS";
            this.Load += new System.EventHandler(this.frmPesquisaEntrada_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEntrada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnLimparPesquisa;
        private System.Windows.Forms.DataGridView gridEntrada;
        private System.Windows.Forms.TextBox txtPesquisaData;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox rbAjuste;
        private System.Windows.Forms.CheckBox checkSaidas;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}
