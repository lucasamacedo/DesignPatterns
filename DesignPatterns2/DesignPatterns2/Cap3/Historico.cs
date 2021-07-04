using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Cap3
{
    class Historico
    {
        private IList<EstadoContrato> Estados = new List<EstadoContrato>();
        public void Adiciona(EstadoContrato estado)
        {
            Estados.Add(estado);
        }
        public EstadoContrato Pega(int index)
        {
            return Estados[index];
        }
    }
}
