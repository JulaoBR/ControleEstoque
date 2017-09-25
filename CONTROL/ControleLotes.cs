using DAO;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CONTROL
{
    public class ControleLotes
    {
        private static DAOConexao cx = new DAOConexao(DadosConexao.StringConexao);
        private DAOLotes dao = new DAOLotes(cx);

        public ControleLotes()
        {

        }

        public bool Inserir(List<ModelLotes> lista)
        {
            ModelLotes modelo;

            foreach (var item in lista)
            {
                modelo = new ModelLotes();
                modelo.Fk_carga = item.Fk_carga;
                modelo.Fk_produto = item.Fk_produto;
                modelo.qtd_produto = item.qtd_produto;
                modelo.lote = item.lote;

                if (!dao.Inserir(modelo))
                {                    
                    return false;
                }
            }

            return true;
        }


        public bool Excluir(int Id)
        {
            if (dao.Excluir(Id))
            {
                return true;
            }
            return false;
        }
       
    }
}
