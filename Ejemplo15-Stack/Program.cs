using System;
using System.Collections.Generic;

namespace Ejemplo15_Stack
{
    /*
     * Ejemplo de uso de Stack
     */
    class Program
    {
        static void Main(string[] args)
        {
            // Creo la pila
            Stack<char> pilaABC = new Stack<char>();
            // Apilo elementos
            pilaABC.Push('a');
            pilaABC.Push('b');
            pilaABC.Push('c');
            pilaABC.Push('d');
            pilaABC.Push('e');
            pilaABC.Push('f');

            // Uso un bucle para desapilar
            while (pilaABC.Count > 0)
            {
                Console.WriteLine(pilaABC.Pop());
            }
        }
    }
}
