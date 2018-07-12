using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{

    class Conta
    {

        public int numero { get; set; }

        public double Saldo { get; private set; }

        public Cliente Titular { get; set; }

        public void Saca(double valor)
        {
            this.Saldo -= valor + 0.1;
        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }
    }
}
