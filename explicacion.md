El patron Strategy se utiliza para proporcionar a los usuarios una forma de cambiar el comportamiento de una clase sin extenderla. Se lo conoce por tener un método que permite a los objetos anidados hacer el verdadero trabajo, así como el método seteador que permite sustituir ese objeto por otro diferente.

Em este ejemplo tengo:
Un contexto el cual define la interfaz de interés para los clientes. Este mantiene una referencia a uno de los objetos de estrategia, aunque no conoce la clase concreta de una estrategia, la cual debería trabajar con todas las estrategias a través de la interfaz de estrategia. Este acepta una estrategia a través del constructor, pero también proporciona un seteador para cambiarlo en tiempo de ejecución. Delega el trabajo al objeto Estrategia en vez de implementarlo en múltiples versiones del algoritmo por sí solo.

La interfaz declarada de la estrategia declara operaciones comunes.
Las estrategias concretas implementan el algoritmo siguiendo la base.
Finamlmente el codigo elige una estrategia concreta y la pasa al cliente que debe conocer las diferencias entre estrategias para poder tomar elegir algunsa.