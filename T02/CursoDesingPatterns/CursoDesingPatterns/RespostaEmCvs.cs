using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
    class RespostaEmCvs : IResposta
    {
        public IResposta OutraResposta { get; set; }

        public void IResponde(Requisicao req, Conta conta)
        {
            if(req.Formato == Formato.CSV)
            {
                Console.WriteLine(conta.Titular + ";" + conta.Saldo);
            }
            else
            {
                OutraResposta.IResponde(req, conta);
            }
        }
    }
}
