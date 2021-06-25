using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Aula2.Exercicio
{
    class EscolheResposta
    {
        public string EnviaRequisicao(Requisicao req, Conta conta)
        {
            RespostaPadrao rPad = new RespostaPadrao();
            RespostaPorcento rPorc = new RespostaPorcento(rPad);
            RespostaCsv rCsv = new RespostaCsv(rPorc);
            RespostaXml rXml = new RespostaXml(rCsv);
            
            //rXml.Proxima = rCsv;
            //rCsv.Proxima = rPorc;
            //rPorc.Proxima = rPad;

            return rXml.Responde(req, conta);
        }
    }
}
