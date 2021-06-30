using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Aula3
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            if (orcamento.Itens.GroupBy(x => x.Nome).Any(g => g.Count() > 1))
                return true;
            return false;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.13) + 100;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * orcamento.Itens.Count() * 0.01;
        }
    }
}
