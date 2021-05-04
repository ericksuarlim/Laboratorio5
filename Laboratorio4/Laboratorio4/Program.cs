using System;

namespace Laboratorio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // El código del cliente elige una estrategia concreta y la pasa al
            // contexto. El cliente debe conocer las diferencias entre
            // estrategias para tomar la decisión correcta.

            var context = new Contexto();

            Console.WriteLine("Cliente: la estrategia está seteada para ordenar nortmal");
            context.SetearEstrategia(new ConcreteEstrategiaA());
            context.logica();

            Console.WriteLine();

            Console.WriteLine("Cliente: la estrategia está seteada para ordenar inversamente");
            context.SetearEstrategia(new ConcreteEstrategiaB());
            context.logica();

            Console.ReadLine();

        }
    }
}
