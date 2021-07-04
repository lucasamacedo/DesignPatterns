using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Cap4
{
    class RaizQuadrada : IExpressao
    {
        private IExpressao exp;

        public RaizQuadrada(IExpressao exp)
        {
            this.exp = exp;
        }
        public int Avalia()
        {
            return (int) Math.Sqrt(exp.Avalia());
        }
    }
}
