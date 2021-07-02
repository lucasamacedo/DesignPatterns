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
            //Orcamento reforma = new Orcamento(500);
            //Console.WriteLine(reforma.Valor);
            //reforma.AplicaDescontoExtra();
            //Console.WriteLine(reforma.Valor);
            //reforma.Aprova();

            //reforma.AplicaDescontoExtra();
            //Console.WriteLine(reforma.Valor);
            ////reforma.AplicaDescontoExtra();
            ////Console.WriteLine(reforma.Valor);
            //reforma.Finaliza();

            //Conta conta = new Conta("Titular", "28234-5", "AG", 600, DateTime.Now);
            //Console.WriteLine(conta.Saldo);
            //conta.ChecaEstado();
            //conta.Saca(700);
            //Console.WriteLine(conta.Saldo);
            //conta.ChecaEstado();
            //conta.Deposita(700);
            //Console.WriteLine(conta.Saldo);
            //conta.ChecaEstado();

            // Aula 6
            // Como seria sem o padrao:

            //IList<ItemDaNota> itens = new List<ItemDaNota>();

            //double valorTotal = 0;
            //foreach (ItemDaNota item in itens)
            //{
            //    valorTotal += item.Valor;
            //}

            //double impostos = valorTotal * 0.05;

            //NotaFiscal nf = new NotaFiscal("razao", "cnpj", DateTime.Now, valorTotal, impostos, itens, "observacao");

            // Com o padrão:
            ItemDaNotaBuilder itemBuilder = new ItemDaNotaBuilder();
            NotaFiscalBuilder criador = new NotaFiscalBuilder();
            criador
                .ParaEmpresa("Caelum Ensino e Inovacao")
                .ComCnpj("23.456.789/0011-12")
                .Com(
                    itemBuilder
                        .ComNome("Item 1")
                        .ComValor(100)
                        .Constroi())
                .Com(
                    itemBuilder
                        .ComNome("Item 2")
                        .ComValor(200)
                        .Constroi())
                .NaDataAtual()
                .ComObservacoes("Uma observacao")
                .AdicionaAcao(new EnviadorDeEmail())
                .AdicionaAcao(new NotaFiscalDao())
                .AdicionaAcao(new EnviadorDeSms());

            NotaFiscal nf = criador.Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);
        }
    }
}
