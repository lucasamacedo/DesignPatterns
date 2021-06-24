using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Arrojado : Investimento
    {
        private Random random;
        public Arrojado()
        {
            this.random = new Random();
        }
        public double Calcula(Conta conta)
        {
            int rand = random.Next(101);
            if (rand < 20)
                return conta.Saldo * 0.05;
            else if (rand < 50)
                return conta.Saldo * 0.03;
            else
                return conta.Saldo * 0.006;
        }
    }
}
