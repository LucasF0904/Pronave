using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronave.Classes
{
    public class Endereco_Cliente
    {
        public int id { get; set; }
        public int cep { get; set; }
        public string rua { get; set; }
        public string bairro { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
    }
}
