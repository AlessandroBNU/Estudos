using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
   public class Orcamento
    {
        public double valor { get; private set; }

        public Orcamento(double valor)
        {
            this.valor = valor;
        }
    }
}
