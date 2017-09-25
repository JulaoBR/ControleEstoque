using CONTROL;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmPesquisaEstoque : PassaTempo.frmTelaDePesquisa
    {
        private int tipoOperacao = 0;

        public frmPesquisaEstoque()
        {
            InitializeComponent();
            gridProduto.AutoGenerateColumns = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaEstoque_Load(sender, e);
        }

        private void frmPesquisaEstoque_Load(object sender, EventArgs e)
        {

            if (rbProdutoFinal.Checked)
            {
                tipoOperacao = 1;
            }else if (rbMateriaPrima.Checked)
            {
                tipoOperacao = 0;
            }
            var lista = ControleEstoqueAtual.BuscaDados(tipoOperacao, txtPesquisa.Text);
            PreencheGrid(lista);
           
        }


        private void PreencheGrid(List<ModelProduto> lista)
        {
            gridProduto.DataSource = null;
            gridProduto.DataSource = lista;
            ColorirCelulaEstoque(lista);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaGrid();
        }

        //METODO PARA COLORIR AS LINHAS DO GRID ESTOQUE
        private void ColorirCelulaEstoque(List<ModelProduto> Lista)
        {
            int cont = 0;
            int i = 0;
            foreach (var item in Lista)
            {
                if (item.qtd_estoque < item.qtd_minimo)
                {
                    DataGridViewRow row = gridProduto.Rows[i];
                    row.DefaultCellStyle.BackColor = Color.Red;
                    cont++;
                }

                i++;
            }           
        }

        private void LimpaGrid()
        {
            txtPesquisa.Clear();
            rbProdutoFinal.Checked = true;
            gridProduto.DataSource = null;
            gridProduto.Refresh();
        }

    }
}
