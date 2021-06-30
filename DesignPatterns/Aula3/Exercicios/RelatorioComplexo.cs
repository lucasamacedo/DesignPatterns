using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Aula3;

namespace DesignPatterns.Aula3
{
    public class RelatorioComplexo : TemplateDeRelatorio
    {
        private string NomeBanco = "Banco C";
        private string Endereco = "Rua X numero 11";
        private string Telefone = "(11) 91111-1111";
        private string Email = "bancoc@email.com";
        private DateTime Data = DateTime.Now;
        protected override void Cabecalho()
        {
            Console.WriteLine(NomeBanco);
            Console.WriteLine(Endereco);
            Console.WriteLine(Telefone);
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach (Conta conta in contas)
            {
                Console.WriteLine($"{conta.Titular} - {conta.Agencia} - {conta.Numero} - {conta.Saldo}");
            }
        }

        protected override void Rodape()
        {
            Console.WriteLine(Email);
            Console.WriteLine(Data);
        }
    }
}
