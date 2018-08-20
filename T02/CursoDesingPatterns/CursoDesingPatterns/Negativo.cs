using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
    public class Negativo : EstadoDaConta
    {
        public void Deposita(Conta c, double valor)
        {
            c.Saldo += valor * 0.95;
            if (c.Saldo > 0) c.Estado = new Positivo();
        }

        public void Saca(Conta c, double valor)
        {
            throw new Exception("Sua conta está no vermelho. Não é possivel sacar!");
        }
    }
}
