using System;

namespace DesignPatterns.Aula2.Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // aula 2



            // exercicios aula 2

            EscolheResposta escolheResposta = new EscolheResposta();

            Conta conta = new Conta("Rico", 286000);
            //RespostaCsv rCsv = new RespostaCsv();
            //RespostaXml rXml = new RespostaXml();
            //RespostaPorcento rPorc = new RespostaPorcento();
            //RespostaPadrao rPad = new RespostaPadrao();
            RespostaPadrao rPad = new RespostaPadrao();
            RespostaPorcento rPorc = new RespostaPorcento(rPad);
            RespostaCsv rCsv = new RespostaCsv(rPorc);
            RespostaXml rXml = new RespostaXml(rCsv);

            Requisicao req = new Requisicao(Formato.CSV);
            string resposta = rXml.Responde(req, conta);
            //string resposta = escolheResposta.EnviaRequisicao(req, conta);
            Console.WriteLine(resposta);

            req = new Requisicao(Formato.XML);
            resposta = rXml.Responde(req, conta);
            //resposta = escolheResposta.EnviaRequisicao(req, conta);
            Console.WriteLine(resposta);

            req = new Requisicao(Formato.PORCENTO);
            resposta = rXml.Responde(req, conta);
            //resposta = escolheResposta.EnviaRequisicao(req, conta);
            Console.WriteLine(resposta);
        }
    }
}
