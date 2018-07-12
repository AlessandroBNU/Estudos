using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{

    class Conta
    {
        public int Numero { get; set; }
        public Cliente Titular { get; set; }
        public double Saldo { get; private set; }


        public void Deposita(double valorASerDepositado)
        {
            if (valorASerDepositado > 0)
            {
                this.Saldo += valorASerDepositado;
            }
        }
        
    }
}
