﻿using CONTROL;
using System;
using System.Data;
using System.Windows.Forms;

namespace PassaTempo
{
    public partial class frmPesquisaEntrada : PassaTempo.frmTelaDePesquisa
    {

        public int codigo = 0;

        public frmPesquisaEntrada()
        {
            InitializeComponent();
        }

        private void frmPesquisaEntrada_Load(object sender, EventArgs e)
        {
            ControleRegistro registro = new ControleRegistro();
            PreencheGrid(registro.BuscaString(txtPesquisa.Text));
        }

        private void rbPesquisaNome_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaData.ReadOnly = true;
            txtPesquisa.ReadOnly = false;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaData.ReadOnly = false;
            txtPesquisa.ReadOnly = true;
        }


        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaData.ReadOnly = false;
            txtPesquisa.ReadOnly = true;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaData.ReadOnly = true;
            txtPesquisa.ReadOnly = false;
        }

   

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimparPesquisa_Click(object sender, EventArgs e)
        {

        }

        private void txtPesquisaData_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControleFormato.FormataData(ref txtPesquisaData);
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void LimpaGrid()
        {
            gridEntrada.DataSource = null;
            gridEntrada.Refresh();
        }

        private void PreencheGrid(DataTable tb)
        {
            gridEntrada.DataSource = tb;
        }

        private void gridEntrada_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    this.codigo = Convert.ToInt32(gridEntrada.Rows[e.RowIndex].Cells[0].Value);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Sem dados para selecionar!!", "Operação Invalida!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
