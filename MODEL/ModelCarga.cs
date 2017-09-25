
namespace MODEL
{
    public class ModelCarga
    {
        public ModelCarga()
        {

        }

        public int Id_carga{ get; set; }     //CHAVE PRIMARIA
        public int Fk_cliente { get; set; }     //CHAVE ESTRANGEIRA
        public string data_carregamento { get; set; }
        public string nome_comprador { get; set; }

    }
}
