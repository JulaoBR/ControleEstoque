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

        public bool Inserir(ModelPedido modelo)
        {
            try
            {              
              return dao.Inserir(modelo);               
            }
            catch { }
            
            return false;
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
