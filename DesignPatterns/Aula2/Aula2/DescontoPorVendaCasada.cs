using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DesignPatterns
{
    class DescontoPorVendaCasada : Desconto
    {
        public Desconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Itens.Any(o => "LAPIS".Equals(o.Nome.ToUpper()))
                    && orcamento.Itens.Any(o => "CANETA".Equals(o.Nome.ToUpper())))
                return orcamento.Valor * 0.05;

            return Proximo.Desconta(orcamento);
        }
    }
}
