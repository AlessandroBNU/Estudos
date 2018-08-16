using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
   public abstract class FiltroMenorQue100Reais : Filtro
    {
        public FiltroMenorQue100Reais(Filtro outroFiltro) : base(outroFiltro) { }
        public FiltroMenorQue100Reais() : base() { }
        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> filtrada = new List<Conta>();
            foreach(Conta c in contas)
            {
                if (c.Valor < 100) filtrada.Add(c);
            }
            foreach(Conta c in Proximo(contas))
            {
                filtrada.Add(c);
            }
            return filtrada;
        }
    }
}
