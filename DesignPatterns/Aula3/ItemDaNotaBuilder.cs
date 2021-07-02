using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Aula3
{
    public class ItemDaNotaBuilder
    {
        public String Nome { get; private set; }
        public double Valor { get; private set; }
        public ItemDaNotaBuilder ComNome(String nome)
        {
            Nome = nome;
            return this;
        }
        public ItemDaNotaBuilder ComValor(double valor)
        {
            Valor = valor;
            return this;
        }
        public ItemDaNota Constroi()
        {
            return new ItemDaNota(Nome, Valor);
        }
    }
}
