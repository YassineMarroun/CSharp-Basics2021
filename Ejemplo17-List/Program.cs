using System;
using System.Collections.Generic;

namespace Ejemplo17_List
{
    /*
     * Ejemplo de uso de lista
     */
    class Program
    {
        static void Main(string[] args)
        {
            // Creo la lista
            List<char> listaABC = new List<char>();
            // Añadimos los elementos
            listaABC.Add('a');
            listaABC.Add('b');
            listaABC.Add('d');
            listaABC.Add('d');
            listaABC.Add('k');
            listaABC.Add('e');
            listaABC.Add('f');

            // Eliminamos el elemento de la posición 3, una d que está duplicada
            listaABC.RemoveAt(3);

            // Falta la c, la inserto en su lugar
            listaABC.Insert(2, 'c');

            // Elimino la k
            listaABC.Remove('k');

            // Uso un bucle para recorrer la lista (no se eliminan)
            foreach (char letra in listaABC)
            {
                Console.WriteLine(letra);
            }
        }
    }
}
