using System;
using System.Collections.Generic;

namespace Ejemplo16_Queue
{
    /*
     * Ejemplo de uso de Cola
     */
    class Program
    {
        static void Main(string[] args)
        {
            // Creo la cola
            Queue<char> colaABC = new Queue<char>();
            // Encolo elementos
            colaABC.Enqueue('a');
            colaABC.Enqueue('b');
            colaABC.Enqueue('c');
            colaABC.Enqueue('d');
            colaABC.Enqueue('e');
            colaABC.Enqueue('f');

            // Uso un bucle para desencolar
            while (colaABC.Count > 0)
            {
                Console.WriteLine(colaABC.Dequeue());
            }
        }
    }
}
