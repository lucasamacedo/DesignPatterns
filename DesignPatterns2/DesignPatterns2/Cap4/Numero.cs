using DesignPatterns2.Cap5;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Cap4
{
    class Numero : IExpressao
    {
        public int Valor { get; set; }

        public Numero(int numero)
        {
            this.Valor = numero;
        }

        public int Avalia()
        {
            return this.Valor;
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeNumero(this);
        }
    }
}
