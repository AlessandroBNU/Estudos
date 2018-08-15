using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
    interface IResposta
    {
        void IResponde(Requisicao req, Conta conta);
        IResposta OutraResposta { get; set; }
    }
}
