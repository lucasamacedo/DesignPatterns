using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Aula3
{
    public class NotaFiscal
    {
        public NotaFiscal(string razaoSocial, string cnpj, DateTime dataDeEmissao, double valorBruto, 
            double impostos, IList<ItemDaNota> itens, string observacoes)
        {
            this.razaoSocial = razaoSocial;
            Cnpj = cnpj;
            DataDeEmissao = dataDeEmissao;
            ValorBruto = valorBruto;
            Impostos = impostos;
            Itens = itens;
            Observacoes = observacoes;
        }

        public String razaoSocial { get; set; }
        public String Cnpj { get; set; }
        public DateTime DataDeEmissao { get; set; }
        public double ValorBruto { get; set; }
        public double Impostos { get; set; }
        public IList<ItemDaNota> Itens { get; set; }
        public String Observacoes { get; set; }
    }
}
