using CONTROL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmCargaDetalhada : Form
    {
        private int codigo = 0;
        private double pesoLiquido = 0;
        private double pesoBruto = 0;
        private double totalCaixas = 0;
        private List<ModelRegistro> lista = new List<ModelRegistro>();

        public frmCargaDetalhada(int  codigo)
        {
            InitializeComponent();
            gridCarga.AutoGenerateColumns = false;
            this.codigo = codigo;
        }

        private void frmCargaDetalhada_Load(object sender, EventArgs e)
        {
            ControleCarga controlCarga = new ControleCarga();
            ControleRegistro controlRegistro = new ControleRegistro();

            txtPedido.Text = Convert.ToString(codigo);

            PreencheCampos(controlCarga.BuscaCargaDetalhada(codigo));
            PreencheListaProdutos(controlRegistro.LocalizarDadosCarga(codigo));

            AtualizaGrid();
            AtualizaInfo();
        }

        private void PreencheCampos(DataTable dt)
        {
            txtCodCliente.Text = dt.Rows[0]["Fk_cliente"].ToString();
            DateTime data = Convert.ToDateTime(dt.Rows[0]["data_carregamento"].ToString());
            txtDataCarregamento.Text = data.ToString("dd/MM/yyy");
            txtNomeCliente.Text = dt.Rows[0]["nome_cliente"].ToString();
            txtEndereco.Text = dt.Rows[0]["endereco"].ToString();
            txtCidade.Text = dt.Rows[0]["nome_cidade"].ToString();
            txtEstado.Text = dt.Rows[0]["nome_estado"].ToString();
            txtComprador.Text = dt.Rows[0]["nome_comprador"].ToString();

        }

        private void PreencheListaProdutos(DataTable dt)
        {
            //LOOP PARA JOGAR O DATATABLE EM UMA LISTA
            foreach (DataRow item in dt.Rows)
            {
                ModelRegistro model = new ModelRegistro();
                model.Fk_produto = Convert.ToInt32(item["Fk_produto"].ToString());
                model.dsc_produto = item["dsc_produto"].ToString();
                model.lote = item["lote"].ToString();
                model.qtd_produto = Convert.ToDouble(item["qtd_produto"].ToString());
                pesoLiquido += Convert.ToDouble(item["peso_liquido"].ToString()) * Convert.ToDouble(item["qtd_produto"].ToString());
                pesoBruto += Convert.ToDouble(item["peso_bruto"].ToString()) * Convert.ToDouble(item["qtd_produto"].ToString());
                totalCaixas += Convert.ToDouble(item["qtd_produto"].ToString());

                lista.Add(model);
            }
        }

        private void AtualizaGrid()
        {
            gridCarga.DataSource = null;
            gridCarga.DataSource = lista;
        }

        private void AtualizaInfo()
        {
            lbTotalItens.Text = Convert.ToString(lista.Count);
            lbPesoLiquido.Text = Convert.ToString(pesoLiquido);
            lbPesoBruto.Text = Convert.ToString(pesoBruto);
            lbTotaCaixas.Text = Convert.ToString(totalCaixas);
        }
    }
}
