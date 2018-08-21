using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            CriadorDeNotaFiscal criador = new CriadorDeNotaFiscal();

            criador.ParaEmpresa("Caelum Ensino e Inovacao");
            criador.ComCnpj("23.456.789/0001-12");
            criador.ComItem(new ItemDaNotaBuilder("item 1", 100.0));
            criador.ComItem(new ItemDaNotaBuilder("item 2", 200.0));
            criador.NaData();
            criador.ComObservacoes("uma obs qualquer"); 

            NotaFiscal nf = criador.Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);

            Console.ReadKey();

            
        }
    }
}

