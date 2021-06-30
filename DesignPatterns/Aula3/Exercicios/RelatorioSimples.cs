using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Aula3;

namespace DesignPatterns.Aula3
{
    public class RelatorioSimples : TemplateDeRelatorio
    {
        private string NomeBanco = "BANCO X";
        private string Telefone = "(99) 99999-9999";
        protected override void Cabecalho()
        {
            Console.WriteLine(NomeBanco);
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach (Conta conta in contas)
            {
                Console.WriteLine($"{conta.Titular} - {conta.Saldo}");
            }
        }

        protected override void Rodape()
        {
            Console.WriteLine(Telefone);
        }
    }
}
