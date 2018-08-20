using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
    public class NotaFiscal
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataDeEmissao { get; set; }
        public double ValorBruto { get; set; }
        public double Impostos { get; set; }
        public IList<ItemDaNota> Itens { get; set; }
        public string Observacoes { get; set; }

        public NotaFiscal(String razaoSocial, string cnpj, DateTime dataDeEmissao,
            double valorBruto, double impostos, IList<ItemDaNota> itens,
            string observacoes)
        {
            this.RazaoSocial = razaoSocial;
            this.Cnpj = cnpj;
            this.DataDeEmissao = dataDeEmissao;
            this.ValorBruto = valorBruto;
            this.Impostos = Impostos;
            this.Itens = itens;
            this.Observacoes = observacoes;


        }
    }
}
