using CONTROL;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmTelaConfiguracao : Form
    {
        private int controle_botes = 0;     //BOTOES DA TELA DE MENU
        private int item_lista_menu = 0;    //O TIPO DE PRODUTO QUE SERA EXIBIDO
        private int lista_menu = 0;         //EXIBIR A LISTA DE ESTOQUE DO PRODUTO
        private ModelConfiguracao model;

        public frmTelaConfiguracao()
        {
            InitializeComponent();
        }

        private void checkListaProdutos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkListaProdutos.Checked)
            {
                rbMateriaPrima.Enabled = true;
                rbProdutoFinal.Enabled = true;
                lista_menu = 1;
            }
            else
            {
                //DESABILITA OS RADIONS BUTTONS
                rbMateriaPrima.Enabled = false;
                rbProdutoFinal.Enabled = false;

                //DESMARCA RADION BUTTONS
                rbMateriaPrima.Checked = false;
                rbProdutoFinal.Checked = false;

                lista_menu = 0;
            }
        }

        private void PreencheModelo()
        {
            ModelConfiguracao model = new ModelConfiguracao();
            ControleConfiguracao control = new ControleConfiguracao();

            model.Id_tabela = 1;
            model.controle_botoes_menu = controle_botes;
            model.lista_produto_menu = lista_menu;
            model.item_lista_produto_menu = item_lista_menu;

            control.UpdadeConfiguracao(model);
            
        }

        private void checkBotoesAtalho_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBotoesAtalho.Checked == true)
            {
                controle_botes = 1;
            }
            else
            {
                controle_botes = 0;
            }
        }

        private void rbProdutoFinal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbProdutoFinal.Checked == true)
            {
                item_lista_menu = 1;
            }
            else
            {
                item_lista_menu = 0;
            }
        }

        private void rbMateriaPrima_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMateriaPrima.Checked == true)
            {
                item_lista_menu = 2;
            }
            else
            {
                item_lista_menu = 0;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            PreencheModelo();
        }

        private void frmTelaConfiguracao_Load(object sender, EventArgs e)
        {
            model = ControleConfiguracao.BuscaValor();

            if (model.controle_botoes_menu == 1)
            {
                checkBotoesAtalho.Checked = true;
            }
            else
            {
                checkBotoesAtalho.Checked = false;
            }

            if (model.lista_produto_menu == 1)
            {
                checkListaProdutos.Checked = true;
            }
            else
            {
                checkListaProdutos.Checked = false;
            }

            if (model.item_lista_produto_menu == 1)
            {
                rbProdutoFinal.Checked = true;
            }
            else
            {
                rbProdutoFinal.Checked = false;
            }

            if (model.item_lista_produto_menu == 2)
            {
                rbMateriaPrima.Checked = true;
            }
            else
            {
                rbMateriaPrima.Checked = false;
            }
        }
    }
}
