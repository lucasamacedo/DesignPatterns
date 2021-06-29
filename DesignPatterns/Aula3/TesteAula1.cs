using System;

namespace DesignPatterns.Aula1
{
    class TesteAula1
    {
        static void Main(string[] args)
        {
            Imposto iss = new ISS();
            Imposto icms = new ICMS();
            Imposto iccc = new ICCC();

            Orcamento orcamento = new Orcamento(500.0);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            calculador.RealizaCalculo(orcamento, icms);
            calculador.RealizaCalculo(orcamento, iss);
            calculador.RealizaCalculo(orcamento, iccc);

            orcamento = new Orcamento(1500.0);
            calculador.RealizaCalculo(orcamento, iccc);

            orcamento = new Orcamento(3500.0);
            calculador.RealizaCalculo(orcamento, iccc);

            // Exercicios aula 1

            Investimento inv_c = new Conservador();
            Investimento inv_m = new Moderado();
            Investimento inv_a = new Arrojado();
            Conta conta = new Conta();
            RealizadorDeInvestimentos investidor = new RealizadorDeInvestimentos();
            conta.Deposita(500);

            investidor.Realiza(conta, inv_c);
            investidor.Realiza(conta, inv_m);
            investidor.Realiza(conta, inv_a);

        }
    }
}
