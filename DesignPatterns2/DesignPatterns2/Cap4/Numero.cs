using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Cap4
{
    class Numero : IExpressao
    {
        private int numero;

        public Numero(int numero)
        {
            this.numero = numero;
        }

        public int Avalia()
        {
            return this.numero;
        }
    }
}
