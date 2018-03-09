using DAO;
using MODEL;
using System.Data;

namespace CONTROL
{
    public class ControlePedido
    {
        private static DAOConexao cx = new DAOConexao(DadosConexao.StringConexao);
        private DAOPedido dao = new DAOPedido(cx);

        public ControlePedido()
        {

        }

        public void Inserir(ModelPedido modelo)
        {
            try
            {              
              dao.Inserir(modelo);               
            }
            catch { }            
        }


        public DataTable BuscaPedidos()
        {
            DAOPedido dao = new DAOPedido(cx);
            try
            {
               return dao.LocalizaPedidos();
            }
            catch
            {

            }
            return null;
        }
    }
}
