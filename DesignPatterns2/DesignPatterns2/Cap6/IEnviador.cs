using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Cap6
{
    interface IEnviador
    {
        public void Envia(IMensagem mensagem);
    }
}
