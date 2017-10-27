using CONTROL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmCarga : Form
    {
        private List<ModelLotes> listaLote = new List<ModelLotes>();
        private List<ModelLotes> listaLoteAux = new List<ModelLotes>();
        private List<ModelRegistro> listaRegistro = new List<ModelRegistro>();
        private Queue<ModelCalculaLotes> filaLotes = new Queue<ModelCalculaLotes>();
        private ModelCarga modeloCarga;
        private double pesoLiquido = 0, total1 = 0; 
        private double pesoBruto = 0, total2 = 0;
        private double totalCaixas = 0;

        public frmCarga()
        {
            InitializeComponent();
            gridDadosCarga.AutoGenerateColumns = false;
            gridLotes.AutoGenerateColumns = false;
        }

        private void frmCarga_Load(object sender, EventArgs e)
        {
            inicioBotoes();
            txtPedido.Focus();
            gridDadosCarga.AutoGenerateColumns = false;
        }

        private void btnPesquisaCliente_Click(object sender, EventArgs e)
        {
            frmPesquisaCliente frmPesquisa = new frmPesquisaCliente();
            ControleCliente control = new ControleCliente();
            frmPesquisa.ShowDialog();

            if (frmPesquisa.codigo !=0)
            {
                PreencheCampos(control.BuscaInt(frmPesquisa.codigo));
            }
            else
            {
                LimpaCampoCliente();
            }
        }

        private void btnPesquisaProduto_Click(object sender, EventArgs e)
        {
            frmPesquisaProduto frmPesquisa = new frmPesquisaProduto(1);
            ControleProduto control = new ControleProduto();
            frmPesquisa.ShowDialog();

            if (frmPesquisa.codigo != 0)
            {
                PreencheCamposProduto(control.BuscaInt(frmPesquisa.codigo));
            }
            else
            {
                LimpaCampoProduto();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmPesquisaSaida frmPesquisa = new frmPesquisaSaida(1);
            frmPesquisa.ShowDialog();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            if (!VerificaCamposCodigos())
            {
                PreencheCarga();

                foreach (var item in listaLoteAux)
                {
                    listaLote.Add(item);
                }
                PreencheListaRegistro();
                AtualizaGrid();
                AtualizaInfoCarga();
                LimpaCampoProduto();
                txtCodProduto.Focus();
                pesoBruto = 0;
                pesoLiquido = 0;

                gridLotes.DataSource = null;
                listaLoteAux.Clear();

                btnSalvar.Enabled = true;

            }
            else
            {
                MessageBox.Show("Preencha todos os campos para esta operação!","Operação invalida!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }                                                           
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ControleRegistro registro = new ControleRegistro();
            ControleLotes lotes = new ControleLotes();
            ControleCarga carga = new ControleCarga();

            if (carga.Inserir(modeloCarga))
            {
                if (registro.Inserir(listaRegistro))
                {
                    if (lotes.Inserir(listaLote))
                    {
                        LimpaCampoCliente();
                        LimpaCampoProduto();
                        inicioBotoes();
                        LimpaGrid();
                        txtPedido.Focus();
                    }
                    else
                    {
                        registro.Excluir(Convert.ToInt32(modeloCarga.Id_carga));
                        carga.Excluir(Convert.ToInt32(modeloCarga.Id_carga));                    
                        MessageBox.Show("Erro ao salvar os dados desta carga!!", "Operação Invalida - 3!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    carga.Excluir(Convert.ToInt32(modeloCarga.Id_carga));
                    MessageBox.Show("Erro ao salvar os dados desta carga!!", "Operação Invalida - 2!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Erro ao salvar os dados desta carga!!", "Operação Invalida - 1!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }          
        }       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inicioBotoes();
            LimpaCampoCliente();
            LimpaCampoProduto();
            LimpaGrid();
        }

        private void frmCarga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void gridDadosCarga_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int codigo = Convert.ToInt32(gridDadosCarga.Rows[e.RowIndex].Cells[0].Value);              

                //PERGUNTA SE DESEJA CADASTRAR UM NOVO CLIENTE
                DialogResult d = MessageBox.Show("Deseja remover este ITEM?", "AVISO!!", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    RemoverItemListaRegistro(codigo);
                    RemoverItemListalotes(codigo);
                    AtualizaInfoCarga();
                }
                else
                {
                    return;
                }
            }
        }

        private void txtPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtCodCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtCodProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtEstoqueAtual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtQtdTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtQtd1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtCodCliente_Leave(object sender, EventArgs e)
        {
            try
            {
                ControleCliente cliente = new ControleCliente();
                if (Convert.ToInt32(txtCodCliente.Text) == 298)
                {
                    lbComprador.Visible = true;
                    txtNomeComprador.Visible = true;
                }

                if (cliente.VerificaCliente(Convert.ToInt32(txtCodCliente.Text)) == null)
                {
                    //PERGUNTA SE DESEJA CADASTRAR UM NOVO CLIENTE
                    DialogResult d = MessageBox.Show("Cliente nao cadastro, DESEJA CADASTRAR AGORA ?", "AVISO!!", MessageBoxButtons.YesNo);
                    if (d.ToString() == "Yes")
                    {
                        frmCadClientes frm = new frmCadClientes();
                        frm.ShowDialog();
                        frm.Dispose();
                        if(frm.codigo != 0)
                            PreencheCampos(cliente.BuscaInt(Convert.ToInt32(frm.codigo)));

                        return;
                    }
                    else
                    {
                        txtCodCliente.Clear();
                        txtCodCliente.Focus();                
                        return;
                    }
                }
                else
                {
                    PreencheCampos(cliente.BuscaInt(Convert.ToInt32(txtCodCliente.Text)));
                }
            }
            catch
            {
               
            }
            
        }

        private void txtCodProduto_Leave(object sender, EventArgs e)
        {
            try
            {
                ControleProduto produto = new ControleProduto();
                ControleEstoqueAtual controle = new ControleEstoqueAtual();

                if (produto.VerificaProduto(Convert.ToInt32(txtCodProduto.Text)) == null)
                {
                    MessageBox.Show("O produto nao esta cadastrado","Operação Invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpaCampoProduto();
                    txtCodProduto.Clear();
                    txtCodProduto.Focus();
                }
                else
                {
                    PreencheCamposProduto(produto.BuscaInt(Convert.ToInt32(txtCodProduto.Text)));
                    filaLotes = controle.CalculaLotes(Convert.ToInt32(txtCodProduto.Text));
                }
                
            }
            catch
            {
                LimpaCampoProduto();
            }
        }

        private void txtPedido_Leave(object sender, EventArgs e)
        {
            ControleCarga carga = new ControleCarga();
            try
            {
                if (carga.verificaCarga(Convert.ToInt32(txtPedido.Text)) != null)
                {
                    MessageBox.Show("Esta carga ja foi cadastrada!!", "Operação Invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inicioBotoes();
                    txtPedido.Focus();
                    return;
                }
            }
            catch
            {           
                return;
            }
            
        }


        private void txtLote1_Leave(object sender, EventArgs e)
        {
            if (!VerificaCamposCodigos())
            {
                if (!VerificaLotesDisponiveis(Convert.ToDouble(txtQtd1.Text), txtLote1.Text))
                {
                    MessageBox.Show("Lote indisponivel", "Operação invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLote1.Clear();
                }
            }else
            {
                MessageBox.Show("Verifique se todos os campos estão preenchidos corretamente", "Operação invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLote1.Clear();
            }        
        }

        private void txtQtdTotal_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtQtdTotal.Text) > Convert.ToDouble(txtEstoqueAtual.Text))
                {
                    MessageBox.Show("Estoque insufuciente!", "Operação invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQtdTotal.Focus();
                }
            }
            catch
            {

            }
            
        }


        //==========================================================

        private void PreencheCarga()
        {
            modeloCarga = new ModelCarga();

            modeloCarga.Id_carga = Convert.ToInt32(txtPedido.Text);
            modeloCarga.Fk_cliente = Convert.ToInt32(txtCodCliente.Text);
            modeloCarga.data_carregamento = Convert.ToDateTime(dateTimePicker1.Text).ToString("yyyy-MM-dd 00:00:00");
            //SE O NOME DE COMPRADOR ESTIVER VAZIO NAO ADICIONA 
            if(!(txtNomeComprador.Text == string.Empty))
                modeloCarga.nome_comprador = txtNomeComprador.Text;
        }

        //CARREGA UM ALISTA COM OS LOTES DOS PRODUTOS
        private void PreencheListaLotes()
        {
            //CHECA CADA CAMPO SE ESTIVER COM ALGUM VALOR
            //ELE EXECUTA OS COMANDOS 
            ModelLotes modeloLotes;
            if (txtQtd1.Text != "" && txtLote1.Text != "")
            {
                modeloLotes = new ModelLotes();
                modeloLotes.Fk_carga = Convert.ToInt32(txtPedido.Text);
                modeloLotes.Fk_produto = Convert.ToInt32(txtCodProduto.Text);
                modeloLotes.qtd_produto = Convert.ToDouble(txtQtd1.Text);
                modeloLotes.lote = txtLote1.Text;
                listaLoteAux.Add(modeloLotes);
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!","Operação Invalida!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //ATUALIZA GRID DE LOTES DO LADO DOS CAMPOS DO PROUTO
        private void PrencheGridLote()
        {
            gridLotes.DataSource = null;
            gridLotes.Refresh();
            gridLotes.DataSource = listaLoteAux;
        }

        private void PreencheListaRegistro()
        {
            // 0 = entrada
            // 1 = saida
            ModelRegistro modeloRegistro = new ModelRegistro();

            modeloRegistro.Fk_carga = Convert.ToInt32(txtPedido.Text);
            modeloRegistro.Fk_produto = Convert.ToInt32(txtCodProduto.Text);
            modeloRegistro.dsc_produto = txtNomeProduto.Text;
            modeloRegistro.qtd_produto = Convert.ToDouble(txtQtdTotal.Text);
            modeloRegistro.data_operacao = Convert.ToDateTime(dateTimePicker1.Text).ToString("yyyy-MM-dd 00:00:00");
            modeloRegistro.tipo_operacao = 1;
            modeloRegistro.tipo_produto = 3; //DEFINI TIPO PRODUTO 3
            modeloRegistro.pesoBruto = pesoBruto * Convert.ToDouble(txtQtdTotal.Text); ;
            modeloRegistro.pesoLiquido = pesoLiquido * Convert.ToDouble(txtQtdTotal.Text); ;
            //ADICONA OS LOTES DO PEDIDO PARA EXIBIR NO GRID
            foreach (var item in listaLote)
            {
                if (modeloRegistro.Fk_produto == item.Fk_produto)
                {
                    modeloRegistro.lote += item.qtd_produto + "-" + item.lote + "/ ";
                }
            }

            listaRegistro.Add(modeloRegistro);
        }

        //METODO PARA ATUALIZAR O GRID
        private void AtualizaGrid()
        {
            gridDadosCarga.DataSource = null;
            gridDadosCarga.DataSource = listaRegistro;
            gridDadosCarga.Refresh();
        }

        //ATUALIZA OS PESOS E QUANTIDADES DOS ITENS DA CARGA
        private void AtualizaInfoCarga()
        {
            total1 = 0;
            total2 = 0;
            totalCaixas = 0;

            lbTotalItens.Text = Convert.ToString(listaRegistro.Count);
            foreach (var item in listaRegistro)
            {

                total1 += item.pesoLiquido;
                total2 += item.pesoBruto;
                totalCaixas += item.qtd_produto;
            }

            lbTotalCaixas.Text = Convert.ToString(string.Format("{0:N}", totalCaixas));
            lbPesoLiquido.Text = Convert.ToString(string.Format("{0:N}", total1));
            lbPesoBruto.Text = Convert.ToString(string.Format("{0:N}", total2));
        }

        private void inicioBotoes()
        {
            txtPedido.Focus();       
            lbComprador.Visible = false;
            txtNomeComprador.Visible = false;
            btnAdicionar.Enabled = true;
            btnEditar.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = true;
            txtPedido.Clear();
            lbPesoBruto.Text = "";
            lbPesoLiquido.Text = "";
            lbTotalItens.Text = "";
            lbTotalCaixas.Text = "";
            listaLote.Clear();
            listaRegistro.Clear();
            total1 = 0;
            total2 = 0;
            totalCaixas = 0;
        }

        private void PreencheCampos(DataTable tb)
        {
            txtCodCliente.Text = tb.Rows[0]["Id_cliente"].ToString();
            txtNomeCliente.Text = tb.Rows[0]["nome_cliente"].ToString();
            txtEndereco.Text = tb.Rows[0]["endereco"].ToString();
            txtCidade.Text = tb.Rows[0]["nome_cidade"].ToString();
            txtEstado.Text = tb.Rows[0]["nome_estado"].ToString();
        }

        private void PreencheCamposProduto(DataTable tb)
        {           
            txtCodProduto.Text = tb.Rows[0]["Id_produto"].ToString();
            txtNomeProduto.Text = tb.Rows[0]["dsc_produto"].ToString();
            txtEstoqueAtual.Text = Convert.ToString(ControleEstoqueAtual.CalculaEstoque(Convert.ToInt32(txtCodProduto.Text)));
            pesoLiquido = Convert.ToDouble(tb.Rows[0]["peso_liquido"].ToString());
            pesoBruto = Convert.ToDouble(tb.Rows[0]["peso_bruto"].ToString());
        }

        private void LimpaCampoCliente()
        {
            lbComprador.Visible = false;
            txtNomeComprador.Visible = false;
            txtCodCliente.Clear();
            txtNomeCliente.Clear();
            txtEndereco.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtNomeComprador.Clear();
        }

        private void LimpaCampoProduto()
        {
            txtCodProduto.Clear();
            txtNomeProduto.Clear();
            txtEstoqueAtual.Clear();
            txtQtdTotal.Clear();
            txtQtd1.Clear();
            txtLote1.Clear();
        }

        private void LimpaGrid()
        {
            gridDadosCarga.DataSource = null;
        }

        //METODO DE VERIFICAR SE O PRODUTO JA ESTA NA LISTA
        private bool VerificaProdLista(int cd)
        {
            //RETORNA TRUE OU FALSE< SE O PRODUTO JA ESTIVER NA LISTA DE COMPRA
            //return lisProduto.Any(l => l.Cd_produto == cd);
            foreach (var item in listaRegistro)
            {
                if (cd == item.Fk_produto)
                {
                    return true;
                }
            }
            return false;
        }

        //METODO DE VERIFICAR SE O PRODUTO JA ESTA NA LISTA
        private bool VerificaListaLotes(int cd_produto, string lote)
        {
            //RETORNA TRUE OU FALSE< SE O PRODUTO JA ESTIVER NA LISTA DE COMPRA
            //return lisProduto.Any(l => l.Cd_produto == cd);
            foreach (var item in listaLoteAux)
            {
                if (cd_produto == item.Fk_produto && lote.Equals(item.lote))
                {
                    return true;
                }
            }
            return false;
        }

        //METODO DE VERIFICAR SE OS CAMPOS COD_PEDIDO COD_CLIENTE ESTAO VAZIOS
        private bool VerificaCamposCodigos()
        {
            if (txtPedido.Text == string.Empty || txtCodCliente.Text == string.Empty || txtCodProduto.Text == string.Empty || txtQtdTotal.Text == string.Empty) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //METODO DE VERIFICAR SE OS CAMPOS CODIGO DO PRODUTO E QUATIDADE TOTAL
        private bool VerificaCamposCodigos2()
        {
            if (txtQtd1.Text == string.Empty || txtLote1.Text == string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        //VERIFICA A QUANTIDADE DIGITADA NOS CAMPOS DE LOTE E COMPARA COM A QUANTIDADE TOTAL
        private bool VerificaQuantidate()
        {
            double total = 0;
                      
            if (txtQtd1.Text != "")
                total += Convert.ToDouble(txtQtd1.Text);

            if (total <= Convert.ToInt32(txtQtdTotal.Text))
            {
                return true;
            }
            else
            {
                 return false;
            }                  
        }


        //VERIFICA SE O LOTE ESTA DISPONIVEL OU NAO
        private bool VerificaLotesDisponiveis(double quantidade, string lote)
        {
            foreach (var item in filaLotes)
            {
                if (Convert.ToInt32(txtCodProduto.Text) == item.Id_produto && quantidade <= (item.quantidade - item.total) && lote.Equals(item.lote))
                {
                    return true;
                }
            }
            return false;
        }

        private void btnAddLote_Click(object sender, EventArgs e)
        {

            if (VerificaCamposCodigos2())
            {
                if (VerificaQuantidate())
                {
                    if (!VerificaListaLotes(Convert.ToInt32(txtCodProduto.Text), txtLote1.Text))
                    {
                        if (!VerificaQuantidadeProdutos(Convert.ToInt32(txtCodProduto.Text)))
                        {
                            PreencheListaLotes();
                            PrencheGridLote();

                            txtQtd1.Clear();
                            txtLote1.Clear();

                            txtQtd1.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Verifique as quantidades digitadas!", "Operação invalida!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Produto e lote ja selecionados!", "Operação invalida!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                   
                }
                else
                {
                    MessageBox.Show("Quantidades invalidas!", "Operação invalida!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos obrigatorios!", "Operação invalida!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                    
        }


        //CALCULA QUANTIDADE DE CADA PRODUTO
        private bool VerificaQuantidadeProdutos(int cod_produto)
        {
            double aux = 0;

            //CALCULA A QUANTIDADE DE PRODUTO JA INSERIDO
            foreach (var item in listaLoteAux)
            {
                if (cod_produto == item.Fk_produto)
                {
                    aux += item.qtd_produto;
                }
            }

            //VERIFICA SE A QUANTIDADE JA INSERIDA É MAIOR QUE VALOR DIGITADO
            if (Convert.ToDouble(txtQtdTotal.Text) < aux + Convert.ToDouble(txtQtd1.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void gridLotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int codigo = Convert.ToInt32(txtCodProduto.Text);

                //PERGUNTA SE DESEJA CADASTRAR UM NOVO CLIENTE
                DialogResult d = MessageBox.Show("Deseja remover este ITEM?", "AVISO!!", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    RemoverItemListaLotes(codigo);
                    PrencheGridLote();
                }
                else
                {
                    return;
                }
            }
        }

        //METODO PARA REMOVER ITENS DA LISTA DE LOTES
        private void RemoverItemListaLotes(int codigo)
        {
            foreach (var item in listaLoteAux)
            {
                if (codigo == item.Fk_produto)
                {
                    //REMOVE O PRODUTO SELECIONADO
                    listaLoteAux.Remove(item);
                    //ATUALIZA O GRID COM A LISTA SEM O VALOR RETIRADO
                    PrencheGridLote();
                    return;
                }
            }
        }


        //METODO PARA REMOVER ITENS DA LISTA
        private void RemoverItemListaRegistro(int codigo)
        {
            foreach (var item in listaRegistro)
            {
                if (codigo == item.Fk_produto)
                {
                    //REMOVE O PRODUTO SELECIONADO
                    listaRegistro.Remove(item);
                    //ATUALIZA O GRID COM A LISTA SEM O VALOR RETIRADO
                    AtualizaGrid();
                    return;
                }
            }
        }

        //METODO PARA REMOVER ITENS DA LISTA
        private void RemoverItemListalotes(int codigo)
        {
            foreach (var item in listaLote)
            {
                if (codigo == item.Fk_produto)
                {
                    //REMOVE O PRODUTO SELECIONADO
                    listaLote.Remove(item);
                    //ATUALIZA O GRID COM A LISTA SEM O VALOR RETIRADO
                    AtualizaGrid();
                    return;
                }
            }
        }
    }
}
