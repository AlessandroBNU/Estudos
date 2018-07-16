﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class ContaPoupanca : Conta, ITributavel 
    {
        public  void Saca(double valor)
        {
            this.Saldo -= valor + 0.1;
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
