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
        public double Saldo { get; set; }
        public EstadoDaConta Estado;
        public string Numero { get; internal set; }
        public string Agencia { get; internal set; }
        public string Nome { get; internal set; }
        public int Valor { get; internal set; }
        public DateTime DataAbertura { get; internal set; }
        
        public void Deposita(double valor)
        {
            Estado.Deposita(this, valor);
        }

        public void Saca(double valor)
        {
            Estado.Saca(this, valor);
        }

        public Conta(string titular, double saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }
    }
}
