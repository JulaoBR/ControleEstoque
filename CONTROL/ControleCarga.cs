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

        public DataTable BuscaCarga(int opcao, string valor, string data)
        {
            DAOCarga dao = new DAOCarga(cx);
            try
            {
                if (opcao == 1)
                {
                    return dao.LocalizaPorString(valor, data);
                }
                else if (opcao == 2)
                {
                    return dao.LocalizarPorInt(Convert.ToInt32(valor));
                }               
            }
            catch
            {
                
            }
            return null;
        }

        public ModelRelatorioCargaDetalhada BuscaCargaDetalhada(int valor)
        {
            try
            {
                DAOCarga dao = new DAOCarga(cx);
                ModelRelatorioCargaDetalhada carga = new ModelRelatorioCargaDetalhada();
                var dt = dao.LocalizarCargaDetalhada(valor);

                carga.cod_carga = valor;
                carga.cod_cliente = Convert.ToInt32(dt.Rows[0]["Fk_cliente"].ToString());
                carga.dsc_cliente = dt.Rows[0]["nome_cliente"].ToString();
                carga.endereco = dt.Rows[0]["endereco"].ToString();
                carga.nome_cidade = dt.Rows[0]["nome_cidade"].ToString();
                carga.nome_estado = dt.Rows[0]["nome_estado"].ToString();
                carga.cep = dt.Rows[0]["cep"].ToString();
                carga.comprador = dt.Rows[0]["nome_comprador"].ToString();
                carga.carregamento = dt.Rows[0]["data_carregamento"].ToString();

                return carga;
            }
            catch
            {
                return null;
            }
           
        }

        //METODO EXCALAR PARA VERIFICAR SE JA TEM CADASTRO 
        public object verificaCarga(int valor)
        {
            return dao.VerificaCarga(valor);
        }
    }
}
