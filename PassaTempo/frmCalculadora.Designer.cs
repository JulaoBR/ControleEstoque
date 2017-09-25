namespace PassaTempo
{
    partial class frmCalculadora
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrazoValidade = new System.Windows.Forms.TextBox();
            this.cbNomeProduto = new System.Windows.Forms.ComboBox();
            this.txtDataFracricacao = new System.Windows.Forms.MaskedTextBox();
            this.txtDataValidade = new System.Windows.Forms.MaskedTextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPrazoValidade);
            this.panel1.Controls.Add(this.cbNomeProduto);
            this.panel1.Location = new System.Drawing.Point(13, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 88);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prazo validade:";
            // 
            // txtPrazoValidade
            // 
            this.txtPrazoValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrazoValidade.Location = new System.Drawing.Point(165, 46);
            this.txtPrazoValidade.Name = "txtPrazoValidade";
            this.txtPrazoValidade.ReadOnly = true;
            this.txtPrazoValidade.Size = new System.Drawing.Size(100, 26);
            this.txtPrazoValidade.TabIndex = 1;
            this.txtPrazoValidade.TabStop = false;
            // 
            // cbNomeProduto
            // 
            this.cbNomeProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNomeProduto.FormattingEnabled = true;
            this.cbNomeProduto.Location = new System.Drawing.Point(3, 12);
            this.cbNomeProduto.Name = "cbNomeProduto";
            this.cbNomeProduto.Size = new System.Drawing.Size(284, 28);
            this.cbNomeProduto.TabIndex = 1;
            this.cbNomeProduto.SelectedValueChanged += new System.EventHandler(this.cbNomeProduto_SelectedValueChanged);
            // 
            // txtDataFracricacao
            // 
            this.txtDataFracricacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataFracricacao.Location = new System.Drawing.Point(17, 197);
            this.txtDataFracricacao.Mask = "00/00/0000";
            this.txtDataFracricacao.Name = "txtDataFracricacao";
            this.txtDataFracricacao.Size = new System.Drawing.Size(155, 26);
            this.txtDataFracricacao.TabIndex = 2;
            this.txtDataFracricacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataFracricacao.ValidatingType = typeof(System.DateTime);
            // 
            // txtDataValidade
            // 
            this.txtDataValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataValidade.Location = new System.Drawing.Point(17, 255);
            this.txtDataValidade.Mask = "00/00/0000";
            this.txtDataValidade.Name = "txtDataValidade";
            this.txtDataValidade.Size = new System.Drawing.Size(155, 26);
            this.txtDataValidade.TabIndex = 2;
            this.txtDataValidade.TabStop = false;
            this.txtDataValidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataValidade.ValidatingType = typeof(System.DateTime);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCalcular.Location = new System.Drawing.Point(209, 206);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(92, 60);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selecione um produto para calcular ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "seu prazo de validade.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data de fabricação:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data validade:";
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 311);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDataValidade);
            this.Controls.Add(this.txtDataFracricacao);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULADORA";
            this.Load += new System.EventHandler(this.frmCalculadora_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCalculadora_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrazoValidade;
        private System.Windows.Forms.ComboBox cbNomeProduto;
        private System.Windows.Forms.MaskedTextBox txtDataFracricacao;
        private System.Windows.Forms.MaskedTextBox txtDataValidade;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}