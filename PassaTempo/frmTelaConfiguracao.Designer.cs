namespace PassaTempo
{
    partial class frmTelaConfiguracao
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbMateriaPrima = new System.Windows.Forms.CheckBox();
            this.rbProdutoFinal = new System.Windows.Forms.CheckBox();
            this.checkListaProdutos = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBotoesAtalho = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(911, 551);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.btnSalvar);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(903, 518);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MENU INICIAL";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbMateriaPrima);
            this.groupBox2.Controls.Add(this.rbProdutoFinal);
            this.groupBox2.Controls.Add(this.checkListaProdutos);
            this.groupBox2.Location = new System.Drawing.Point(7, 135);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(883, 155);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de produtos";
            // 
            // rbMateriaPrima
            // 
            this.rbMateriaPrima.AutoSize = true;
            this.rbMateriaPrima.Enabled = false;
            this.rbMateriaPrima.Location = new System.Drawing.Point(101, 103);
            this.rbMateriaPrima.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbMateriaPrima.Name = "rbMateriaPrima";
            this.rbMateriaPrima.Size = new System.Drawing.Size(149, 24);
            this.rbMateriaPrima.TabIndex = 5;
            this.rbMateriaPrima.Text = "Matéria Prima";
            this.rbMateriaPrima.UseVisualStyleBackColor = true;
            // 
            // rbProdutoFinal
            // 
            this.rbProdutoFinal.AutoSize = true;
            this.rbProdutoFinal.Enabled = false;
            this.rbProdutoFinal.Location = new System.Drawing.Point(101, 71);
            this.rbProdutoFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbProdutoFinal.Name = "rbProdutoFinal";
            this.rbProdutoFinal.Size = new System.Drawing.Size(143, 24);
            this.rbProdutoFinal.TabIndex = 4;
            this.rbProdutoFinal.Text = "Produto Final";
            this.rbProdutoFinal.UseVisualStyleBackColor = true;
            // 
            // checkListaProdutos
            // 
            this.checkListaProdutos.AutoSize = true;
            this.checkListaProdutos.Location = new System.Drawing.Point(45, 39);
            this.checkListaProdutos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkListaProdutos.Name = "checkListaProdutos";
            this.checkListaProdutos.Size = new System.Drawing.Size(243, 24);
            this.checkListaProdutos.TabIndex = 1;
            this.checkListaProdutos.Text = "Mostrar lista de produtos";
            this.checkListaProdutos.UseVisualStyleBackColor = true;
            this.checkListaProdutos.CheckedChanged += new System.EventHandler(this.checkListaProdutos_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBotoesAtalho);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(883, 102);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Botões de atalho";
            // 
            // checkBotoesAtalho
            // 
            this.checkBotoesAtalho.AutoSize = true;
            this.checkBotoesAtalho.Location = new System.Drawing.Point(45, 41);
            this.checkBotoesAtalho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBotoesAtalho.Name = "checkBotoesAtalho";
            this.checkBotoesAtalho.Size = new System.Drawing.Size(241, 24);
            this.checkBotoesAtalho.TabIndex = 0;
            this.checkBotoesAtalho.Text = "Mostrar botões de atalho";
            this.checkBotoesAtalho.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(783, 476);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(107, 33);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // frmTelaConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 581);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTelaConfiguracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONFIGURAÇÃO";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkListaProdutos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBotoesAtalho;
        private System.Windows.Forms.CheckBox rbMateriaPrima;
        private System.Windows.Forms.CheckBox rbProdutoFinal;
        private System.Windows.Forms.Button btnSalvar;
    }
}