using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Aula3
{
    public class Conta
    {
        public Conta(string titular, string numero, string agencia, double saldo)
        {
            Titular = titular;
            Numero = numero;
            Agencia = agencia;
            Saldo = saldo;
        }

        public string Titular { get; private set; }
        public string Numero { get; private set; }
        public string Agencia { get; private set; }
        public double Saldo { get; private set; }
        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }
    }
}
