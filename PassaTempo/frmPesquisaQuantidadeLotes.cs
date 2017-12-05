using CONTROL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;

namespace PassaTempo
{
    public partial class frmPesquisaQuantidadeLotes : PassaTempo.frmTelaDePesquisa
    {
        private int tipoProduto = 1;

        public frmPesquisaQuantidadeLotes()
        {
            InitializeComponent();
            gridLotes.AutoGenerateColumns = false;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaQuantidadeLotes_Load(sender, e);
        }

        private void frmPesquisaQuantidadeLotes_Load(object sender, EventArgs e)
        {
            QuantidadeLotes();
        }

        private void QuantidadeLotes()
        {
            List<ModelRegistro> lista = new List<ModelRegistro>();
            ControleProduto produto = new ControleProduto();
            ControleEstoqueAtual estoque = new ControleEstoqueAtual();
            ModelRegistro registro;
            var listaProduto = produto.BuscaString(txtPesquisa.Text, tipoProduto);

            foreach (DataRow item in listaProduto.Rows)
            {
                var fila = estoque.CalculaLotes(Convert.ToInt32(item["ID"].ToString()));

                foreach (var item2 in fila)
                {
                    registro = new ModelRegistro();

                    registro.Id_produto = item2.Id_produto;                  
                    registro.Dsc_produto = item["PRODUTO"].ToString();
                    registro.lote = Convert.ToString(item2.lote + " - " + item2.restante);

                    lista.Add(registro);
                }
            }

            PreencheGrid(lista);
        }

        private void PreencheGrid(List<ModelRegistro> lista)
        {
            gridLotes.DataSource = null;
            gridLotes.DataSource = lista;
        }
    }
}
