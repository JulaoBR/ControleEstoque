using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.BD
{
    public class DAOConexao
    {
        //ATRIBUTOS PRIVADOS
        private String _stringConexao;
        private SQLiteConnection _conexao;

        //CONSTRUTOR
        public DALConexao(String dadosConexao)
        {
            this._conexao = new SQLiteConnection();
            this._stringConexao = dadosConexao;
            this._conexao.ConnectionString = dadosConexao;
        }

        //PROPRIEDADE PARA OS ATRIBUTOS PRIVADOS
        public String StringConexao
        {
            get { return this._stringConexao; }
            set { this._stringConexao = value; }
        }

        //PROPRIEDADE SQLITE CONEXAO 
        public SQLiteConnection ObjetoConexao
        {
            get { return this._conexao; }
            set { this._conexao = value; }
        }

        //METODO DE CONECTAR NO BANCO
        public void Conectar()
        {
            if (_conexao != null)
            {
                _conexao.Close();
            }

            try
            {
                this._conexao.Open();
            }
            catch (SQLiteException erro)
            {
                MessageBox.Show("Erro Na conexao com o banco!! " + erro);
            }

        }

        //METODO DE DESCONECTAR DO BANCO
        public void Desconectar()
        {

            try
            {
                this._conexao.Close();
            }
            catch (SQLiteException erro)
            {
                MessageBox.Show("Erro ao desconectar do banco!! " + erro);
            }

        }
    }
}
