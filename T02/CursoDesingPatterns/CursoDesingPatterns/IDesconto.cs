using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
   public interface IDesconto
    {
        double Desconto(Orcamento orcamento);
        IDesconto Proximo { private get; set; }
    }
}
