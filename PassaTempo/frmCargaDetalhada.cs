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
            lista = controlRegistro.PreencheListaProdutos(codigo);

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

        private void AtualizaGrid()
        {
            gridCarga.DataSource = null;
            gridCarga.DataSource = lista;
        }

        private void AtualizaInfo()
        {
            double aux = 0, aux1 = 0, aux2 = 0;
            foreach (var item in lista)
            {               
                aux += item.qtd_produto;
                aux1 += item.pesoLiquido;
                aux2 += item.pesoBruto;
            }
            lbTotalItens.Text = Convert.ToString(lista.Count);
            lbTotaCaixas.Text = Convert.ToString(aux);
            lbPesoLiquido.Text = Convert.ToString(aux1);
            lbPesoBruto.Text = Convert.ToString(aux2);
        }
    }
}
