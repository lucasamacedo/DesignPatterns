using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Aula3
{
    public class Conta
    {
        protected EstadoDaConta Estado;
        public Conta(string titular, string numero, string agencia, double saldo, DateTime dataAbertura)
        {
            Titular = titular;
            Numero = numero;
            Agencia = agencia;
            Saldo = saldo;
            this.DataAbertura = dataAbertura;
            this.Estado = new Positivo();
        }

        public string Titular { get; private set; }
        public string Numero { get; private set; }
        public string Agencia { get; private set; }
        public double Saldo { get; set; }
        public DateTime DataAbertura { get; private set; }
        public void Deposita(double valor)
        {
            Estado.Deposita(this, valor);
        }
        public void Saca(double valor)
        {
            Estado.Saca(this, valor);
        }
        public void MudaEstadoConta(EstadoDaConta novoEstado)
        {
            Estado = novoEstado;
        }
        public void ChecaEstado()
        {
            Console.WriteLine(Estado.ToString());
        }
        public override string ToString()
        {
            return $"{Titular} - {Agencia} - {Numero}: {Saldo}  Aberto em: {DataAbertura}";
        }
    }
}
