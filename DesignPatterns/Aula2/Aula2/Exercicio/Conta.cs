using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Aula2.Exercicio
{
    public class Conta
    {
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public Conta(string titular, double saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }
    }
}
