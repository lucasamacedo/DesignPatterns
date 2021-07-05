using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Cap9
{
    class EmpresaFacadeSingleton
    {
        private static EmpresaFacade facade = new EmpresaFacade();

        public EmpresaFacade Instancia
        {
            get
            {
                return facade;
            }
        }
    }
}
