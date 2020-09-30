using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronave.Classes
{
    public class Estoque_Matriz
    {
        public int codigo { get; set; }
        public string descricao { get; set; }
        public int estoque_atual { get; set; }
        public int estoque_anterior { get; set; }
        public double custo { get; set; }
        public int formas_pagto { get; set; }
    }
}
