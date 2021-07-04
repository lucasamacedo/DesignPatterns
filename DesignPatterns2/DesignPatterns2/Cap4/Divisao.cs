using DesignPatterns2.Cap5;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Cap4
{
    class Divisao : IExpressao
    {
        private IExpressao esquerda;
        private IExpressao direita;

        public Divisao(IExpressao esquerda, IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public void Aceita(ImpressoraVisitor impressora)
        {
            throw new NotImplementedException();
        }

        public int Avalia()
        {
            int valorEsquerda = esquerda.Avalia();
            int valorDireita = direita.Avalia();
            return valorEsquerda / valorDireita;
        }
    }
}
