using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Aula3
{
    public class ImpostoMuitoAlto : Imposto
    {
        public ImpostoMuitoAlto(Imposto imposto) : base(imposto) { }
        public ImpostoMuitoAlto() : base() { }
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + CalculoDoOutroImposto(orcamento);
        }
    }
}
