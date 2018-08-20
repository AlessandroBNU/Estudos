using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
    public interface EstadoDaConta
    {
        void Saca(Conta c, double valor);
        void Deposita(Conta c, double valor);
    }
}
