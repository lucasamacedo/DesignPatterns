using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Aula3
{
    class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            double icms = imposto.Calcula(orcamento);
            Console.WriteLine(icms);
        }
    }
}
