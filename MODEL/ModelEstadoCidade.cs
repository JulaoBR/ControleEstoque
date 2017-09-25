using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class ModelEstadoCidade
    {
        public ModelEstadoCidade()
        {

        }

        public int Id_estado { get; set; }
        public int Id_cidade { get; set; }
        public string nome_estado { get; set; }
        public string nome_cidade { get; set; }
        public string endereco { get; set; }
        public string cep { get; set; }
    }
}
