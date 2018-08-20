using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
   public class Positivo : EstadoDaConta
    {
        public void Deposita(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.98;
        }

        public void Saca(Conta c, double valor)
        {
            c.Saldo -= valor;

            if (c.Saldo < 0) c.Estado = new Negativo();
        }
    }
}
