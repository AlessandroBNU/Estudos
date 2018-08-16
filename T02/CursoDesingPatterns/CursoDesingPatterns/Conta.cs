using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
    public class Conta
    {
        public string Titular { get; private set; }
        public double Saldo { get; private set; }
        public string Numero { get; internal set; }
        public string Agencia { get; internal set; }
        public string Nome { get; internal set; }
        public int Valor { get; internal set; }
        public DateTime DataAbertura { get; internal set; }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public Conta(string titular, double saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }
    }
}
