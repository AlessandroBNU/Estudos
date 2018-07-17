using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Benner.CaixaEletronico.Contas;
using Benner.CaixaEletronico.Tri;
using Benner.CaixaEletronico.FormP;

namespace Benner.CaixaEletronico.CIv
{
    class ContaInvestimento : Conta, Tributavel
    {
        public  void Saca(double valor)
        {
            this.Saldo -= valor;
        }

        public double CalculaTributo()
        {
            return this.Saldo * 0.02;
        }
    }


}

