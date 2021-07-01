using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Aula3
{
    public interface EstadoDaConta
    {
        void Saca(Conta conta, double valor);
        void Deposita(Conta conta, double valor);
    }
}
