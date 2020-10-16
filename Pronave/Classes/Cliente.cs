using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronave.Classes
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime created_at { get; set; }
        public int cpf { get; set; }
        public string posicao_financeiro { get; set; }
        public int id_endereco_cliente { get; set; }
        public int lista_negra { get; set; }
    }
}
