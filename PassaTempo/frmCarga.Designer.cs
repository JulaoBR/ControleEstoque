namespace PassaTempo
{
    partial class frmCarga
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTotalCaixas = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbTotalItens = new System.Windows.Forms.Label();
            this.lbPesoBruto = new System.Windows.Forms.Label();
            this.lbPesoLiquido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridDadosCarga = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPesquisaProduto = new System.Windows.Forms.Button();
            this.btnPesquisaCliente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridLotes = new System.Windows.Forms.DataGridView();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEstoqueAtual = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddLote = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtQtdTotal = new System.Windows.Forms.TextBox();
            this.txtLote1 = new System.Windows.Forms.TextBox();
            this.txtQtd1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNomeComprador = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lbComprador = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Fk_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsc_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDadosCarga)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLotes)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbTotalCaixas);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lbTotalItens);
            this.panel1.Controls.Add(this.lbPesoBruto);
            this.panel1.Controls.Add(this.lbPesoLiquido);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gridDadosCarga);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 296);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 341);
            this.panel1.TabIndex = 0;
            // 
            // lbTotalCaixas
            // 
            this.lbTotalCaixas.AutoSize = true;
            this.lbTotalCaixas.ForeColor = System.Drawing.Color.Red;
            this.lbTotalCaixas.Location = new System.Drawing.Point(506, 324);
            this.lbTotalCaixas.Name = "lbTotalCaixas";
            this.lbTotalCaixas.Size = new System.Drawing.Size(14, 13);
            this.lbTotalCaixas.TabIndex = 106;
            this.lbTotalCaixas.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(403, 324);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 105;
            this.label12.Text = "Total de caixas:";
            // 
            // lbTotalItens
            // 
            this.lbTotalItens.AutoSize = true;
            this.lbTotalItens.ForeColor = System.Drawing.Color.Red;
            this.lbTotalItens.Location = new System.Drawing.Point(706, 324);
            this.lbTotalItens.Name = "lbTotalItens";
            this.lbTotalItens.Size = new System.Drawing.Size(14, 13);
            this.lbTotalItens.TabIndex = 104;
            this.lbTotalItens.Text = "0";
            // 
            // lbPesoBruto
            // 
            this.lbPesoBruto.AutoSize = true;
            this.lbPesoBruto.ForeColor = System.Drawing.Color.Red;
            this.lbPesoBruto.Location = new System.Drawing.Point(271, 324);
            this.lbPesoBruto.Name = "lbPesoBruto";
            this.lbPesoBruto.Size = new System.Drawing.Size(14, 13);
            this.lbPesoBruto.TabIndex = 5;
            this.lbPesoBruto.Text = "0";
            // 
            // lbPesoLiquido
            // 
            this.lbPesoLiquido.AutoSize = true;
            this.lbPesoLiquido.ForeColor = System.Drawing.Color.Red;
            this.lbPesoLiquido.Location = new System.Drawing.Point(94, 324);
            this.lbPesoLiquido.Name = "lbPesoLiquido";
            this.lbPesoLiquido.Size = new System.Drawing.Size(14, 13);
            this.lbPesoLiquido.TabIndex = 4;
            this.lbPesoLiquido.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(611, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 103;
            this.label3.Text = "Total de itens:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 101;
            this.label2.Text = "Peso bruto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "Peso Liquido:";
            // 
            // gridDadosCarga
            // 
            this.gridDadosCarga.AllowUserToAddRows = false;
            this.gridDadosCarga.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridDadosCarga.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDadosCarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDadosCarga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fk_produto,
            this.dsc_produto,
            this.lote,
            this.qtd_produto});
            this.gridDadosCarga.Location = new System.Drawing.Point(3, 3);
            this.gridDadosCarga.Name = "gridDadosCarga";
            this.gridDadosCarga.ReadOnly = true;
            this.gridDadosCarga.RowHeadersVisible = false;
            this.gridDadosCarga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDadosCarga.Size = new System.Drawing.Size(734, 318);
            this.gridDadosCarga.TabIndex = 0;
            this.gridDadosCarga.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDadosCarga_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.btnAdicionar);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(762, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 341);
            this.panel2.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(37, 203);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 37);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(37, 92);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 37);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(37, 150);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 37);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.TabStop = false;
            this.btnEditar.Text = "LOCALIZAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(37, 34);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(112, 37);
            this.btnAdicionar.TabIndex = 17;
            this.btnAdicionar.TabStop = false;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnPesquisaProduto);
            this.panel3.Controls.Add(this.btnPesquisaCliente);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.txtCodProduto);
            this.panel3.Controls.Add(this.txtCodCliente);
            this.panel3.Controls.Add(this.txtPedido);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(935, 278);
            this.panel3.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(672, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Data carregamento*:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pedido*:";
            // 
            // btnPesquisaProduto
            // 
            this.btnPesquisaProduto.Location = new System.Drawing.Point(581, 35);
            this.btnPesquisaProduto.Name = "btnPesquisaProduto";
            this.btnPesquisaProduto.Size = new System.Drawing.Size(50, 23);
            this.btnPesquisaProduto.TabIndex = 9;
            this.btnPesquisaProduto.TabStop = false;
            this.btnPesquisaProduto.Text = "...";
            this.btnPesquisaProduto.UseVisualStyleBackColor = true;
            this.btnPesquisaProduto.Click += new System.EventHandler(this.btnPesquisaProduto_Click);
            // 
            // btnPesquisaCliente
            // 
            this.btnPesquisaCliente.Location = new System.Drawing.Point(213, 36);
            this.btnPesquisaCliente.Name = "btnPesquisaCliente";
            this.btnPesquisaCliente.Size = new System.Drawing.Size(52, 23);
            this.btnPesquisaCliente.TabIndex = 8;
            this.btnPesquisaCliente.TabStop = false;
            this.btnPesquisaCliente.Text = "...";
            this.btnPesquisaCliente.UseVisualStyleBackColor = true;
            this.btnPesquisaCliente.Click += new System.EventHandler(this.btnPesquisaCliente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cod. Produto*:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cod. Cliente*:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(818, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(107, 24);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.TabStop = false;
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtCodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProduto.Location = new System.Drawing.Point(475, 35);
            this.txtCodProduto.MaxLength = 5;
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(100, 24);
            this.txtCodProduto.TabIndex = 2;
            this.txtCodProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProduto_KeyPress);
            this.txtCodProduto.Leave += new System.EventHandler(this.txtCodProduto_Leave);
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCliente.Location = new System.Drawing.Point(106, 35);
            this.txtCodCliente.MaxLength = 5;
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(100, 24);
            this.txtCodCliente.TabIndex = 1;
            this.txtCodCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodCliente_KeyPress);
            this.txtCodCliente.Leave += new System.EventHandler(this.txtCodCliente_Leave);
            // 
            // txtPedido
            // 
            this.txtPedido.BackColor = System.Drawing.Color.Red;
            this.txtPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedido.Location = new System.Drawing.Point(73, 5);
            this.txtPedido.MaxLength = 8;
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(133, 24);
            this.txtPedido.TabIndex = 0;
            this.txtPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPedido_KeyPress);
            this.txtPedido.Leave += new System.EventHandler(this.txtPedido_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.gridLotes);
            this.groupBox2.Controls.Add(this.txtEstoqueAtual);
            this.groupBox2.Controls.Add(this.txtNomeProduto);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(372, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 206);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações do produto";
            // 
            // gridLotes
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridLotes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridLotes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridLotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quantidade,
            this.LOT});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridLotes.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridLotes.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridLotes.Location = new System.Drawing.Point(370, 17);
            this.gridLotes.Name = "gridLotes";
            this.gridLotes.RowHeadersVisible = false;
            this.gridLotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLotes.Size = new System.Drawing.Size(183, 186);
            this.gridLotes.TabIndex = 0;
            this.gridLotes.TabStop = false;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "qtd_produto";
            this.Quantidade.HeaderText = "QTD";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 90;
            // 
            // LOT
            // 
            this.LOT.DataPropertyName = "lote";
            this.LOT.HeaderText = "LOTE";
            this.LOT.Name = "LOT";
            this.LOT.ReadOnly = true;
            this.LOT.Width = 90;
            // 
            // txtEstoqueAtual
            // 
            this.txtEstoqueAtual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtEstoqueAtual.ForeColor = System.Drawing.Color.Black;
            this.txtEstoqueAtual.Location = new System.Drawing.Point(128, 47);
            this.txtEstoqueAtual.Name = "txtEstoqueAtual";
            this.txtEstoqueAtual.ReadOnly = true;
            this.txtEstoqueAtual.Size = new System.Drawing.Size(100, 21);
            this.txtEstoqueAtual.TabIndex = 4;
            this.txtEstoqueAtual.TabStop = false;
            this.txtEstoqueAtual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstoqueAtual_KeyPress);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(128, 21);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.ReadOnly = true;
            this.txtNomeProduto.Size = new System.Drawing.Size(225, 21);
            this.txtNomeProduto.TabIndex = 3;
            this.txtNomeProduto.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.btnAddLote);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtQtdTotal);
            this.groupBox3.Controls.Add(this.txtLote1);
            this.groupBox3.Controls.Add(this.txtQtd1);
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(9, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 126);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informação dos lotes";
            // 
            // btnAddLote
            // 
            this.btnAddLote.Location = new System.Drawing.Point(151, 79);
            this.btnAddLote.Name = "btnAddLote";
            this.btnAddLote.Size = new System.Drawing.Size(117, 23);
            this.btnAddLote.TabIndex = 30;
            this.btnAddLote.Text = "Adicionar lote";
            this.btnAddLote.UseVisualStyleBackColor = true;
            this.btnAddLote.Click += new System.EventHandler(this.btnAddLote_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(24, 64);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(33, 15);
            this.label29.TabIndex = 27;
            this.label29.Text = "Qtd:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(81, 64);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(39, 15);
            this.label26.TabIndex = 24;
            this.label26.Text = "Lote:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(3, 28);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(79, 15);
            this.label25.TabIndex = 23;
            this.label25.Text = "Qtd. Total*:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(62, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(12, 15);
            this.label15.TabIndex = 3;
            this.label15.Text = "-";
            // 
            // txtQtdTotal
            // 
            this.txtQtdTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtQtdTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdTotal.Location = new System.Drawing.Point(88, 25);
            this.txtQtdTotal.MaxLength = 5;
            this.txtQtdTotal.Name = "txtQtdTotal";
            this.txtQtdTotal.Size = new System.Drawing.Size(100, 26);
            this.txtQtdTotal.TabIndex = 3;
            this.txtQtdTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdTotal_KeyPress);
            this.txtQtdTotal.Leave += new System.EventHandler(this.txtQtdTotal_Leave);
            // 
            // txtLote1
            // 
            this.txtLote1.BackColor = System.Drawing.Color.White;
            this.txtLote1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLote1.Location = new System.Drawing.Point(80, 82);
            this.txtLote1.MaxLength = 6;
            this.txtLote1.Name = "txtLote1";
            this.txtLote1.Size = new System.Drawing.Size(59, 20);
            this.txtLote1.TabIndex = 5;
            this.txtLote1.Leave += new System.EventHandler(this.txtLote1_Leave);
            // 
            // txtQtd1
            // 
            this.txtQtd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtd1.Location = new System.Drawing.Point(19, 82);
            this.txtQtd1.MaxLength = 4;
            this.txtQtd1.Name = "txtQtd1";
            this.txtQtd1.Size = new System.Drawing.Size(37, 20);
            this.txtQtd1.TabIndex = 4;
            this.txtQtd1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtd1_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "Estoque Atual:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Nome Produto:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.txtNomeComprador);
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.lbComprador);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNomeCliente);
            this.groupBox1.Location = new System.Drawing.Point(4, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 197);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do cliente";
            // 
            // txtNomeComprador
            // 
            this.txtNomeComprador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeComprador.Location = new System.Drawing.Point(102, 157);
            this.txtNomeComprador.MaxLength = 50;
            this.txtNomeComprador.Name = "txtNomeComprador";
            this.txtNomeComprador.Size = new System.Drawing.Size(254, 21);
            this.txtNomeComprador.TabIndex = 9;
            this.txtNomeComprador.TabStop = false;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(102, 123);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(254, 21);
            this.txtEstado.TabIndex = 8;
            this.txtEstado.TabStop = false;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(102, 90);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.ReadOnly = true;
            this.txtCidade.Size = new System.Drawing.Size(254, 21);
            this.txtCidade.TabIndex = 7;
            this.txtCidade.TabStop = false;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(102, 56);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.ReadOnly = true;
            this.txtEndereco.Size = new System.Drawing.Size(254, 21);
            this.txtEndereco.TabIndex = 6;
            this.txtEndereco.TabStop = false;
            // 
            // lbComprador
            // 
            this.lbComprador.AutoSize = true;
            this.lbComprador.Location = new System.Drawing.Point(8, 160);
            this.lbComprador.Name = "lbComprador";
            this.lbComprador.Size = new System.Drawing.Size(82, 15);
            this.lbComprador.TabIndex = 5;
            this.lbComprador.Text = "Comprador:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Endereço:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Cidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nome:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(102, 24);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(254, 21);
            this.txtNomeCliente.TabIndex = 0;
            this.txtNomeCliente.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Fk_produto
            // 
            this.Fk_produto.DataPropertyName = "Fk_produto";
            this.Fk_produto.HeaderText = "ID";
            this.Fk_produto.Name = "Fk_produto";
            this.Fk_produto.ReadOnly = true;
            this.Fk_produto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Fk_produto.Width = 60;
            // 
            // dsc_produto
            // 
            this.dsc_produto.DataPropertyName = "dsc_produto";
            this.dsc_produto.HeaderText = "PRODUTO";
            this.dsc_produto.Name = "dsc_produto";
            this.dsc_produto.ReadOnly = true;
            this.dsc_produto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dsc_produto.Width = 295;
            // 
            // lote
            // 
            this.lote.DataPropertyName = "lote";
            this.lote.HeaderText = "LOTES";
            this.lote.Name = "lote";
            this.lote.ReadOnly = true;
            this.lote.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.lote.Width = 286;
            // 
            // qtd_produto
            // 
            this.qtd_produto.DataPropertyName = "qtd_produto";
            this.qtd_produto.HeaderText = "TOTAL";
            this.qtd_produto.Name = "qtd_produto";
            this.qtd_produto.ReadOnly = true;
            this.qtd_produto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.qtd_produto.Width = 90;
            // 
            // frmCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 649);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MOVIMENTAÇÃO DE CARGAS";
            this.Load += new System.EventHandler(this.frmCarga_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCarga_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDadosCarga)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLotes)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridDadosCarga;
        private System.Windows.Forms.Label lbTotalItens;
        private System.Windows.Forms.Label lbPesoBruto;
        private System.Windows.Forms.Label lbPesoLiquido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnPesquisaProduto;
        private System.Windows.Forms.Button btnPesquisaCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomeComprador;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lbComprador;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtEstoqueAtual;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtQtdTotal;
        private System.Windows.Forms.TextBox txtLote1;
        private System.Windows.Forms.TextBox txtQtd1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbTotalCaixas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAddLote;
        private System.Windows.Forms.DataGridView gridLotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fk_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsc_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd_produto;
    }
}