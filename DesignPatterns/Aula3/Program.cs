using System;
using System.Collections.Generic;

namespace DesignPatterns.Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto iss = new ISS(new ICMS(new IKCV()));

            Orcamento orcamento = new Orcamento(500);

            double valor = iss.Calcula(orcamento);
            
            Console.WriteLine(valor);

            Imposto impostos = new ImpostoMuitoAlto(new ICMS());
            Console.WriteLine(impostos.Calcula(orcamento));
        }
    }
}
