using System;

namespace DesignPatterns.Aula2.Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // aula 2

            EscolheResposta escolheResposta = new EscolheResposta();

            Conta conta = new Conta("Rico", 286000);
            RespostaCsv rCsv = new RespostaCsv();
            RespostaXml rXml = new RespostaXml();
            RespostaPorcento rPorc = new RespostaPorcento();
            RespostaPadrao rPad = new RespostaPadrao();

            Requisicao req = new Requisicao(Formato.CSV);
           string resposta = escolheResposta.EnviaRequisicao(req, conta);
            Console.WriteLine(resposta);

            req = new Requisicao(Formato.XML);
            resposta = escolheResposta.EnviaRequisicao(req, conta);
            Console.WriteLine(resposta);

            req = new Requisicao(Formato.PORCENTO);
            resposta = escolheResposta.EnviaRequisicao(req, conta);
            Console.WriteLine(resposta);

            // exercicios aula 2
        }
    }
}
