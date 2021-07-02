using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Aula3
{
    public class NotaFiscalBuilder
    {
        public String RazaoSocial { get; private set; }
        public String Cnpj { get; private set; }
        public String Observacoes { get; private set; }
        public DateTime Data { get; private set; }

        private double valorTotal;
        private double impostos;
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

        public NotaFiscalBuilder()
        {
            Data = DateTime.Now;
        }

        public NotaFiscal Constroi()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, Data, valorTotal, impostos, todosItens, Observacoes);
        }
        public NotaFiscalBuilder ParaEmpresa(String razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }
        public NotaFiscalBuilder ComCnpj(String cnpj)
        {
            Cnpj = cnpj;
            return this;
        }
        public NotaFiscalBuilder Com(ItemDaNota item)
        {
            todosItens.Add(item);
            valorTotal += item.Valor;
            impostos += item.Valor * 0.05;
            return this;
        }
        public NotaFiscalBuilder ComObservacoes(String observacoes)
        {
            Observacoes = observacoes;
            return this;
        }
        public NotaFiscalBuilder NaDataAtual()
        {
            Data = DateTime.Now;
            return this;
        }
        public NotaFiscalBuilder NaData(DateTime novaData)
        {
            Data = novaData;
            return this;
        }
    }
}
