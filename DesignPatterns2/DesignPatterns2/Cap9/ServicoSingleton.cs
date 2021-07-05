using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Cap9
{
    public class Servico
    {
        public Servico() { }
    }
    class ServicoSingleton
    {
        private static Servico servico = new Servico();

        public Servico Instancia
        {
            get
            {
                return servico;
            }
        }
    }
}
