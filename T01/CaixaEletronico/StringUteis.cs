using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benner.CaixaEletronico.Sistema
{
    class StringUteis
    {
        public static string Pluralize(string texto)
        {
            if (texto.EndsWith("s"))
            {
                return texto;
            }
            else
            {
                return texto + "s";
            }
        }

    }
}
