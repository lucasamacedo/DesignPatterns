using DesignPatterns2.Cap4;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Cap5
{
    class ImpressoraVisitor : IVisitor
    {
        public void ImprimeSoma(Soma soma)
        {
            Console.Write("(");
            soma.Esquerda.Aceita(this);

            Console.Write(" + ");
            soma.Direita.Aceita(this);

            Console.Write(")");
        }
        public void ImprimeSubtracao(Subtracao sub)
        {
            Console.Write("(");
            sub.Esquerda.Aceita(this);

            Console.Write(" - ");
            sub.Direita.Aceita(this);

            Console.Write(")");
        }
        public void ImprimeMultiplicacao(Multiplicacao mult)
        {
            Console.Write("(");
            mult.Esquerda.Aceita(this);

            Console.Write(" * ");
            mult.Direita.Aceita(this);

            Console.Write(")");
        }
        public void ImprimeDivisao(Divisao div)
        {
            Console.Write("(");
            div.Esquerda.Aceita(this);

            Console.Write(" / ");
            div.Direita.Aceita(this);

            Console.Write(")");
        }
        public void ImprimeRaizQuadrada(RaizQuadrada rq)
        {
            Console.Write("\u221A(");
            rq.Exp.Aceita(this);
            Console.Write(")");
        }
        public void ImprimeNumero(Numero numero)
        {
            Console.Write(numero.Valor);
        }
    }
}
