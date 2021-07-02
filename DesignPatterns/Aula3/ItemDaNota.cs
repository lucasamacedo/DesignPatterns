using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Aula3
{
    public class ItemDaNota
    {
        public ItemDaNota(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public String Nome { get; set; }
        public double Valor { get; set; }

    }
}
