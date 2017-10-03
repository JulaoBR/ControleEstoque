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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroCarga = new System.Windows.Forms.TextBox();
            this.txtDataPesquisa = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.gridRastreioLotes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRastreioLotes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtPesquisa.Location = new System.Drawing.Point(5, 103);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisa.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnImprimir);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Size = new System.Drawing.Size(915, 130);
            this.panel2.Controls.SetChildIndex(this.btnCancelar, 0);
            this.panel2.Controls.SetChildIndex(this.txtPesquisa, 0);
            this.panel2.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.panel2.Controls.SetChildIndex(this.groupBox2, 0);
            this.panel2.Controls.SetChildIndex(this.btnImprimir, 0);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridRastreioLotes);
            this.panel1.Location = new System.Drawing.Point(13, 149);
            this.panel1.Size = new System.Drawing.Size(920, 447);
            // 
            // txtLote
            // 
            this.txtLote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLote.Location = new System.Drawing.Point(6, 35);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(194, 31);
            this.txtLote.TabIndex = 0;
            this.txtLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtLote);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtNumeroCarga);
            this.groupBox2.Controls.Add(this.txtDataPesquisa);
            this.groupBox2.Location = new System.Drawing.Point(5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 77);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opções de filtragem:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lote:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data do carregamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Numero da carga:";
            // 
            // txtNumeroCarga
            // 
            this.txtNumeroCarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNumeroCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCarga.Location = new System.Drawing.Point(429, 35);
            this.txtNumeroCarga.Name = "txtNumeroCarga";
            this.txtNumeroCarga.Size = new System.Drawing.Size(212, 31);
            this.txtNumeroCarga.TabIndex = 2;
            this.txtNumeroCarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumeroCarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroCarga_KeyPress);
            // 
            // txtDataPesquisa
            // 
            this.txtDataPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDataPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataPesquisa.Location = new System.Drawing.Point(228, 35);
            this.txtDataPesquisa.MaxLength = 10;
            this.txtDataPesquisa.Name = "txtDataPesquisa";
            this.txtDataPesquisa.Size = new System.Drawing.Size(176, 31);
            this.txtDataPesquisa.TabIndex = 1;
            this.txtDataPesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataPesquisa_KeyPress);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(833, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 31);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // gridRastreioLotes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridRastreioLotes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridRastreioLotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRastreioLotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridRastreioLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRastreioLotes.Location = new System.Drawing.Point(4, 2);
            this.gridRastreioLotes.Margin = new System.Windows.Forms.Padding(2);
            this.gridRastreioLotes.Name = "gridRastreioLotes";
            this.gridRastreioLotes.ReadOnly = true;
            this.gridRastreioLotes.RowTemplate.Height = 24;
            this.gridRastreioLotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRastreioLotes.Size = new System.Drawing.Size(909, 454);
            this.gridRastreioLotes.TabIndex = 0;
            this.gridRastreioLotes.TabStop = false;
            this.gridRastreioLotes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRastreioLotes_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite o nome do produto";
            // 
            // frmRastreioDeLotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(945, 608);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRastreioDeLotes";
            this.Text = "PESQUISA DE LOTES";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRastreioLotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridView gridRastreioLotes;
        private System.Windows.Forms.TextBox txtDataPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroCarga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
