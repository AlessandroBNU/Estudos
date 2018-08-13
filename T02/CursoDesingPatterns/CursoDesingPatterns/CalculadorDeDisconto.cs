using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
   public class CalculadorDeDisconto
    {
        public double Calcula(Orcamento orcamento)
        {
            double desconto = new DescontoPorCincoItens().Desconto(orcamento);
            if(desconto == 0)
            {
                desconto = new DescontoPorMaisQuinhentosReais().Desconta(orcamento);
            }
            //if(desconto == 0) ...

            return desconto;
        }
    }
}
