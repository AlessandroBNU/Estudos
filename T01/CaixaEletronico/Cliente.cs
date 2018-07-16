﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
   class Cliente
    {
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public int Idade { get; set; }
        public bool EEmancipado { get; set; }


        public bool PodeAbrirConta()
        {
            var maiorDeIdade = (this.Idade >= 18);
            var emancipado = (this.EEmancipado);
            var temCpf = !string.IsNullOrEmpty(this.Cpf);

            return (maiorDeIdade || emancipado) && temCpf;
        }
        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public Cliente() { }

        public bool EhMaiorDeIdade()
        {
            return this.Idade >= 18;
        }
    }
}

