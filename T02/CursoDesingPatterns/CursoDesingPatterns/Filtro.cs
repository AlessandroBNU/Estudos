using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
  public abstract  class Filtro
    {
        protected Filtro OutroFilto { get; set; }

        public Filtro(Filtro OutroFiltro)
        {
            this.OutroFilto = OutroFilto;
        }

        public Filtro() { }
        public abstract IList<Conta> Filtra(IList<Conta> contas);
        protected IList<Conta> Proximo(IList<Conta> contas)
        {
            if (OutroFilto != null) return OutroFilto.Filtra(contas);
            else return new List<Conta>();
        }
    }
}
