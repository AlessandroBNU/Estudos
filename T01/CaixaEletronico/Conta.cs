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
        public double Saldo { get; protected set; }
        public int Tipo { get; set; }

    





        public void Deposita(double valor)
        {
            if (valor> 0)
            {
                this.Saldo += valor;
            }
        }
        public virtual void Saca(double valor)
        {   
                this.Saldo -= valor;
           
            
        }

    }
}
