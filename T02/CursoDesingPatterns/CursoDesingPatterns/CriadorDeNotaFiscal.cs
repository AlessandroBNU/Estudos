using System;
using System.Collections.Generic;

namespace CursoDesingPatterns
{
    public class CriadorDeNotaFiscal
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public string Observacoes { get; private set; }
        public DateTime Data { get; private set; }
        
        public NotaFiscal Constroi()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, Data, valorTotal, impostos, todosItens, Observacoes);
        }

        private double valorTotal;
        private double impostos;
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

        public void ParaEmpresa(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
        }
        public void ComObservacoes(string observacoes)
        {
            this.Observacoes = observacoes;
        }
        public void NaDataAtual()
        {
            this.Data = DateTime.Now;
        }
        public void ComCnpj(string cnpj)
        {
            this.Cnpj = cnpj;
        }
        public void ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            valorTotal += item.Valor;
            impostos += item.Valor * 0.05;
        }
    }
}