
namespace MODEL
{
    public class ModelCalculaLotes : ModelRegistro
    {
        public ModelCalculaLotes()
        {
            
        }

        public int Id_lote { set; get; }
        public double quantidade { set; get; }
        public double total { set; get; }
        public double restante { set; get; }

    }
}
