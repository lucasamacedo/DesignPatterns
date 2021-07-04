using DesignPatterns2.Cap5;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Cap4
{
    class RaizQuadrada : IExpressao
    {
        public IExpressao Exp { get; private set; }

        public RaizQuadrada(IExpressao exp)
        {
            this.Exp = exp;
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeRaizQuadrada(this);
        }

        public int Avalia()
        {
            return (int) Math.Sqrt(Exp.Avalia());
        }
    }
}
