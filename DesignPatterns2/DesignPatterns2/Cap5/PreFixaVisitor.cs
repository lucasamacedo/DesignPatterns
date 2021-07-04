using DesignPatterns2.Cap4;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Cap5
{
    class PreFixaVisitor : IVisitor
    {
        public void ImprimeDivisao(Divisao div)
        {
            Console.Write("(");
            Console.Write(" / ");
            div.Esquerda.Aceita(this);
            Console.Write(" ");
            div.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeMultiplicacao(Multiplicacao mult)
        {
            Console.Write("(");
            Console.Write(" * ");
            mult.Esquerda.Aceita(this);
            Console.Write(" ");
            mult.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeNumero(Numero numero)
        {
            Console.Write(numero.Valor);
        }

        public void ImprimeRaizQuadrada(RaizQuadrada rq)
        {
            Console.Write("( \u221A");
            rq.Exp.Aceita(this);
            Console.Write(" )");
        }

        public void ImprimeSoma(Soma soma)
        {
            Console.Write("(");
            Console.Write(" + ");
            soma.Esquerda.Aceita(this);
            Console.Write(" ");
            soma.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeSubtracao(Subtracao subtracao)
        {
            Console.Write("(");
            Console.Write(" - ");
            subtracao.Esquerda.Aceita(this);
            Console.Write(" ");
            subtracao.Direita.Aceita(this);
            Console.Write(")");
        }
    }
}
