using DesignPatterns.Aula3;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Aula3
{
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        public abstract double MaximaTaxacao(Orcamento orcamento);
        public abstract double MinimaTaxacao(Orcamento orcamento);
        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }
            return MinimaTaxacao(orcamento);
        }
    }
}
