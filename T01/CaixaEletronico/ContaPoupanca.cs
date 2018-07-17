﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class ContaPoupanca : Conta, ITributavel 
    {
        public override void  Saca(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException();
            }
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor + 0.1;
                
            }
            else
            {
                throw new SaldoIE();
            }
        }
        public void CalculaInvestimento()
        {

        }
        public double CalculaTributo()
        {
            return this.Saldo * 0.02;
        }
        public double CalculaTributos()
        {
            return this.Saldo * 0.02;
        }
    } 
}
