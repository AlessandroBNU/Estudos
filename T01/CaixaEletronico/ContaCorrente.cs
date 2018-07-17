using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class ContaCorrente : Conta
    {
        public static int TotalDeContas { get; private set; }
        public ContaCorrente()
        {
            ContaCorrente.TotalDeContas++;
        }
        public static int ProximoNumero()
        {
            return ContaCorrente.TotalDeContas + 1;
        }
        public void Saca(double valor)
        {
            this.Saldo -= valor;
        }

    }
}
