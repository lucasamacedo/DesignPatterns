using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Aula2.Exercicio
{
    public class RespostaXml : Resposta
    {
        public RespostaXml(Resposta proxima)
        {
            Proxima = proxima;
        }

        public Resposta Proxima { get; set; }

        public string Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.XML)
                return $"<conta><titular>{conta.Titular}</titular><saldo>{conta.Saldo.ToString()}</saldo></conta>";
            
            return Proxima.Responde(req, conta);
        }
    }
}
