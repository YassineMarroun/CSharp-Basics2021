using System;

namespace Ejempl10_Arrays
{
    /*
     * Ejemplo con distintos tipos de arrays
     */
    class Program
    {
        static void Main(string[] args)
        {
            // Array unidimensional
            int[] array1 = {1, 2, 3};
            // Al asignarle una matriz a otra, ambas hacen referencia a lo mismo
            int[] array2 = array1;
            array1[1] = 4;

            Console.WriteLine(array2[1]);
        }
    }
}
