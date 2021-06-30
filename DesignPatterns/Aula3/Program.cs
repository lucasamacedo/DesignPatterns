using System;
using System.Collections.Generic;

namespace DesignPatterns.Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            // aula 3

            Orcamento orcamento = new Orcamento(600);
            orcamento.AdicionaItem(new Item("CANETA", 500));
            orcamento.AdicionaItem(new Item("LAPIS", 500));
            orcamento.AdicionaItem(new Item("GELADEIRA", 500));
            orcamento.AdicionaItem(new Item("FOGAO", 500));
            //orcamento.AdicionaItem(new Item("CANETA", 500));
            orcamento.AdicionaItem(new Item("MICROONDAS", 500));

            IKCV iKCV = new IKCV();
            ICPP iCPP = new ICPP();
            
            Console.WriteLine(iKCV.Calcula(orcamento));
            Console.WriteLine(iCPP.Calcula(orcamento));
            
            // Exercicios aula 3
            IHIT iHIT = new IHIT();
            Console.WriteLine(iHIT.Calcula(orcamento));
            Console.WriteLine();

            RelatorioSimples rS = new RelatorioSimples();
            RelatorioComplexo rC = new RelatorioComplexo();

            IList<Conta> contas = new List<Conta> { new Conta("Titular1", "1324", "AG", 750.0) , new Conta("Titular2", "5678", "TY", 1225.0) };

            rS.Imprime(contas);
            rC.Imprime(contas);
        }
    }
}
