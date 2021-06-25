using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // aula 2

            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Item("CANETA", 500));
            orcamento.AdicionaItem(new Item("LAPIS", 500));
            orcamento.AdicionaItem(new Item("GELADEIRA", 500));
            orcamento.AdicionaItem(new Item("FOGAO", 500));
            orcamento.AdicionaItem(new Item("VENTILADOR", 500));
            //orcamento.AdicionaItem(new Item("PIA", 500));

            double desconto = calculador.Calcula(orcamento);
            Console.WriteLine(desconto);

            // exercicios aula 2
        }
    }
}
