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
            Imposto iss = new ISS();

            Orcamento orcamento = new Orcamento(500);

          double valor = iss.Calcula(orcamento);

            Console.WriteLine(valor);

            Console.ReadKey();
        }
    }
}

//static void Main(string[] args)
// {
//     CalculadorDeDesconto calculador = new CalculadorDeDesconto();

//     Orcamento orcamento = new Orcamento(500);
//     orcamento.AdicionaItem(new Item("CANETA", 250));
//     orcamento.AdicionaItem(new Item("LAPIS", 250));
//     orcamento.AdicionaItem(new Item("CADERNO", 250));
//     orcamento.AdicionaItem(new Item("MOCHILA", 250));
//     orcamento.AdicionaItem(new Item("PENAL", 250));
//     orcamento.AdicionaItem(new Item("XBOX", 250));

//     double desconto = calculador.Calcula(orcamento);
//     Console.WriteLine(desconto);

//     Console.ReadKey();


// }