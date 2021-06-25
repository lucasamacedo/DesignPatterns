using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Aula2.Exercicio
{
    class EscolheResposta
    {
        public string EnviaRequisicao(Requisicao req, Conta conta)
        {
            RespostaXml rXml = new RespostaXml(rCsv);
            RespostaCsv rCsv = new RespostaCsv(rPorc);
            RespostaPorcento rPorc = new RespostaPorcento(rPad);
            RespostaPadrao rPad = new RespostaPadrao();

            return rXml.Responde(req, conta);
        }
    }
}
