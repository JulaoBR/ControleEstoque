using DAO;
using MODEL;
using System;
using System.Data;
using System.Windows.Forms;

namespace CONTROL
{
    public class ControleCarga
    {
        private static DAOConexao cx = new DAOConexao(DadosConexao.StringConexao);
        private DAOCarga dao = new DAOCarga(cx);

        public ControleCarga()
        {

        }

        public bool Inserir(ModelCarga modelo)
        {
            if (dao.Inserir(modelo))
            {
                return true;
            }
            return false;
        }

        public bool Excluir(int Id)
        {
            if (dao.Excluir(Id))
            {
                return true;
            }
            return false;
        }

        public DataTable BuscaCarga(int opcao, string valor)
        {
            DAOCarga dao = new DAOCarga(cx);
            try
            {
                if (opcao == 1)
                {
                    return dao.LocalizaPorString(valor);
                }
                else if (opcao == 2)
                {
                    return dao.LocalizarPorInt(Convert.ToInt32(valor));
                }
                else if (opcao == 3)
                {
                    return dao.LocalizaPorString(valor);
                }
            }
            catch
            {
                
            }
            return null;
        }

        public DataTable BuscaCargaDetalhada(int valor)
        {
            DAOCarga dao = new DAOCarga(cx);
            return dao.LocalizarCargaDetalhada(valor);
        }

        //METODO EXCALAR PARA VERIFICAR SE JA TEM CADASTRO 
        public object verificaCarga(int valor)
        {
            return dao.VerificaCarga(valor);
        }
    }
}
