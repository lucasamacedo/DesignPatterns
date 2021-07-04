using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Cap6
{
    class MensagemAdministrativa : IMensagem
    {
        private string nome;
        public IEnviador Enviador { get; set; }
        public MensagemAdministrativa(string nome)
        {
            this.nome = nome;
        }


        public void Envia()
        {
            this.Enviador.Envia(this);
        }
        public string Formata()
        {
            return String.Format("Enviando a mensagem para o administrador {0}", nome);
        }
    }
}
