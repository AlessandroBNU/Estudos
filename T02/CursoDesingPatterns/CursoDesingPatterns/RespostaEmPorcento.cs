using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
    class RespostaEmPorcento : IResposta
    {
        public IResposta OutraResposta { get; set; }


        public RespostaEmPorcento(IResposta outraResposta)
        {
            this.OutraResposta = outraResposta;
        }

        public RespostaEmPorcento()
        {
            this.OutraResposta = null; //nao recebi a proxima!
        }

        public void IResponde(Requisicao req, Conta conta)
        {
            if(req.Formato == Formato.PORCENTO)
            {
                Console.WriteLine(conta.Titular + "%" + conta.Saldo);
            }
            else if(OutraResposta != null)
            {
                OutraResposta.IResponde(req, conta);
            }
            else
            {
                //não existe próxima na corrente, e ninguém atendeu a requisição !
                //poderíamos não ter feito nada aqui, caso não fosse necessário!
                throw new Exception("Formato de resposta não encontrado");
            }
        }
    }
}
