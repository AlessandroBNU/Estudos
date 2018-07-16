using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class TotalizadorDeTributos
    {
        public double Total { get; private set; }

        public void Acumula(Tributavel cp)
        {
            this.Total += cp.CalculaTributo();
        }
        
        
    }
}
