using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // aula 1

            //Imposto iss = new ISS();
            //Imposto icms = new ICMS();
            //Imposto iccc = new ICCC();

            //Orcamento orcamento = new Orcamento(500.0);

            //CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            //calculador.RealizaCalculo(orcamento, icms);
            //calculador.RealizaCalculo(orcamento, iss);
            //calculador.RealizaCalculo(orcamento, iccc);

            //orcamento = new Orcamento(1500.0);
            //calculador.RealizaCalculo(orcamento, iccc);

            //orcamento = new Orcamento(3500.0);
            //calculador.RealizaCalculo(orcamento, iccc);

            // Exercicios aula 1

            //Investimento inv_c = new Conservador();
            //Investimento inv_m = new Moderado();
            //Investimento inv_a = new Arrojado();
            //Conta conta = new Conta();
            //RealizadorDeInvestimentos investidor = new RealizadorDeInvestimentos();
            //conta.Deposita(500);

            //investidor.Realiza(conta, inv_c);
            //investidor.Realiza(conta, inv_m);
            //investidor.Realiza(conta, inv_a);

            // aula 2

            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Item("CANETA", 500));
            orcamento.AdicionaItem(new Item("LAPIS", 500));
            orcamento.AdicionaItem(new Item("GELADEIRA", 500));
            orcamento.AdicionaItem(new Item("FOGAO", 500));
            orcamento.AdicionaItem(new Item("VENTILADOR", 500));
            orcamento.AdicionaItem(new Item("PIA", 500));

            double desconto = calculador.Calcula(orcamento);
            Console.WriteLine(desconto);
        }
    }
}
