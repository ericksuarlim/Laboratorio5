using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio4
{
    class ConcreteEstrategiaB : IEstrategia
    {
        public object hacerAlgoritmo(object datos)
        {
            var lista = datos as List<string>;
            lista.Sort();
            lista.Reverse();

            return lista;
        }
    }
}
