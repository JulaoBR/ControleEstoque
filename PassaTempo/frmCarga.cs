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
            if (!VerificaCamposCodigos()) //VERIFICA SE TODOS OS CAMPOS FOROM PREENCHIDOS
            {
                if(Convert.ToInt32(txtQtdTotal.Text) <= Convert.ToInt32(txtEstoqueAtual.Text)) //VERIFICA SE TEM ESTOQUE SUFICIENTE PARA VENDA
                {
                    if (VerificaQuantidate()) //VERIFICA SE AS QUANTIDADES DIGITADAS CONFERE
                    {
                        if (!VerificaProdLista(Convert.ToInt32(txtCodProduto.Text))) //VERIFICA SE O PRODUTO JA FOI SELECIONADO
                        {
                            btnSalvar.Enabled = true;
                            if ((Convert.ToInt32(txtCodCliente.Text) == 298) && txtNomeComprador.Text == "") //CASO FOR CLIENTE SEM REGISTRO
                            {
                                MessageBox.Show("Informe o nome do comprador!!", "Operação Invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtNomeComprador.Focus();
                                return;
                            }

                            PreencheCarga();
                            PreencheListaLotes();
                            PreencheListaRegistro();
                            AtualizaGrid();
                            AtualizaInfoCarga();
                            LimpaCampoProduto();
                            txtCodProduto.Focus();
                            pesoBruto = 0;
                            pesoLiquido = 0;
                        }
                        else
                        {
                            LimpaCampoProduto();
                            MessageBox.Show("Este produto ja foi selecionado!", "Operação Invalida!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Verifique as quantidades digitadas!", "Operação Invalida!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Estoque insuficiente!", "Operação Invalida!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Operação Invalida!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if(!VerificaCamposCodigos())
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

        private void txtLote2_Leave(object sender, EventArgs e)
        {
            if (!VerificaCamposCodigos())
            {
                if (!VerificaLotesDisponiveis(Convert.ToDouble(txtQtd2.Text), txtLote2.Text))
                {
                    MessageBox.Show("Lote indisponivel", "Operação invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLote2.Clear();
                }
            }
            else
            {
                MessageBox.Show("Verifique se todos os campos estão preenchidos corretamente", "Operação invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLote1.Clear();
            }
        }

        private void txtLote3_Leave(object sender, EventArgs e)
        {
            if (!VerificaCamposCodigos())
            {
                if (!VerificaLotesDisponiveis(Convert.ToDouble(txtQtd3.Text), txtLote3.Text))
                {
                    MessageBox.Show("Lote indisponivel", "Operação invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLote3.Clear();                  
                }
            }
            else
            {
                MessageBox.Show("Verifique se todos os campos estão preenchidos corretamente", "Operação invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLote1.Clear();
            }
        }

        private void txtLote4_Leave(object sender, EventArgs e)
        {
            if (!VerificaCamposCodigos())
            {
                if (!VerificaLotesDisponiveis(Convert.ToDouble(txtQtd4.Text), txtLote4.Text))
                {
                    MessageBox.Show("Lote indisponivel", "Operação invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLote4.Clear();
                }
            }
            else
            {
                MessageBox.Show("Verifique se todos os campos estão preenchidos corretamente", "Operação invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLote1.Clear();
            }
        }

        private void txtLote5_Leave(object sender, EventArgs e)
        {
            if (!VerificaCamposCodigos())
            {
                if (!VerificaLotesDisponiveis(Convert.ToDouble(txtQtd5.Text), txtLote5.Text))
                {
                    MessageBox.Show("Lote indisponivel", "Operação invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLote5.Clear();
                }
            }
            else
            {
                MessageBox.Show("Verifique se todos os campos estão preenchidos corretamente", "Operação invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLote1.Clear();
            }
        }

        private void txtLote6_Leave(object sender, EventArgs e)
        {
            if (!VerificaCamposCodigos())
            {
                if (!VerificaLotesDisponiveis(Convert.ToDouble(txtQtd6.Text), txtLote6.Text))
                {
                    MessageBox.Show("Lote indisponivel", "Operação invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLote6.Clear();
                }
            }
            else
            {
                MessageBox.Show("Verifique se todos os campos estão preenchidos corretamente", "Operação invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLote1.Clear();
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
                listaLote.Add(modeloLotes);
            }

            //CHECA CADA CAMPO SE ESTIVER COM ALGUM VALOR
            //ELE EXECUTA OS COMANDOS 
            if (txtQtd2.Text != "" && txtLote2.Text != "")
            {
                modeloLotes = new ModelLotes();
                modeloLotes.Fk_carga = Convert.ToInt32(txtPedido.Text);
                modeloLotes.Fk_produto = Convert.ToInt32(txtCodProduto.Text);
                modeloLotes.qtd_produto = Convert.ToDouble(txtQtd2.Text);
                modeloLotes.lote = txtLote2.Text;
                listaLote.Add(modeloLotes);
            }

            //CHECA CADA CAMPO SE ESTIVER COM ALGUM VALOR
            //ELE EXECUTA OS COMANDOS 
            if (txtQtd3.Text != "" && txtLote3.Text != "")
            {
                modeloLotes = new ModelLotes();
                modeloLotes.Fk_carga = Convert.ToInt32(txtPedido.Text);
                modeloLotes.Fk_produto = Convert.ToInt32(txtCodProduto.Text);
                modeloLotes.qtd_produto = Convert.ToDouble(txtQtd3.Text);
                modeloLotes.lote = txtLote3.Text;
                listaLote.Add(modeloLotes);
            }

            //CHECA CADA CAMPO SE ESTIVER COM ALGUM VALOR
            //ELE EXECUTA OS COMANDOS 
            if (txtQtd4.Text != "" && txtLote4.Text != "")
            {
                modeloLotes = new ModelLotes();
                modeloLotes.Fk_carga = Convert.ToInt32(txtPedido.Text);
                modeloLotes.Fk_produto = Convert.ToInt32(txtCodProduto.Text);
                modeloLotes.qtd_produto = Convert.ToDouble(txtQtd4.Text);
                modeloLotes.lote = txtLote4.Text;
                listaLote.Add(modeloLotes);
            }

            //CHECA CADA CAMPO SE ESTIVER COM ALGUM VALOR
            //ELE EXECUTA OS COMANDOS 
            if (txtQtd5.Text != "" && txtLote5.Text != "")
            {
                modeloLotes = new ModelLotes();
                modeloLotes.Fk_carga = Convert.ToInt32(txtPedido.Text);
                modeloLotes.Fk_produto = Convert.ToInt32(txtCodProduto.Text);
                modeloLotes.qtd_produto = Convert.ToDouble(txtQtd5.Text);
                modeloLotes.lote = txtLote5.Text;
                listaLote.Add(modeloLotes);
            }

            //CHECA CADA CAMPO SE ESTIVER COM ALGUM VALOR
            //ELE EXECUTA OS COMANDOS 
            if (txtQtd6.Text != "" && txtLote6.Text != "")
            {
                modeloLotes = new ModelLotes();
                modeloLotes.Fk_carga = Convert.ToInt32(txtPedido.Text);
                modeloLotes.Fk_produto = Convert.ToInt32(txtCodProduto.Text);
                modeloLotes.qtd_produto = Convert.ToDouble(txtQtd6.Text);
                modeloLotes.lote = txtLote6.Text;
                listaLote.Add(modeloLotes);
            }

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
            txtQtd2.Clear();
            txtQtd3.Clear();
            txtQtd4.Clear();
            txtQtd5.Clear();
            txtQtd6.Clear();
            txtLote1.Clear();
            txtLote2.Clear();
            txtLote3.Clear();
            txtLote4.Clear();
            txtLote5.Clear();
            txtLote6.Clear();
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

        //METODO DE VERIFICAR SE OS CAMPOS COD_PEDIDO COD_CLIENTE COD_PRODUTO ESTAO VAZIOS
        private bool VerificaCamposCodigos()
        {

            if (txtPedido.Text == string.Empty || txtCodCliente.Text == string.Empty || txtCodProduto.Text == string.Empty || txtQtdTotal.Text == string.Empty )
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //VERIFICA A QUANTIDADE DIGITADA NOS CAMPOS DE LOTE E COMPARA COM A QUANTIDADE TOTAL
        private bool VerificaQuantidate()
        {
            double total = 0;

            if (txtQtd1.Text != "")
                total += Convert.ToDouble(txtQtd1.Text);
            if (txtQtd2.Text != "")
                total += Convert.ToDouble(txtQtd2.Text);
            if (txtQtd3.Text != "")
                total += Convert.ToDouble(txtQtd3.Text);
            if (txtQtd4.Text != "")
                total += Convert.ToDouble(txtQtd4.Text);
            if (txtQtd5.Text != "")
                total += Convert.ToDouble(txtQtd5.Text);
            if (txtQtd6.Text != "")
                total += Convert.ToDouble(txtQtd6.Text);

            if (total == Convert.ToInt32(txtQtdTotal.Text))
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
                if (Convert.ToInt32(txtCodProduto.Text) == item.Id_produto && quantidade <= item.quantidade && lote.Equals(item.lote))
                {
                    return true;
                }
            }

            return false;
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
