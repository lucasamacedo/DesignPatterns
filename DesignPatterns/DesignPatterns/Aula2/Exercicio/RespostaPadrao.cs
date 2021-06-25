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
            return $"{conta.Titular} {conta.Saldo.ToString()}";
        }
    }
}
