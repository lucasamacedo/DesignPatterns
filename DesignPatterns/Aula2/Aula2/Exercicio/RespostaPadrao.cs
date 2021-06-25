using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Aula2.Exercicio
{
    class RespostaPadrao : Resposta
    {
        public Resposta Proxima { get; set; }

        public string Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.PORCENTO)
                return $"{conta.Titular} {conta.Saldo.ToString()}";
            return Proxima.Responde(req, conta);
        }
    }
}
