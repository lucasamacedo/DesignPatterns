using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Aula2.Exercicio
{
    public interface Resposta
    {
        string Responde(Requisicao req, Conta conta);
        Resposta Proxima { get; set; }
    }
}
