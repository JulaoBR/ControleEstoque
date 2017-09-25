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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAjuste = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.rbLote = new System.Windows.Forms.RadioButton();
            this.rbDataFabricacao = new System.Windows.Forms.RadioButton();
            this.rbDataProducao = new System.Windows.Forms.RadioButton();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnLimparPesquisa = new System.Windows.Forms.Button();
            this.gridEntrada = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLimparPesquisa);
            this.panel2.Controls.Add(this.btnImprimir);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.SetChildIndex(this.btnCancelar, 0);
            this.panel2.Controls.SetChildIndex(this.txtPesquisa, 0);
            this.panel2.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.panel2.Controls.SetChildIndex(this.groupBox1, 0);
            this.panel2.Controls.SetChildIndex(this.groupBox2, 0);
            this.panel2.Controls.SetChildIndex(this.btnImprimir, 0);
            this.panel2.Controls.SetChildIndex(this.btnLimparPesquisa, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridEntrada);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAjuste);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 76);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções ";
            // 
            // rbAjuste
            // 
            this.rbAjuste.AutoSize = true;
            this.rbAjuste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rbAjuste.Location = new System.Drawing.Point(18, 22);
            this.rbAjuste.Name = "rbAjuste";
            this.rbAjuste.Size = new System.Drawing.Size(85, 19);
            this.rbAjuste.TabIndex = 3;
            this.rbAjuste.TabStop = true;
            this.rbAjuste.Text = "AJUSTES";
            this.rbAjuste.UseVisualStyleBackColor = true;
            this.rbAjuste.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.rbLote);
            this.groupBox2.Controls.Add(this.rbDataFabricacao);
            this.groupBox2.Controls.Add(this.rbDataProducao);
            this.groupBox2.Location = new System.Drawing.Point(135, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 76);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opções de filtragem";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(6, 46);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(426, 21);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbLote
            // 
            this.rbLote.AutoSize = true;
            this.rbLote.Location = new System.Drawing.Point(372, 22);
            this.rbLote.Name = "rbLote";
            this.rbLote.Size = new System.Drawing.Size(60, 19);
            this.rbLote.TabIndex = 2;
            this.rbLote.TabStop = true;
            this.rbLote.Text = "LOTE";
            this.rbLote.UseVisualStyleBackColor = true;
            this.rbLote.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // rbDataFabricacao
            // 
            this.rbDataFabricacao.AutoSize = true;
            this.rbDataFabricacao.Location = new System.Drawing.Point(185, 22);
            this.rbDataFabricacao.Name = "rbDataFabricacao";
            this.rbDataFabricacao.Size = new System.Drawing.Size(169, 19);
            this.rbDataFabricacao.TabIndex = 1;
            this.rbDataFabricacao.TabStop = true;
            this.rbDataFabricacao.Text = "DATA DE FABRICAÇÃO";
            this.rbDataFabricacao.UseVisualStyleBackColor = true;
            this.rbDataFabricacao.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // rbDataProducao
            // 
            this.rbDataProducao.AutoSize = true;
            this.rbDataProducao.Location = new System.Drawing.Point(7, 22);
            this.rbDataProducao.Name = "rbDataProducao";
            this.rbDataProducao.Size = new System.Drawing.Size(162, 19);
            this.rbDataProducao.TabIndex = 0;
            this.rbDataProducao.TabStop = true;
            this.rbDataProducao.Text = "DATA DE PRODUÇÃO";
            this.rbDataProducao.UseVisualStyleBackColor = true;
            this.rbDataProducao.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(752, 76);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 31);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimparPesquisa
            // 
            this.btnLimparPesquisa.Location = new System.Drawing.Point(752, 39);
            this.btnLimparPesquisa.Name = "btnLimparPesquisa";
            this.btnLimparPesquisa.Size = new System.Drawing.Size(156, 31);
            this.btnLimparPesquisa.TabIndex = 5;
            this.btnLimparPesquisa.Text = "Limpar";
            this.btnLimparPesquisa.UseVisualStyleBackColor = true;
            this.btnLimparPesquisa.Click += new System.EventHandler(this.btnLimparPesquisa_Click);
            // 
            // gridEntrada
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridEntrada.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridEntrada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEntrada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEntrada.Location = new System.Drawing.Point(3, 4);
            this.gridEntrada.Name = "gridEntrada";
            this.gridEntrada.ReadOnly = true;
            this.gridEntrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEntrada.Size = new System.Drawing.Size(910, 452);
            this.gridEntrada.TabIndex = 0;
            this.gridEntrada.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEntrada_CellDoubleClick);
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
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.RadioButton rbLote;
        private System.Windows.Forms.RadioButton rbDataFabricacao;
        private System.Windows.Forms.RadioButton rbDataProducao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAjuste;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnLimparPesquisa;
        private System.Windows.Forms.DataGridView gridEntrada;
    }
}
