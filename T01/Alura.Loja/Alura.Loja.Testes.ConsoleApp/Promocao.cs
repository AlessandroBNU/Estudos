﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class Promocao
    {
        public int Id { get; set; }
        public string Descricao { get; internal set; }
        public DateTime DataInicia { get; internal set; }
        public DateTime DataTermino { get; internal set; }
        public IList<Produto> Produtos { get; internal set; }
    }
}
