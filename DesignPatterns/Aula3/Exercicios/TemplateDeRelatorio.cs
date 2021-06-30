using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Aula3;

namespace DesignPatterns.Aula3
{
    public abstract class TemplateDeRelatorio
    {
        protected abstract void Cabecalho();
        protected abstract void Rodape();
        protected abstract void Corpo(IList<Conta> contas);

        public void Imprime(IList<Conta> contas)
        {
            Cabecalho();
            Corpo(contas);
            Rodape();
            Console.WriteLine();
        }
    }
}
