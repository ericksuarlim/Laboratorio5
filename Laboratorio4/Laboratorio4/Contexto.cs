using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio4
{
    class Contexto
    {

            // El contexto mantiene una referencia a uno de los objetos de estrategia
            // El contexto no conoce la clase concreta de una estrategia
            // Debería trabajar con todas las estrategias a través de la interfaz de estrategia
            private IEstrategia _estrategia;

            public Contexto()
            { }

            // Por lo general, el contexto acepta una estrategia a través del constructor, pero
            // también proporciona un seteador para cambiarlo en tiempo de ejecución
            public Contexto(IEstrategia estrategia)
            {
                this._estrategia = estrategia;
            }


            // Por lo general, el contexto permite reemplazar un objeto de estrategia en tiempo de ejecución
            public void SetearEstrategia(IEstrategia estrategia)
            {
                this._estrategia = estrategia;
            }

            // El contexto delega algo de trabajo al objeto Estrategia en lugar de
            // implementando múltiples versiones del algoritmo por sí solo
            public void logica()
            {
                Console.WriteLine("Contexto: ordenando usanmdo una estrategia, ojo!! no se puede saber como lo hara!");
                var resultado = this._estrategia.hacerAlgoritmo(new List<string> { "a", "b", "c", "d", "e" });

                string resultadoString = string.Empty;
                foreach (var elemento in resultado as List<string>)
                {
                resultadoString += elemento + ",";
                }

                Console.WriteLine(resultadoString);
            }
        
    }
}
