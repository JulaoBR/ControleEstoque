namespace PassaTempo
{
    partial class frmCalculaPesoCarga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculaPesoCarga));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.btnCargaExistente = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPesoBruto = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLiquido = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTolerancia = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPesoBrutoTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLotacao = new System.Windows.Forms.TextBox();
            this.txtTara = new System.Windows.Forms.TextBox();
            this.cbNomeCaminhao = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPesoLiquido = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbTotalItens = new System.Windows.Forms.Label();
            this.lbTotalCaixa = new System.Windows.Forms.Label();
            this.lbPesoBruto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gridProdutos = new System.Windows.Forms.DataGridView();
            this.Id_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPesoTotal = new System.Windows.Forms.TextBox();
            this.txtTotalCaixas = new System.Windows.Forms.TextBox();
            this.txtTotalCargas = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.btnCargaExistente);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtPesoBruto);
            this.panel2.Controls.Add(this.btnPesquisar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtQuantidade);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtLiquido);
            this.panel2.Controls.Add(this.txtNomeProduto);
            this.panel2.Controls.Add(this.txtCodigoProduto);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 167);
            this.panel2.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(254, 2);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(214, 16);
            this.label17.TabIndex = 12;
            this.label17.Text = "Selecionar carga ja existente:";
            // 
            // btnCargaExistente
            // 
            this.btnCargaExistente.Location = new System.Drawing.Point(322, 19);
            this.btnCargaExistente.Name = "btnCargaExistente";
            this.btnCargaExistente.Size = new System.Drawing.Size(98, 23);
            this.btnCargaExistente.TabIndex = 11;
            this.btnCargaExistente.TabStop = false;
            this.btnCargaExistente.Text = "...";
            this.btnCargaExistente.UseVisualStyleBackColor = true;
            this.btnCargaExistente.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Peso Bruto:";
            // 
            // txtPesoBruto
            // 
            this.txtPesoBruto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtPesoBruto.ForeColor = System.Drawing.Color.White;
            this.txtPesoBruto.Location = new System.Drawing.Point(140, 122);
            this.txtPesoBruto.Name = "txtPesoBruto";
            this.txtPesoBruto.ReadOnly = true;
            this.txtPesoBruto.Size = new System.Drawing.Size(108, 22);
            this.txtPesoBruto.TabIndex = 9;
            this.txtPesoBruto.TabStop = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(110, 17);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(47, 23);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.TabStop = false;
            this.btnPesquisar.Text = "...";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(276, 122);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(123, 22);
            this.txtQuantidade.TabIndex = 1;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Peso Liquido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome do produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código do produto:";
            // 
            // txtLiquido
            // 
            this.txtLiquido.BackColor = System.Drawing.Color.Blue;
            this.txtLiquido.ForeColor = System.Drawing.Color.White;
            this.txtLiquido.Location = new System.Drawing.Point(4, 122);
            this.txtLiquido.Name = "txtLiquido";
            this.txtLiquido.ReadOnly = true;
            this.txtLiquido.Size = new System.Drawing.Size(108, 22);
            this.txtLiquido.TabIndex = 2;
            this.txtLiquido.TabStop = false;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.BackColor = System.Drawing.Color.Blue;
            this.txtNomeProduto.ForeColor = System.Drawing.Color.White;
            this.txtNomeProduto.Location = new System.Drawing.Point(4, 61);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.ReadOnly = true;
            this.txtNomeProduto.Size = new System.Drawing.Size(459, 22);
            this.txtNomeProduto.TabIndex = 1;
            this.txtNomeProduto.TabStop = false;
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(4, 18);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoProduto.TabIndex = 0;
            this.txtCodigoProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoProduto_KeyPress);
            this.txtCodigoProduto.Leave += new System.EventHandler(this.txtCodigoProduto_Leave);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.txtTolerancia);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.txtPesoBrutoTotal);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.txtLotacao);
            this.panel4.Controls.Add(this.txtTara);
            this.panel4.Controls.Add(this.cbNomeCaminhao);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(490, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(419, 215);
            this.panel4.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(224, 117);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Tolerancia (5% PBT):";
            // 
            // txtTolerancia
            // 
            this.txtTolerancia.Location = new System.Drawing.Point(227, 133);
            this.txtTolerancia.Name = "txtTolerancia";
            this.txtTolerancia.ReadOnly = true;
            this.txtTolerancia.Size = new System.Drawing.Size(180, 22);
            this.txtTolerancia.TabIndex = 11;
            this.txtTolerancia.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 117);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Peso bruto total:";
            // 
            // txtPesoBrutoTotal
            // 
            this.txtPesoBrutoTotal.Location = new System.Drawing.Point(11, 133);
            this.txtPesoBrutoTotal.Name = "txtPesoBrutoTotal";
            this.txtPesoBrutoTotal.ReadOnly = true;
            this.txtPesoBrutoTotal.Size = new System.Drawing.Size(180, 22);
            this.txtPesoBrutoTotal.TabIndex = 9;
            this.txtPesoBrutoTotal.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Selecione o caminhão:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(224, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Lotação:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Tara:";
            // 
            // txtLotacao
            // 
            this.txtLotacao.Location = new System.Drawing.Point(227, 85);
            this.txtLotacao.Name = "txtLotacao";
            this.txtLotacao.ReadOnly = true;
            this.txtLotacao.Size = new System.Drawing.Size(180, 22);
            this.txtLotacao.TabIndex = 5;
            this.txtLotacao.TabStop = false;
            // 
            // txtTara
            // 
            this.txtTara.Location = new System.Drawing.Point(11, 85);
            this.txtTara.Name = "txtTara";
            this.txtTara.ReadOnly = true;
            this.txtTara.Size = new System.Drawing.Size(180, 22);
            this.txtTara.TabIndex = 4;
            this.txtTara.TabStop = false;
            // 
            // cbNomeCaminhao
            // 
            this.cbNomeCaminhao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNomeCaminhao.FormattingEnabled = true;
            this.cbNomeCaminhao.Location = new System.Drawing.Point(11, 35);
            this.cbNomeCaminhao.Name = "cbNomeCaminhao";
            this.cbNomeCaminhao.Size = new System.Drawing.Size(396, 24);
            this.cbNomeCaminhao.TabIndex = 0;
            this.cbNomeCaminhao.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(11, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 33);
            this.button2.TabIndex = 3;
            this.button2.TabStop = false;
            this.button2.Text = "Limpa carga";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(191, 187);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(104, 40);
            this.btnAdicionar.TabIndex = 12;
            this.btnAdicionar.TabStop = false;
            this.btnAdicionar.Text = "Add Carga";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(315, 187);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(104, 40);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.TabStop = false;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(65, 187);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(106, 40);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbPesoLiquido);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.lbTotalItens);
            this.panel1.Controls.Add(this.lbTotalCaixa);
            this.panel1.Controls.Add(this.lbPesoBruto);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.gridProdutos);
            this.panel1.Location = new System.Drawing.Point(12, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 286);
            this.panel1.TabIndex = 13;
            // 
            // lbPesoLiquido
            // 
            this.lbPesoLiquido.AutoSize = true;
            this.lbPesoLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesoLiquido.ForeColor = System.Drawing.Color.Red;
            this.lbPesoLiquido.Location = new System.Drawing.Point(64, 259);
            this.lbPesoLiquido.Name = "lbPesoLiquido";
            this.lbPesoLiquido.Size = new System.Drawing.Size(15, 15);
            this.lbPesoLiquido.TabIndex = 8;
            this.lbPesoLiquido.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(3, 259);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 15);
            this.label18.TabIndex = 7;
            this.label18.Text = "Peso L:";
            // 
            // lbTotalItens
            // 
            this.lbTotalItens.AutoSize = true;
            this.lbTotalItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalItens.ForeColor = System.Drawing.Color.Red;
            this.lbTotalItens.Location = new System.Drawing.Point(439, 259);
            this.lbTotalItens.Name = "lbTotalItens";
            this.lbTotalItens.Size = new System.Drawing.Size(15, 15);
            this.lbTotalItens.TabIndex = 6;
            this.lbTotalItens.Text = "0";
            // 
            // lbTotalCaixa
            // 
            this.lbTotalCaixa.AutoSize = true;
            this.lbTotalCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalCaixa.ForeColor = System.Drawing.Color.Red;
            this.lbTotalCaixa.Location = new System.Drawing.Point(341, 259);
            this.lbTotalCaixa.Name = "lbTotalCaixa";
            this.lbTotalCaixa.Size = new System.Drawing.Size(15, 15);
            this.lbTotalCaixa.TabIndex = 5;
            this.lbTotalCaixa.Text = "0";
            // 
            // lbPesoBruto
            // 
            this.lbPesoBruto.AutoSize = true;
            this.lbPesoBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesoBruto.ForeColor = System.Drawing.Color.Red;
            this.lbPesoBruto.Location = new System.Drawing.Point(185, 259);
            this.lbPesoBruto.Name = "lbPesoBruto";
            this.lbPesoBruto.Size = new System.Drawing.Size(15, 15);
            this.lbPesoBruto.TabIndex = 4;
            this.lbPesoBruto.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(391, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Itens:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(250, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total de CX:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Peso B:";
            // 
            // gridProdutos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_produto,
            this.nome_produto,
            this.qtd_produto,
            this.peso});
            this.gridProdutos.Location = new System.Drawing.Point(3, 4);
            this.gridProdutos.Name = "gridProdutos";
            this.gridProdutos.ReadOnly = true;
            this.gridProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProdutos.Size = new System.Drawing.Size(468, 252);
            this.gridProdutos.TabIndex = 0;
            this.gridProdutos.TabStop = false;
            this.gridProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProdutos_CellDoubleClick);
            // 
            // Id_produto
            // 
            this.Id_produto.DataPropertyName = "Fk_produto";
            this.Id_produto.HeaderText = "ID";
            this.Id_produto.Name = "Id_produto";
            this.Id_produto.ReadOnly = true;
            this.Id_produto.Width = 50;
            // 
            // nome_produto
            // 
            this.nome_produto.DataPropertyName = "dsc_produto";
            this.nome_produto.HeaderText = "PRODUTO";
            this.nome_produto.Name = "nome_produto";
            this.nome_produto.ReadOnly = true;
            this.nome_produto.Width = 225;
            // 
            // qtd_produto
            // 
            this.qtd_produto.DataPropertyName = "qtd_produto";
            this.qtd_produto.HeaderText = "QTD";
            this.qtd_produto.Name = "qtd_produto";
            this.qtd_produto.ReadOnly = true;
            this.qtd_produto.Width = 80;
            // 
            // peso
            // 
            this.peso.DataPropertyName = "pesoBruto";
            this.peso.HeaderText = "P.B";
            this.peso.Name = "peso";
            this.peso.ReadOnly = true;
            this.peso.Width = 70;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtPesoTotal);
            this.panel3.Controls.Add(this.txtTotalCaixas);
            this.panel3.Controls.Add(this.txtTotalCargas);
            this.panel3.Location = new System.Drawing.Point(496, 254);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(419, 258);
            this.panel3.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(131, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Total Cargas:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(131, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Total Caixas:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(131, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Peso:";
            // 
            // txtPesoTotal
            // 
            this.txtPesoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoTotal.Location = new System.Drawing.Point(227, 131);
            this.txtPesoTotal.Name = "txtPesoTotal";
            this.txtPesoTotal.ReadOnly = true;
            this.txtPesoTotal.Size = new System.Drawing.Size(141, 26);
            this.txtPesoTotal.TabIndex = 2;
            this.txtPesoTotal.TabStop = false;
            this.txtPesoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalCaixas
            // 
            this.txtTotalCaixas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCaixas.Location = new System.Drawing.Point(227, 77);
            this.txtTotalCaixas.Name = "txtTotalCaixas";
            this.txtTotalCaixas.ReadOnly = true;
            this.txtTotalCaixas.Size = new System.Drawing.Size(141, 26);
            this.txtTotalCaixas.TabIndex = 1;
            this.txtTotalCaixas.TabStop = false;
            this.txtTotalCaixas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalCargas
            // 
            this.txtTotalCargas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCargas.Location = new System.Drawing.Point(227, 28);
            this.txtTotalCargas.Name = "txtTotalCargas";
            this.txtTotalCargas.ReadOnly = true;
            this.txtTotalCargas.Size = new System.Drawing.Size(141, 26);
            this.txtTotalCargas.TabIndex = 0;
            this.txtTotalCargas.TabStop = false;
            this.txtTotalCargas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(374, 139);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "Kilos";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(375, 85);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(26, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "Uni";
            // 
            // frmCalculaPesoCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 552);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCalculaPesoCarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "q";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCalculaPesoCarga_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLiquido;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTolerancia;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPesoBrutoTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLotacao;
        private System.Windows.Forms.TextBox txtTara;
        private System.Windows.Forms.ComboBox cbNomeCaminhao;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTotalItens;
        private System.Windows.Forms.Label lbTotalCaixa;
        private System.Windows.Forms.Label lbPesoBruto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gridProdutos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPesoTotal;
        private System.Windows.Forms.TextBox txtTotalCaixas;
        private System.Windows.Forms.TextBox txtTotalCargas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPesoBruto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCargaExistente;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbPesoLiquido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
    }
}