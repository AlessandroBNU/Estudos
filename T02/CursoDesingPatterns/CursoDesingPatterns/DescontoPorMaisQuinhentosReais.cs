using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
   public class DescontoPorMaisQuinhentosReais : IDesconto
    {
        public IDesconto Proximo { get; set; }
        public double Desconto(Orcamento orcamento)
        {
            if (orcamento.Valor >= 500)
            {
                return orcamento.Valor * 0.07;
            }

            return Proximo.Desconto(orcamento);
        }
    }
}
