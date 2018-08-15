using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }
        public double Desconto(Orcamento orcamento)
        {
            if (aconteceuVendaCasadaEm(orcamento)) return orcamento.Valor * 0.5;
            else return Proximo.Desconto(orcamento);
        }    
           private bool aconteceuVendaCasadaEm(Orcamento orcamento)
            {
                return existe("CANETA", orcamento) && existe("LAPIS", orcamento);
            }

            private bool existe(string nomeItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeItem)) return true;
            }
            return false;
        }
        
    }
}
