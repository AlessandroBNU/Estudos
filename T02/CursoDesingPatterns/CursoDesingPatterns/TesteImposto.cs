using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
   public class TesteImposto
    {
        static void Main(String[] args)
        {
            Imposto imposto = new ISS(new ICMS(new ImpostoMuitoAlto()));
            Orcamento orcamento = new Orcamento(500.0);
            Console.WriteLine(imposto.Calcula(orcamento));

            
            
        }
    }
}
