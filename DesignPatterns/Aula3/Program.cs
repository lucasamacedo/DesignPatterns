using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aula 4
            //Imposto iss = new ISS(new ICMS(new IKCV()));

            //Orcamento orcamento = new Orcamento(500);

            //double valor = iss.Calcula(orcamento);

            //Console.WriteLine(valor);

            //Imposto impostos = new ImpostoMuitoAlto(new ICMS());
            //Console.WriteLine(impostos.Calcula(orcamento));
            //impostos = new ICPP(new IKCV());
            //Console.WriteLine(impostos.Calcula(orcamento));

            //IList<Conta> contas = new List<Conta> { 
            //    new Conta("Titular", "28234-5", "AG", 5250, DateTime.Now),
            //    new Conta("Titular2", "3333-3", "AH", 80, DateTime.Now),
            //    new Conta("Titular3", "4444-4", "AJ", 525000, DateTime.Now),
            //    new Conta("Titular4", "5555-5", "AK", 5000, new DateTime(2000, 8, 6)),
            //};

            //Filtro filtro = new FiltroMesmoMes(new FiltroMaiorQue500MilReais(new FiltroMenorQue100Reais()));
            //contas = filtro.Filtra(contas);
            //foreach (var conta in contas.Distinct())
            //{
            //    Console.WriteLine(conta.ToString());
            //}

            // Aula 5
            Orcamento reforma = new Orcamento(500);
            Console.WriteLine(reforma.Valor);
            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);
            reforma.Aprova();

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);
            reforma.Finaliza();
            reforma.AplicaDescontoExtra();
        }
    }
}
