using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
   public class NotaFiscalBuilder
    {
        private string RazaSocial { get; set; }
        private string Cnpj { get; set; }
        public List<ItemDaNotaBuilder> todosItens = new ArrayList<ItemDaNotaBuilder>();

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }
    }
}
