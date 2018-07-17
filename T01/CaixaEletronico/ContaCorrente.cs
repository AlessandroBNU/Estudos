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
        public override void Saca(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException();
            }
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
                
            }
            else
            {
                throw new SaldoIE();
            }
        }

    }
}
